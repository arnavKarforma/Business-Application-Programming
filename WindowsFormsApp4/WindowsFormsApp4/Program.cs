/* Student Name: Arnav Karforma
 * Student ID: 18230736
 * Date: 31/10/2018
 * Assignment: 3
 * Task: It's a application for Learn2Prog Ltd, a training company,the purpose of this application is 
         to enable the company's front of house sales team to process bookings for these workshops */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnToProg
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInForm());
        }
    }
}
