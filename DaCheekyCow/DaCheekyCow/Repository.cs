/* Student Name: Arnav Karforma
 * Student ID: 18230736
 * Date: 28/11/2018
 * Assignment: 5
 * Task: It's an application for electronic point of sale (EPOS) of ‘Da Cheeky Cow’ for use by their counter staff in processing customer orders
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaCheekyCow
{
    //This class is used to keep the record of the meal name and size, if in future they are changed this file needs to be modified too.
    class Repository
    {
        internal static readonly String[] names = {"Full Irish","Irish Grill","Belmullet Grill","Curry Special","Irish Stew","Student Stew",
                                            "Bacon & Cabbage","Colcannon","Boxty Special","Atlantic Way","Coddle","Snack Box"};
        internal static readonly String[] sizes = {"Leprechaun","Child","Adult","Student","Cúchulainn" };
        internal static readonly String stockFile = "Stock.csv";
        internal static readonly String transactionFile = "OrdersOn_";
        internal static readonly String priceFile = "Prices.csv";
    }
}
