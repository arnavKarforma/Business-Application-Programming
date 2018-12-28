/* Student Name: Arnav Karforma
 * Student ID: 18230736
 * Date: 31/10/2018
 * Assignment: 3
 * Task: It's a application for Learn2Prog Ltd, a training company,the purpose of this application is 
         to enable the company's front of house sales team to process bookings for these workshops */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToProg
{
    class Workshop
    {
         public string workshop;
         public int trainningDay;
         public decimal registrationFee;

        // this is being used to get all the userInput of workhop at one place
        //didn't use setter and getter because the fields are not seperately being overriden from any where
        public Workshop(string workshop, int trainningDay, decimal registrationFee)
        {
            this.workshop = workshop;
            this.trainningDay = trainningDay;
            this.registrationFee = registrationFee;
        }
    }
        }

