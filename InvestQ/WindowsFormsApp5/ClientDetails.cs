/* Student Name: Arnav Karforma
 * Student ID: 18230736
 * Date: 31/10/2018
 * Assignment: 4
 * Task: It's a application for  MyInvestment Bank Corp for short-term investment product called ‘InvestQ’, 
         the purpose of this application is to process client transactions for this product.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
/* this is just a DTO created to store all the user input at once with a printing pattern*/
// Getter Setters were not created because there was no any multiple update of the fields used in the code.
   public class ClientDetails     {
        public String name;
        public int telephoneNum;
        public String email;
        public int transactionNum;
        public int term;
        public decimal sum;
        public decimal balance;

        public ClientDetails(string name, int telephoneNum, string email, int transactionNum, int term, decimal sum, decimal balance)
        {
            this.name = name;
            this.telephoneNum = telephoneNum;
            this.email = email;
            this.transactionNum = transactionNum;
            this.term = term;
            this.sum = sum;
            this.balance = balance;
        }

        public ClientDetails()
        {
        }

        public override string ToString()
        {
            return name + Environment.NewLine + telephoneNum+ Environment.NewLine + email+ Environment.NewLine 
                + transactionNum+ Environment.NewLine + term+Environment.NewLine+ sum+ Environment.NewLine+ balance;
        }
    }
}
