/* Student Name: Arnav Karforma
 * Student ID: 18230736
 * Date: 31/10/2018
 * Assignment: 3
 * Task: It's a application for Learn2Prog Ltd, a training company,the purpose of this application is 
         to enable the company's front of house sales team to process bookings for these workshops
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LearnToProg
{
    public partial class BookingForm : Form
    {
        decimal totalCost = 0;
        decimal trainingCost = 0;
        decimal locationCost = 0;
        decimal optionalCost = 0;
        //List is being used to pick all the UserInput at one place
        List<Object> userInputList;

       
       /* protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | Repository.CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }*/
        public BookingForm()
        {
            InitializeComponent();
        }

        /*Its the event handler for onClick display button, as per the user Input 
         * it will pull all the respective value from Repository
         * for calculation and populate the display group box below */
        private void displayButton_Click(object sender, EventArgs e)
        {
            decimal trainingDay = 0;
            Boolean needPrinted = false;
            decimal mealCost = 0;
            userInputList = new List<Object>();
            toggleLabels("Display");
            try
            {
                if (workShopListBox.SelectedIndex != -1)
                {
                    userInputList.Add((new Workshop(Repository.WORKSHOPNAME[workShopListBox.SelectedIndex],
                        Repository.TRAINING_DAY[workShopListBox.SelectedIndex], Repository.TRAINING_REGISTRATION_FEE[workShopListBox.SelectedIndex])));
                }
                else
                {
                    MessageBox.Show("Please Select one of the Workshop to proceed ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    workShopListBox.Focus();
                    return;
                }

                if (lodgesticListBox.SelectedIndex != -1)
                {
                    userInputList.Add((new Location(Repository.WORKSHOPLOCATION[lodgesticListBox.SelectedIndex],
                        Repository.LOCATION_COST[lodgesticListBox.SelectedIndex])));
                }
                else
                {
                    MessageBox.Show("Please Select one of the Location to proceed ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lodgesticListBox.Focus();
                    return;
                }

                if (mealsListBox.SelectedIndex != -1)
                {
                    userInputList.Add((new Meals(Repository.MEAL_NAME[mealsListBox.SelectedIndex],
                        Repository.MEAL_COST[mealsListBox.SelectedIndex])));
                }

                if(mealsListBox.SelectedIndex == -1)
                {
                    if (MessageBox.Show("Are you sure customer do not need our meal?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userInputList.Add((new Meals(Repository.NO_MEAL, Repository.NO_SELECTION)));

                    }
                    else
                    {
                        mealsListBox.Focus();
                        return;
                    }
                }

                if (!printedYesRadio.Checked && !printedNoRadio.Checked)
                {
                    MessageBox.Show("Does the Customer needs a Printed Copy", "Printed Certificate", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    printedCertificateGroupBox.Focus();
                    return;
                }

                if (printedYesRadio.Checked)
                {
                    displayValueLabel4.Text = "YES" + " " + "(" + "\u20AC" + Repository.PRINTING_COST + ")";
                    needPrinted = true;
                }
                else
                {
                    displayValueLabel4.Text = "NO" + " " + "(" + Repository.NO_SELECTION.ToString("c", System.Globalization.CultureInfo.GetCultureInfo("en-ie")) + ")";
                }

                if (userInputList[0].GetType() == typeof(Workshop))
                {
                    Workshop ws = (Workshop)userInputList[0];
                    displayValueLabel1.Text = ws.workshop+ " "+ "(" + "\u20AC" + ws.registrationFee+")";
                    trainingCost = ws.registrationFee;
                    trainingDay = ws.trainningDay;
                }

                if (userInputList[1].GetType() == typeof(Location))
                {
                    Location ls = (Location)userInputList[1];
                    locationCost = ls.lodgingFees * trainingDay;
                    displayValueLabel2.Text = ls.location + " " + "(" + "\u20AC" + locationCost + ")";
                }

                if (userInputList[2].GetType() == typeof(Meals))
                {
                    Meals meals = (Meals)userInputList[2];
                    mealCost = meals.cost * trainingDay;
                    displayValueLabel3.Text = meals.meals + " " + "(" + "\u20AC" + mealCost + ")";
                    Console.WriteLine(mealCost);
                }

                optionalCost += mealCost;

                if (needPrinted)
                {
                    optionalCost += Repository.PRINTING_COST;
                    totalCost += Repository.PRINTING_COST;
                }
                totalCost += trainingCost + locationCost + mealCost;

                summaryGroupBox.Show();
                displayValueLabel5.Text = Math.Round(totalCost, 2).ToString("c", System.Globalization.CultureInfo.GetCultureInfo("en-ie"));
                bookButton.Enabled = true;
                clearButton.Enabled = true;
                workShopListBox.SelectedIndex = -1;
                lodgesticListBox.SelectedIndex = -1;
                mealsListBox.SelectedIndex = -1;
                printedYesRadio.Checked = false;
                printedNoRadio.Checked = false;
                userInputGroupBox.Enabled = false;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Operation cannot be completed now!!!! Calls for Developers attention.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /*Its the event handler on Form Load, its just to ensure the default view */
        private void BookingForm_Load(object sender, EventArgs e)
        {
            clearButton.Enabled = false;
            bookButton.Enabled = false;
            summaryGroupBox.Hide();
            if (!File.Exists("Output.txt"))
            {
                summaryButton.Enabled = false;
            }
            //It is to disable the close form, so that user has to logOut to leave the form
            this.FormClosing += (s, args) =>
            {
                args.Cancel = true;
            };
        }

        /*Its the event handler for onClick BOOK button, it will give 
          * user a chance to look through there choices and if confirmed will parse the value to a file */
        private void bookButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("You are ready to go with your workshop booking" + "\n" + "WorkShop Name: " + displayValueLabel1.Text + "\n" + "Location :" +
                displayValueLabel2.Text + "\n" + "Meal Option:" + displayValueLabel3.Text + "" + "\n" + "Printed Certificate :" + displayValueLabel4.Text +
                "\n" + "Overall Expense :" + displayValueLabel5.Text, "BOOK NOW", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Repository.writeIntoFile(trainingCost, locationCost, optionalCost, totalCost);
                summaryButton.Enabled = true;
                MessageBox.Show("Booking has been done", "Congratulations!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Your didn't book the selected workshop", "Book was Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            summaryGroupBox.Hide();
            userInputGroupBox.Enabled = true;
            userInputList = null;
            bookButton.Enabled = false;
            trainingCost = 0;
            locationCost = 0;
            optionalCost = 0;
            totalCost = 0;
            bookButton.Enabled = false;
            clearButton.Enabled = false;
        }

        /*Its the event handler for onClick Summary button, it will show 
         * all the previous details of the booking being done */
        private void summaryButton_Click(object sender, EventArgs e)
        {
            List<string> ls = Repository.readFromFile();
            toggleLabels("Summary");
            try
            {
                displayValueLabel1.Text = ls[0];
                displayValueLabel2.Text = decimal.Parse(ls[1]).ToString("c", System.Globalization.CultureInfo.GetCultureInfo("en-ie"));
                displayValueLabel3.Text = decimal.Parse(ls[2]).ToString("c", System.Globalization.CultureInfo.GetCultureInfo("en-ie"));
                displayValueLabel4.Text = Math.Round(decimal.Parse(ls[3]), 2).ToString("c", System.Globalization.CultureInfo.GetCultureInfo("en-ie"));
                displayValueLabel5.Text = Math.Round(decimal.Parse(ls[4]), 2).ToString("c", System.Globalization.CultureInfo.GetCultureInfo("en-ie"));
                displayValueLabel6.Text = Math.Round(decimal.Parse(ls[5]), 2).ToString("c", System.Globalization.CultureInfo.GetCultureInfo("en-ie"));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            summaryGroupBox.Show();
            displayButton.Enabled = false;
            bookButton.Enabled = false;
            userInputGroupBox.Enabled = false;
            clearButton.Enabled = true;
        }
        /*Its the event handler for onClick LogOut button, it will let the user 
         * to exit from the booking portal and return to the LogIn Page*/
        private void logOutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "LOGOUT",  MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Hide();
                LogInForm new_Form = new LogInForm();
                new_Form.Show();
            }
            else
            {
                return;
            }

        }
        /*Its the event handler for onClick Clear button, it will let the user 
        to clear the choices and restore the default view*/
        private void clearButton_Click(object sender, EventArgs e)
        {
            trainingCost = 0;
            locationCost = 0;
            optionalCost = 0;
            totalCost = 0;
            displayButton.Enabled = true;
            summaryGroupBox.Hide();
            bookButton.Enabled = false;
            userInputList = null;
            userInputGroupBox.Enabled = true;
            clearButton.Enabled = false;
        }

        /* Its a method that will just toggle the groupbox labels and display of 
         * summary and Display detail to and forth*/
        public void toggleLabels(String displayType)
        {
            if (displayType.Equals("Summary"))
            {
                displayLabel6.Show();
                displayValueLabel6.Show();
                summaryGroupBox.Text = "Total Summary Detalis";
                displayLabel1.Text = "Total Booking";
                displayLabel2.Text = "Total Registration Fee";
                displayLabel3.Text = "Total Lodgistic Cost";
                displayLabel4.Text = "Optional Value Selected Cost";
                displayLabel5.Text = "Total Cost";
                displayLabel6.Text = "Average Revenue Per Booking";
                userHelpLabel.Hide();
                displayValueLabel1.Size = new Size(120, 16);
                displayValueLabel2.Size = new Size(120, 16);
                displayValueLabel3.Size = new Size(120, 16);
                displayValueLabel4.Size = new Size(120, 16);
                displayValueLabel5.Size = new Size(120, 16);

            }
            else
            {
                displayValueLabel1.Size = new Size(200, 16);
                displayValueLabel2.Size = new Size(200, 16);
                displayValueLabel3.Size = new Size(200, 16);
                displayValueLabel4.Size = new Size(200, 16);
                displayValueLabel5.Size = new Size(200, 16);
                displayLabel6.Hide();
                summaryGroupBox.Text = "Details of the Choosen Workshop";
                displayLabel1.Text = "WorkShop Selected";
                displayLabel2.Text = "Loaction Selected";
                displayLabel3.Text = "Meal Selected";
                displayLabel4.Text = "Printed Copy of Certificate";
                displayLabel5.Text = "Total workShop Cost";
                userHelpLabel.Show();
                displayValueLabel6.Hide();
            }
        }
    }
}
 