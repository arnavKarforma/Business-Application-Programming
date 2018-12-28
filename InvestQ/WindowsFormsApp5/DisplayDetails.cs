/* Student Name: Arnav Karforma
 * Student ID: 18230736
 * Date: 31/10/2018
 * Assignment: 4
 * Task: It's a application for  MyInvestment Bank Corp for short-term investment product called ‘InvestQ’, 
         the purpose of this application is to process client transactions for this product.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class DisplayDetails : Form
    {
        internal static decimal balance;
        internal static int term;
        internal static decimal interest;
        public DisplayDetails()
        {
            InitializeComponent();
        }


        /*Its the event handler triggered on chossing any of the term, it enables user to procced 
        * with feeding client's further details for making the investment*/
        private void investmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProceedButton.Enabled = true;
            resetButton.Enabled = true;
        }

        /*Its the event handler triggered on form load of the display details 
        * form which shows up once client's investment amount is feeded into the system */
        private void DisplayDetails_Load(object sender, EventArgs e)
        {
            this.investmentsListBox.Items.AddRange(new object[] {
            "1 month\t\t       "+ Utility.addCurrencySymbol(Utility.rateEvaluation(1))+"\t               "+ Utility.rate ,
            "3 month\t\t       "+ Utility.addCurrencySymbol(Utility.rateEvaluation(3))+"\t               "+ Utility.rate,
            "6 month\t\t       "+ Utility.addCurrencySymbol(Utility.rateEvaluation(6))+"\t               "+ Utility.rate,
            "12 month\t\t       "+ Utility.addCurrencySymbol(Utility.rateEvaluation(12))+"\t               "+ Utility.rate });
            baseValueLabel.Text = Utility.userAmount.ToString();
            detailsGroupBox.Hide();
            ProceedButton.Enabled = false;
            resetButton.Enabled = false;
            this.FormClosed += (s, args) =>
            {
                HomeForm form = new HomeForm();
                this.Hide();
                this.Close();
                form.ShowDialog();
            };
        }

         /*Its the event handler triggered on pressing confirm after 
          * all the details of the client has been feeded into the application,
          * it has all the validation to restrict the user to make faulty input*/
        private void confirmButton_Click(object sender, EventArgs e)
        {
            String name;
            int tel = 0;
            String email ="";
            int transaction;
            try
            {
                name = nameTextBox.Text;
                if (name.Equals(""))
                {
                    MessageBox.Show("Please fill the client's name to proceed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTextBox.Focus();
                    return;
                }
                try
                {
                    if (telephoneNumTextBox.Text.Equals(""))
                    {
                        MessageBox.Show("Please fill the client's phone number to proceed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        telephoneNumTextBox.Focus();
                        return;
                    }
                    tel = int.Parse(telephoneNumTextBox.Text);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("Please insert a valid Telephone Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    telephoneNumTextBox.Focus();
                    telephoneNumTextBox.SelectAll();
                    return;
                }
                try
                {
                    if (emailTextBox.Text.Equals(""))
                    {
                        MessageBox.Show("Please fill the client's email to proceed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        emailTextBox.Focus();
                        return;
                    }
                    email = (new System.Net.Mail.MailAddress(emailTextBox.Text)).ToString();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please insert a valid email address", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailTextBox.Focus();
                    emailTextBox.SelectAll();
                    return;
                }
                try
                {
                    if (transactionTextBox.Text.Equals(""))
                    {
                        MessageBox.Show("Please fill a transaction number to proceed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transactionTextBox.Focus();
                        return;
                    }
                    if (!(transactionTextBox.Text.Length == 6))
                    {
                        MessageBox.Show("Please fill a transaction number of six digits to proceed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transactionTextBox.Focus();
                        return;
                    }
                    transaction = int.Parse(transactionTextBox.Text);
                    if (!Utility.uniqueTransactionNum(transaction))
                    {
                        MessageBox.Show("Please fill a UNIQUE transaction number to proceed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transactionTextBox.Focus();
                        transactionTextBox.SelectAll();
                        return;
                    }
                    
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Transaction number suould be number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transactionTextBox.Focus();
                    transactionTextBox.SelectAll();
                    return;
                }

                if (MessageBox.Show("You are ready to go with this investments" + "\n" + "Name: " + name+ "\n" + "Investment: "
                    + Utility.addCurrencySymbol(Utility.userAmount)+ "\n" + "Balance: " + Utility.addCurrencySymbol(Math.Round(balance, 2)) + "\n" + "Term: " + 
                    term+"\n" + "Interest: " + Utility.addCurrencySymbol(Math.Round(interest,2)) + "\n"+"Telephone Number :" +tel + 
                    "\n" + "Email:" + email + "" + "\n" + "Transaction :" + transaction, "BOOK NOW",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(Utility.writeTofile(new ClientDetails(name, tel, email, transaction, term,Utility.userAmount, Math.Round(balance, 2))))
                    {
                        MessageBox.Show("Investment has been done", "Congratulations!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HomeForm frm = new HomeForm();
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        Console.WriteLine("Something went wrong while writing to the file. Check console");
                    }
                    investmentsListBox.SelectedIndex = -1;

                }
                    detailsGroupBox.Hide();



            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /*Its the event handler triggered on pressing Procced after the investment term has been choosen*/ 
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            detailsGroupBox.Show();
            nameTextBox.Text = "";
            telephoneNumTextBox.Text = "";
            emailTextBox.Text = "";
            transactionTextBox.Text = "";
            nameTextBox.Focus();
            Utility.populateBalnTerm(investmentsListBox.SelectedIndex);

        }
        /*Its the event handler triggered on pressing Change button, it gives 
         * the user a chance to modify client's investment amount in the midway*/
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            HomeForm frm = new HomeForm(Utility.userAmount);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        /*Its the event handler triggered on pressing Clear button, 
         * it will clear all the client's details that has been provided after choosing the investment term*/
        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            telephoneNumTextBox.Text = "";
            emailTextBox.Text = "";
            transactionTextBox.Text = "";
        }

         /*Its the event handler triggered on pressing Reset, it will remove 
          * all the choices and enteries done on the page*/
        private void resetButton_Click(object sender, EventArgs e)
        {
            investmentsListBox.SelectedIndex = -1;
            ProceedButton.Enabled = false;
            detailsGroupBox.Hide();
            resetButton.Enabled = false;
        }

        /*Its the event handler on Click of Summary button, 
          * which in turn takes the user to the summary page where user can can 
          * view transaction numbers of all the investment done and the total details*/
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            Summary_page sp = new Summary_page();
            this.Hide();
            sp.ShowDialog();
            this.Close();
        }

         /*Its the event handler on Click of Exit Button, it takes back to the home page*/
        private void exitButton_Click(object sender, EventArgs e)
        {

            HomeForm form = new HomeForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
