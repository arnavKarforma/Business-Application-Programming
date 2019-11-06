/* Student Name: Arnav Karforma
 * Student ID: 18230736
 * Date: 28/11/2018
 * Assignment: 5
 * Task: It's an application for electronic point of sale (EPOS) of ‘Da Cheeky Cow’ for use by their counter staff in processing customer orders
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaCheekyCow
{
    //This class is used for all the generic hmethod that are used throughout in application
    class Utility
    {
        //This method is used to fetch all the bdata from the csv file
        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            try
            {
                using (StreamReader sr = new StreamReader(strFilePath))
                {
                    string[] ths = sr.ReadLine().Split(',');
                    foreach (string th in ths)
                    {
                        dt.Columns.Add(th);
                    }
                    while (!(sr.EndOfStream))
                    {
                        DataRow dr = dt.NewRow();
                        string[] rows = sr.ReadLine().Split(',');
                        for (int i = 0; i < ths.Length; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dt.Rows.Add(dr);
                    }
                }
            }
            catch(IOException)
            {
                Console.WriteLine("Maybe File is Open, while trying to run application");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return dt;
        }
        /* This method is used to add Euro sign to all the decimal values that are used as currency*/
        public static String addCurrencySymbol(decimal value)
        {
            return value.ToString("c", System.Globalization.CultureInfo.GetCultureInfo("en-ie"));
        }
        public static string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        //this method is used to update the csv on stocks 
        public static void writeToCSV(List<Menu> menus)
        {
            try
            {
                if (!File.Exists(Repository.stockFile))
                {
                    throw new FileNotFoundException(Repository.stockFile +" File not found");
                }
                string[] lines = File.ReadAllLines(Repository.stockFile);
                String[] columnName = lines[0].Split(',');
                Dictionary<string, int> columnNumber = new Dictionary<string, int>();
                Dictionary<string, int> rowNumber = new Dictionary<string, int>();
                int i = 0;
                int j = 0;
                foreach (String column in columnName)
                {
                    columnNumber.Add(column, i);
                    i++;
                }
                foreach (String line in lines)
                {
                    String[] splitLine = line.Split(',');
                    rowNumber.Add(splitLine[0], j);
                    j++;
                }
                foreach (Menu menu in menus)
                {
                    int columnIndex = 0;
                    if (columnNumber.ContainsKey(menu.Name))
                    {
                        columnIndex = columnNumber[menu.Name];
                        Console.WriteLine("colll   " + columnNumber[menu.Name]);
                    }
                    if (rowNumber.ContainsKey(menu.Size))
                    {
                        String[] splitLine = lines[rowNumber[menu.Size]].Split(',');
                        splitLine[columnIndex] = menu.Stock.ToString();
                        lines[rowNumber[menu.Size]] = string.Join(",", splitLine);
                    }
                }
                File.WriteAllLines(Repository.stockFile, lines);
            }
            catch (IOException e)
            {
                Console.WriteLine("Something wrong happend while updating "+Repository.stockFile);
                Console.WriteLine(e.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine("Something Went wrong in writeToCSV");
                Console.WriteLine(e.StackTrace);
            }
            
        }

        //this method is used when the meal name and size read from the file, it removes special symbols 
        public static string ToASCII(string s)
        {
            return String.Join("",
                 s.Normalize(NormalizationForm.FormD)
                .Where(c => char.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark)).Trim();
        }

        //this method is used to write to a .txt file every day the whole transactions that are carried
        public static void writeToTransactionLog(Dictionary<String,List<Menu>> inSession)
        {
            try
            {
                foreach (KeyValuePair<String, List<Menu>> cart in inSession)
                {
                    decimal ttlbill = 0M;
                    String trnc = "";
                    System.Text.StringBuilder display = new StringBuilder();
                    foreach (Menu m in cart.Value)
                    {
                        ttlbill += m.TotalPrice;
                        display.Append(m + Environment.NewLine);
                    }
                    display.Append("Total Bill:- " + Utility.addCurrencySymbol(ttlbill));
                    trnc = cart.Key;
                    try
                    {
                        File.AppendAllText(Repository.transactionFile + DateTime.Now.ToShortDateString() + ".txt", "Transc. No. :- " + trnc + Environment.NewLine + display + Environment.NewLine);
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("Something went wrong When writting to the transaction file ");
                        Console.WriteLine(e.ToString());
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something Went wrong in writeToTransactionLog");
                Console.WriteLine(e.StackTrace);
            }

        }

    }
    }

