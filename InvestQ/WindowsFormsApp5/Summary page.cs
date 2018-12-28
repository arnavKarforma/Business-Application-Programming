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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Summary_page : Form
    {
        public Summary_page()
        {
            InitializeComponent();
        }

        /*Its the event handler on Form load of Summary Page, 
       * where user can view transaction numbers of all the investment done and the total details*/
        private void Summary_page_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Utility.outputFileName))
            {
                MessageBox.Show("Nothing to Display, No any investment Done","NO Records Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HomeForm form = new HomeForm();
                this.Hide();
                form.ShowDialog();
                this.Close();
                return;
            }
            this.FormClosed += (s, args) =>
            {
                HomeForm form = new HomeForm();
                this.Hide();
                form.ShowDialog();
                this.Close();
            };
            Search();
        }

        /*Purpose of this method is to read from the Output file and populate
         * the list view for the Summary Page calculating few opf the fields*/
        public void Search()
        {
            String line = null;
            int overalCounter = 0;
            int termCounter = Utility.termInitialPosition;
            int sumCounter = Utility.sumInitialPosition;
            int trxnCounter = Utility.trxnInitialPosition;
            int balanceCounter = Utility.balanceInitialPosition;
            int trxn = 0;
            double averageTerm = 0.0;
            decimal totalSum = 0.0M;
            int term = 0;
            decimal totalBalance = 0;
            if (!File.Exists(Utility.outputFileName))
            {
                MessageBox.Show(" There is no investment to show", "No Investments Done", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            System.IO.StreamReader file = null;
            try
            {
                file = Utility.readFile(Utility.outputFileName);
                while ((line = file.ReadLine()) != null)
                {
                    overalCounter++;
                    if (overalCounter == termCounter)
                    {
                        term += int.Parse(line);
                        termCounter += Utility.totalEntriesInOneEnvestment;
                    }
                    if (overalCounter == trxnCounter)
                    {
                        trxn = int.Parse(line);
                        trxnCounter += Utility.totalEntriesInOneEnvestment;
                        var item1 = new ListViewItem(trxn.ToString());
                        summaryListView.Items.Add(item1);
                    }
                    if (overalCounter == sumCounter)
                    {
                        totalSum += decimal.Parse(line);
                        sumCounter += Utility.totalEntriesInOneEnvestment;
                    }
                    if (overalCounter == balanceCounter)
                    {
                        totalBalance += decimal.Parse(line);
                        balanceCounter += Utility.totalEntriesInOneEnvestment;
                    }
                }
                totalInvestmentValueLabel.Text = Utility.addCurrencySymbol(totalSum);
                totalIntrestValueLabel.Text = Utility.addCurrencySymbol(totalBalance - totalSum);
                averageTerm = Math.Round(((double)term / (overalCounter / Utility.totalEntriesInOneEnvestment)), 2);
                averageTermValueLabel.Text = averageTerm.ToString();
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
    }
