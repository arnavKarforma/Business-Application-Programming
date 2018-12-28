/* Student Name: Arnav Karforma
 * Student ID: 18230736
 * Date: 31/10/2018
 * Assignment: 3
 * Task: It's a application for Learn2Prog Ltd, a training company,the purpose of this application is 
         to enable the company's front of house sales team to process bookings for these workshops */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnToProg
{
    /* This class is being used to store all the constant data and all the utility methods are 
     * here to read and write in the file*/ 
    class Repository
    {
        public const decimal PRINTING_COST = 29.95M;
        public static readonly String[] WORKSHOPNAME = {"ASP.NET with C#","Windows App with C#",".NET Prog using C# Part 1",".NET Prog using C# Part 2","Digital Deto" };
        public static readonly int[] TRAINING_DAY = { 4,3,4,4,1};
        public static readonly decimal[] TRAINING_REGISTRATION_FEE = {1200,1000,1500,1800,599};
        public static readonly String[] WORKSHOPLOCATION = { "Cork", "Dublin", "Galway", "Belmullet", "Limerick", "Wexford" };
        public static readonly int[] LOCATION_COST = {150,225,175,305,135,89 };
        public static readonly String[] MEAL_NAME = { "Full Board", "Half Board", "Breakfast" };
        public static readonly decimal[] MEAL_COST = { 39.50M,27.50M,12.50M};
        public const decimal NO_SELECTION = 0;
        public static readonly String NO_MEAL = "No Meal";
        public const int CP_NOCLOSE_BUTTON = 0x200;

        /*This method is being used to read all 
         * the previous booking's data from file"*/
        public static List<string> readFromFile()
        {
            List<string> prevSummary = new List<string>();
            System.IO.StreamReader file = null;
            try
            {
                string line;
                try
                {
                    file = new System.IO.StreamReader("Output.txt");
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show("Unable to fetch previous data. Admin needs to pull up the backup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                while ((line = file.ReadLine()) != null)
                {
                    prevSummary.Add(line);
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
            return prevSummary;
        }

        /*This method is being used to read all the previous booking's data from file and write them back with the updated data"*/
        public static Boolean writeIntoFile(decimal totalRegistrationCost, decimal totalLodgingCost, decimal optionalCost, decimal totalCost)
        {
            int numOfRegistration = 1;
            string[] res ;
            List<string> ls = null;

            try
            {
                if (File.Exists("Output.txt"))
                {
                    ls = readFromFile();
                    numOfRegistration += int.Parse(ls[0]);
                    res = new string[]  { numOfRegistration.ToString(), (decimal.Parse(ls[1])+ totalRegistrationCost).ToString(),
                    (decimal.Parse(ls[2])+totalLodgingCost).ToString(), (optionalCost+ decimal.Parse(ls[3])).ToString(),
                    (totalCost + decimal.Parse(ls[4])).ToString(), ((totalCost+ decimal.Parse(ls[4]))/numOfRegistration).ToString() };
                }
                else
                {
                    res = new string[] { numOfRegistration.ToString(), (totalRegistrationCost).ToString(),
                    (totalLodgingCost).ToString(), (optionalCost).ToString(),
                    (totalCost).ToString(), (totalCost/numOfRegistration).ToString() };
                }
                try
                {
                    File.WriteAllLines("Output.txt", res);
                }
                catch (IOException e)
                {
                    MessageBox.Show("Unable to book your workshop request!!! Calls for Developers attention.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(e.StackTrace);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return true;
        }

    }


}
