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
using System.Drawing;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class HomeForm : Form
    {
        /*This variable is used to get the user same investment amount on 
         the home page when they click change on display details page*/
        String SessionSum = null;
        public HomeForm()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.ExitThread();
        }
        /* This parameterized constructor is used to maintain the user Input 
         * when "Change" button is clicked on the display detail form*/
        public HomeForm(decimal sessionSum)
        {
            InitializeComponent();
            SessionSum = sessionSum.ToString();
        }

        /*Its the event handler on Click of Display Button which take 
         * the user to display details where they can choose the investment type and confirm*/
        private void displayButton_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            try
            {
                sum = decimal.Parse(principalInputTextBox.Text);
                Utility.userAmount = sum;
                this.Hide();
                DisplayDetails ds = new DisplayDetails();
                ds.ShowDialog();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter any valid investment amount to proceed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                principalInputTextBox.Focus();
                principalInputTextBox.SelectAll();
            }
        }
        /*Its the event handler for OnLoad of home page of InvestQ
         * where user's investment amount can be feeded or previous transaction can be searched*/
        private void HomeForm_Load(object sender, EventArgs e)
        {
            principalInputTextBox.Focus();
            displayButton.Enabled = false;
            if (SessionSum != null)
            {
                principalInputTextBox.Text = SessionSum;
                displayButton.Enabled = true;
            }
            SearchListView.Hide();
            SearchButton.Enabled = false;
            clearSearchButton.Enabled = false;
            searchTextBox.Enabled = false; 
        }

         /*Its the event handler on text change in the user Input for investment,
          * to enable search button once amount has been entered*/
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchButton.Enabled = true;
        }

        /*Its the event handler on Click of search button,
       * it will search either based on transaction or email as selected by the radio button by the user*/
        private void SearchButton_Click(object sender, EventArgs e)
        {
            String email = null;
            if (!searchByTrxnRadioButton.Checked && !searchByEmaiRadiolButton.Checked)
            {
                MessageBox.Show("Please mark what you want to search Email or Transaction Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(searchTextBox.Text == "")
            {
                MessageBox.Show("Please insert a value to search", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!File.Exists(Utility.outputFileName))
            {
                MessageBox.Show("Nothing to Display, No any investment Done", "NO Records To Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (searchByEmaiRadiolButton.Checked)
            {
                try
                {
                    searchByTrxnRadioButton.Enabled = false;
                    email = (new System.Net.Mail.MailAddress(searchTextBox.Text)).ToString();
                    if (Search(email, 0))
                    {
                        SearchListView.Show();
                    }
                    else
                    {
                        MessageBox.Show("No Records Found", "Nothing to Show", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        searchTextBox.Focus();
                        searchTextBox.SelectAll();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please insert a valid email address", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    searchTextBox.Focus();
                    searchTextBox.SelectAll();
                }
            }
            else if (searchByTrxnRadioButton.Checked)
            {
                try
                {
                    searchByEmaiRadiolButton.Enabled = false;
                    if (Search(null, int.Parse(searchTextBox.Text)))
                    {
                        SearchListView.Show();
                    }
                    else
                    {
                        MessageBox.Show("No Records Found", "Nothing to Show", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        searchTextBox.Focus();
                        searchTextBox.SelectAll();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please insert a validtransaction number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    searchTextBox.Focus();
                    searchTextBox.SelectAll();
                }
 
            }
        }
        /*Purpose of this method is to read from the Output file and populate the list view for the search query*/
        public Boolean Search(String emailToBeChecked, int trxnNumToBeChecked)
        {
            String line = null;
            int overalCounter = 0;
            int nameCounter = Utility.nameInitialPosition;
            int phoneCounter = Utility.phoneInitialPosition;
            int emailCounter = Utility.emailInitialPosition;
            int trxnCounter = Utility.trxnInitialPosition;
            int termCounter = Utility.termInitialPosition;
            int sumCounter = Utility.sumInitialPosition;
            int balanceCounter = Utility.balanceInitialPosition;
            String name = null;
            int phone = 0;
            String email = null;
            int trxn = 0;
            int term = 0;
            decimal sum = 0;
            decimal balance = 0;
            Boolean flag = true;
            Boolean searchElementExist = false;
            System.IO.StreamReader file = null;
            try
            {
                file = Utility.readFile(Utility.outputFileName);
                while ((line = file.ReadLine()) != null)
                {
                    overalCounter++;
                    if (overalCounter == nameCounter)
                    {
                        name = line;
                        nameCounter += Utility.totalEntriesInOneEnvestment;
                        flag = false;
                    }
                    if (overalCounter == phoneCounter)
                    {
                        phone = int.Parse(line);
                        phoneCounter += Utility.totalEntriesInOneEnvestment;
                    }
                    if (overalCounter == emailCounter)
                    {
                        email = line;
                        emailCounter += Utility.totalEntriesInOneEnvestment;
                    }
                    if (overalCounter == trxnCounter)
                    {
                        trxn = int.Parse(line);
                        trxnCounter += Utility.totalEntriesInOneEnvestment;
                    }
                    if (overalCounter == termCounter)
                    {
                        term = int.Parse(line);
                        termCounter += Utility.totalEntriesInOneEnvestment;
                    }
                    if (overalCounter == sumCounter)
                    {
                        sum = decimal.Parse(line);
                        sumCounter += Utility.totalEntriesInOneEnvestment;
                    }
                    if (overalCounter == balanceCounter)
                    {
                        balance = decimal.Parse(line);
                        balanceCounter += Utility.totalEntriesInOneEnvestment;
                        flag = true;
                    }
                    if (flag == true && emailToBeChecked != null && email.Equals(emailToBeChecked))
                    {
                        var item1 = new ListViewItem(trxn.ToString());
                        item1.SubItems.Add(name);
                        item1.SubItems.Add(phone.ToString());
                        item1.SubItems.Add(email);
                        item1.SubItems.Add(term.ToString());
                        item1.SubItems.Add(Utility.addCurrencySymbol(sum));
                        item1.SubItems.Add(Utility.addCurrencySymbol(balance));
                        item1.SubItems.Add(term.ToString());
                        SearchListView.Items.Add(item1);
                        searchElementExist = true;
                    }
                    else if (flag == true && trxnNumToBeChecked != 0 && (trxn == trxnNumToBeChecked))
                    {
                        var item1 = new ListViewItem(trxn.ToString());
                        item1.SubItems.Add(name);
                        item1.SubItems.Add(phone.ToString());
                        item1.SubItems.Add(email);
                        item1.SubItems.Add(term.ToString());
                        item1.SubItems.Add(Utility.addCurrencySymbol(sum));
                        item1.SubItems.Add(Utility.addCurrencySymbol(balance));
                        item1.SubItems.Add(term.ToString());
                        SearchListView.Items.Add(item1);
                        searchElementExist = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Operation cannot be completed now!!!! Calls for Developers attention.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                file.Close();
            }

            return searchElementExist;
        }


        /*Its the event handler on Click of Clear button, which in turn clears 
         * all the last search record and takes the application to Form On Load view*/
        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            SearchListView.Items.Clear();
            SearchListView.Hide();
            searchByEmaiRadiolButton.Enabled = true;
            searchByTrxnRadioButton.Enabled = true;
            searchByEmaiRadiolButton.Checked = false;
            searchByTrxnRadioButton.Checked = false;
            searchTextBox.Clear();
            searchTextBox.Enabled = false;
            displayButton.Enabled = true;
            SearchButton.Enabled = false;
            principalInputTextBox.Enabled = true;
        }

        /*Its the event handler on Click of Summary button, 
         * which in turn takes the user to the summary page where user can view transaction numbers of all the investment done and the total details*/
        private void SummButton_Click(object sender, EventArgs e)
        {
            Summary_page sp = new Summary_page();
            this.Hide();
            sp.ShowDialog();
            this.Close();
        }

        /*Its the event handler on Check of the search by Email Radio Button*/
        private void searchByEmaiRadiolButton_CheckedChanged(object sender, EventArgs e)
        {
            clearSearchButton.Enabled = true;
            searchTextBox.Enabled = true;
            displayButton.Enabled = false;
            principalInputTextBox.Enabled = false;
            searchTextBox.Clear();

        }

        /*Its the event handler on Check of the search by Transaction Number*/
        private void searchByTrxnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clearSearchButton.Enabled = true;
            searchTextBox.Enabled = true;
            displayButton.Enabled = false;
            principalInputTextBox.Enabled = false;
            searchTextBox.Clear();
        }

        /*Its the event handler on text Change of the investment user Input, it will enable the display button*/
        private void principalInputTextBox_TextChanged(object sender, EventArgs e)
        {
            displayButton.Enabled = true;
        }

        /*Its the event handler on Click of the exit Logo, which will kill the whole application*/
        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }
    }
}
