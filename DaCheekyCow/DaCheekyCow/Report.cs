/* Student Name: Arnav Karforma
 * Student ID: 18230736
 * Date: 28/11/2018
 * Assignment: 5
 * Task: It's an application for electronic point of sale (EPOS) of ‘Da Cheeky Cow’ for use by their counter staff in processing customer orders
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

namespace DaCheekyCow
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        //This is on form load even handler which automatically pulls up the data from the .csv sheet and displays the stock report
        private void Report_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(Repository.stockFile))
                {
                    throw new FileNotFoundException(Repository.stockFile + " File not found");
                }
                System.Data.DataTable dt = Utility.ConvertCSVtoDataTable(Repository.stockFile);
                for (int column = 1; column < dt.Columns.Count; column++)
                {
                    var item1 = new ListViewItem(dt.Columns[column].ToString());
                    for (int rows = 0; rows < dt.Rows.Count; rows++)
                    {
                        String value = dt.Rows[rows][column].ToString();
                        item1.SubItems.Add(value);
                    }
                    listViewStock.Items.Add(item1);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Something wrong happend while reading " + Repository.stockFile);
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Operation cannot be completed now!!!! Calls for Developers attention. Please close "+Repository.stockFile+" if it is open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something Went wrong in writeToCSV");
                Console.WriteLine(ex.StackTrace);
            }


        }

        //This closes the report form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
