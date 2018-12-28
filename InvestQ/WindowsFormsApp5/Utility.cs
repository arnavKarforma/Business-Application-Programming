/* Student Name: Arnav Karforma
 * Student ID: 18230736
 * Date: 31/10/2018
 * Assignment: 4
 * Task: It's a application for  MyInvestment Bank Corp for short-term investment product called ‘InvestQ’, 
         the purpose of this application is to process client transactions for this product.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    /* This is a helper class for all generic operations throughout the running of application*/
    class Utility
    {
        internal static decimal userAmount;
        internal static decimal rate;
        private const decimal bonus = 5000;
        private const decimal investmentForBonus = 1000000;
        private const decimal investmentForChangeInRate = 100000;
        private const int termForBonus = 5;
        internal const int nameInitialPosition = 1;
        internal const int phoneInitialPosition = 2;
        internal const int emailInitialPosition = 3;
        internal const int trxnInitialPosition = 4;
        internal const int termInitialPosition = 5;
        internal const int sumInitialPosition = 6;
        internal const int balanceInitialPosition = 7;
        internal const int totalEntriesInOneEnvestment = 7;
        internal const String outputFileName = "Output.txt";

        /* this method is used to calculae the intrest and the total balance based on term and rate*/
        private static decimal CalculateBalance(int term, decimal ir)
        {
            decimal balance = userAmount;
            decimal totalInterest = 0;

            for (int i = 0; i < term; i++)
            {
                balance = userAmount + ((balance * ir * 1) / 100) / 12 + totalInterest;
                totalInterest = balance - userAmount;
            }
            if (userAmount > investmentForBonus && term > termForBonus)
            {
                balance += bonus;
                totalInterest += bonus;
            }
            return balance;
        }

        /* This method is used to imply the business logic to come up with the interest rate */
        //All the changes to the business logic of rates allotment in future will be done here
        public static decimal rateEvaluation(int term)
        {


            if (userAmount < investmentForChangeInRate)
            {
                if (term == 1)
                    rate = 0.5M;
                else if (term == 3)
                    rate = 0.625M;
                else if (term == 6)
                    rate = 0.7125M;
                else if (term == 12)
                    rate = 1.125M;

            }
            else
            {
                if (term == 1)
                    rate = 0.6M;
                else if (term == 3)
                    rate = 0.725M;
                else if (term == 6)
                    rate = 0.8125M;
                else if (term == 12)
                    rate = 1.250M;
            }
            return CalculateBalance(term, rate);

        }

        /* This method is used to find that wether the transaction id feeded by the user is unique or not*/
        public static bool uniqueTransactionNum(int transactionNumToBeChecked)
        {
            String line = "";
            System.IO.StreamReader file = null;
            int overalCounter = 0;
            int trxnCounter = trxnInitialPosition;
            int trxn = 0;
            if (!File.Exists(outputFileName))
            {
                return true;
            }
            else
            {
                try
                {
                    file = readFile(outputFileName);
                    while ((line = file.ReadLine()) != null)
                    {
                        overalCounter++;

                        if (overalCounter == trxnCounter)
                        {
                            trxn = int.Parse(line);
                            trxnCounter += totalEntriesInOneEnvestment;
                        }
                        if (transactionNumToBeChecked == trxn)
                        {
                            return false;
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
            }
            return true;
        }



        /* this is the method that is being called by the DisplayDetails form to 
         * write into the file after all the validations being done*/
        public static bool writeTofile(ClientDetails cd)
        {
            try
            {
                File.AppendAllText(outputFileName, cd.ToString() + Environment.NewLine);
            }
            catch (IOException e)
            {
                MessageBox.Show("Unable to proceed with client's Details!!! Calls for Developers attention.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            return true;
        }

        /* This method is used to populate all the class level variables in the display details form*/
        public static void populateBalnTerm(int index)
        {
            decimal balance = 0;
            int term = 0;
            if (index == 0)
            {
                balance = rateEvaluation(1);
                term = 1;
            }
            else if (index == 1)
            {
                balance = rateEvaluation(3);
                term = 3;
            }
            else if (index == 2)
            {
                balance = rateEvaluation(6);
                term = 6;
            }
            else if (index == 3)
            {
                balance = rateEvaluation(12);
                term = 12;
            }

            DisplayDetails.balance = balance;
            DisplayDetails.term = term;
            DisplayDetails.interest = balance - userAmount;

        }

        /* This method is used to add Euro sign to all the decimal values that are used as currency*/
        public static String addCurrencySymbol(decimal value)
        {
            return value.ToString("c", System.Globalization.CultureInfo.GetCultureInfo("en-ie"));
        }

        /*This method is used to read trhe output file, 
         * and it is being used by all the method to open the file*/
        public static StreamReader readFile(String fileName)
        {
            System.IO.StreamReader file = null;

            try
            {
                file = new System.IO.StreamReader(fileName);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Unable to fetch previous data. Admin needs to pull up the backup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return file;
        }

    }
}
