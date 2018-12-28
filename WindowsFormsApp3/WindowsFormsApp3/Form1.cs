/* Student Name: Arnav Karforma
 * Student ID: 18230736
 * Date: 16/10/2018
 * Assignment: 2
 * Task: It's a application for Belmullet Mega Cinema Ltd, that allows their cashiers to enter
         their name, along with the number of Adult, Student and Child tickets they have sold during their
         shift.  */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        //current cashier name
        String cashierName;
        //number of total tickets sold by all cashier
        static int totTicketsSold = 0;
        //number of adults per cashier entry
        int numOfAdult = 0;
        //number of students per cashier entry
        int numOfStudent = 0;
        //number of childs per cashier entry
        int numOfChild = 0;
        //total Reciepts of all cashiers
        static decimal totalReciepts = 0;
        //average price paid of all the cashiers
        static decimal averagePricePaid;
        //number of total cashier entry throughout the application cycle
        static int numOfCashier = 0;
        //to maintain the state of the inputs before calculation
        static Boolean flag = true;

        /* EventHandler on Formload */
        public Form1()
        {
            InitializeComponent();
            if (numOfCashier == 0)
            {
                summaryButton.Enabled = false;
            }
        }

        /* EventHandler on Text Change for the cashier name Input which updates the 
         * global variable cashierName and mantains its state*/
        private void cashierNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cashierNameTextBox.Text != "")
                {
                    cashierName = cashierNameTextBox.Text;
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /* EventHandler on Text Change for the Number of Adults Input which updates the 
         * global variable numOfAdult and mantains its state and Format*/
        private void numberOfAdultsTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (numberOfAdultsTextBox.Text != "")
                {
                    numOfAdult = int.Parse(numberOfAdultsTextBox.Text);
                    flag = true;
                }

            }
            catch (FormatException)
            {
                DialogResult result = MessageBox.Show("Please enter numerical data");
                if (result.Equals("OK")) ;
                {
                    numberOfAdultsTextBox.SelectAll();
                    numberOfAdultsTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /* EventHandler on Text Change for the Number of Students Input which updates the 
        * global variable  numOfStudent and mantains its state and Format*/
        private void numberOfStudentsTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (numberOfStudentsTextBox.Text != "")
                {
                    numOfStudent = int.Parse(numberOfStudentsTextBox.Text);
                    flag = true;
                }
            }
            catch (FormatException)
            {
                DialogResult result = MessageBox.Show("Please enter numerical data");
                if (result.Equals("OK")) ;
                {
                    numberOfStudentsTextBox.SelectAll();
                    numberOfStudentsTextBox.Focus();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /* EventHandler on Text Change for the Number of Childs Input which updates the 
        *  global variable of numOfChild and mantains its state and Format*/
        private void numberOfChildTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (numberOfChildTextBox.Text != "")
                {
                    numOfChild = int.Parse(numberOfChildTextBox.Text);
                    flag = true;
                }
            }
            catch (FormatException)
            {
                DialogResult result = MessageBox.Show("Please enter numerical data");
                if (result.Equals("OK")) ;
                {
                    numberOfChildTextBox.SelectAll();
                    numberOfChildTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /* EventHandler  on Click of Calculate Button which in turns 
         * calculate the cashier summary data if all fields are filled  
         * and maintains all data from different cashiers*/
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (cashierNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter Name of the Cashier");
                flag = false;
                cashierNameTextBox.Focus();
            }
            else if (numberOfAdultsTextBox.Text == "")
            {
                MessageBox.Show("You forgot to enter no of Adults");
                flag = false;
                numberOfAdultsTextBox.Focus();
            }
            else if (numberOfStudentsTextBox.Text == "")
            {
                MessageBox.Show("You forgot to enter no of Students");
                flag = false;
                numberOfStudentsTextBox.Focus();
            }
            else if (numberOfChildTextBox.Text == "")
            {
                MessageBox.Show("You forgot to enter no of Child");
                flag = false;
                numberOfChildTextBox.Focus();
            }
            else if (flag)
            {
                try
                {
                    numOfCashier++;
                    summaryDataGroupBox.Text = "Cashier Summary Data";
                    cashierLabel.Text = "Cashier Name";
                    summaryDataGroupBox.Visible = true;
                    cSummDataNameDisplay.Text = cashierName;
                    int curr_totTicketsSold = numOfAdult + numOfStudent + numOfChild;
                    totTicketsSold += curr_totTicketsSold;
                    cSummDataTotalTicketDisplay.Text = curr_totTicketsSold.ToString();
                    decimal curr_totalReciepts = (decimal)((numOfAdult * 7.7) + (numOfStudent * 7) 
                        + (numOfChild * 6.25));
                    totalReciepts += curr_totalReciepts;
                    cSummDataTotalRecieptsDisplay.Text = "€" + curr_totalReciepts.ToString();
                    decimal curr_averagePricePaid = 0;
                    if (curr_totTicketsSold != 0)
                    {
                        curr_averagePricePaid = Math.Round(curr_totalReciepts / curr_totTicketsSold, 3);
                    }
                    cSummAvgPricePaidDisplay.Text = "€" + curr_averagePricePaid + "";
                    calculateButton.Enabled = false;
                    summaryButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        /* EventHandler  on Click of Clear Button which in turns clear all 
         * the current inputs in all text boxes, and hiding the summary content 
         * if displaying*/
        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                numOfAdult = 0;
                numOfStudent = 0;
                numOfChild = 0;
                cashierNameTextBox.Text = "";
                numberOfAdultsTextBox.Text = "";
                numberOfChildTextBox.Text = "";
                numberOfStudentsTextBox.Text = "";
                summaryDataGroupBox.Visible = false;
                cashierNameLabel.Visible = true;
                cashierNameTextBox.Visible = true;
                ticketSoldGroupBox.Visible = true;
                calculateButton.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /* EventHandler on Click of Summary Button which in turns 
         * displays total data of all the cashiers data at once and 
         * their total tickets sold, reciept average*/
        private void summaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                calculateButton.Enabled = false;
                cashierNameLabel.Visible = false;
                cashierNameTextBox.Visible = false;
                ticketSoldGroupBox.Visible = false;
                summaryDataGroupBox.Text = "Cinema Summary Data";
                cashierLabel.Text = "Total Cashiers";
                cSummDataNameDisplay.Size = new Size(103, 22);
                summaryDataGroupBox.Visible = true;
                cSummDataNameDisplay.Text = numOfCashier + "";
                cSummDataTotalTicketDisplay.Text = totTicketsSold.ToString();
                cSummDataTotalRecieptsDisplay.Text = "€" + totalReciepts.ToString();
                if (totalReciepts != 0)
                {
                    averagePricePaid = Math.Round(totalReciepts / totTicketsSold, 3);
                }
                cSummAvgPricePaidDisplay.Text = "€" + averagePricePaid + "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /* EventHandler on Click of Exit Button, which kills the 
         * application as a whole*/
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
