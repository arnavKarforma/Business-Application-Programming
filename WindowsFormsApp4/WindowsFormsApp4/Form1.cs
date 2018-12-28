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
using System.Windows.Forms;

namespace LearnToProg
{
    public partial class LogInForm : Form
    {
        //This flag is being used to toggle around for show and hide password
        Boolean flag = true;
        const String PASSWORD = "iLoveVisualC#";
        const int MAX_ATTEMPT = 3;
        int numOfPasswrdAttempted = 0;

        public LogInForm()
        {
            InitializeComponent();
        }

        /*Its the event handler for OnLoad of Log In form, its just to ensure showPassword 
         * is disabled on form load*/
        private void LogInForm_Load(object sender, EventArgs e)
        {
            showPasswordButton.Enabled = false;
              
        }

        /*Its the event handler for textChange for password*/
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            if (passwordTextBox.Text != "")
            {
                showPasswordButton.Enabled = true;
            }
            else
                showPasswordButton.Enabled = false;
        }

        /*Its the event handler for onClick Login button, it will not let the user let in after three faulty try */
        private void logInButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != "")
            {
                if (PASSWORD.Equals(passwordTextBox.Text) && numOfPasswrdAttempted < MAX_ATTEMPT)
                {
                    this.Hide();
                    BookingForm new_Form = new BookingForm();
                    new_Form.ShowDialog();
                    numOfPasswrdAttempted = 0;

                }
                else
                {
                    numOfPasswrdAttempted++;
                    MessageBox.Show("Invalid Password .Attempts left : " + (MAX_ATTEMPT - numOfPasswrdAttempted), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTextBox.Focus();
                    passwordTextBox.SelectAll();
                    if (numOfPasswrdAttempted == 3)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        /*Its to exit from the application*/
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Its the event handler for onClick show password button, it enables the user to hide and unhide the password */
        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                passwordTextBox.PasswordChar = '\0';
                showPasswordButton.Text = "Hide Password";
                flag = false;
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
                showPasswordButton.Text = "ShowPassword";
                flag = true;
            }


        }
    }
}
