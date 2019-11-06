using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaCheekyCow
{
    //This is a DTo used to main tain the order
    public class Menu
    {
        private String name;
        private String size;
        private decimal price;
        private int quantity;
        private int stock;
        private decimal totalPrice;


        public Menu(string name, string size, decimal price, int quantity, int stock, decimal totalPrice)
        {
            this.Name = name;
            this.Size = size;
            this.Price = price;
            this.Quantity = quantity;
            this.Stock = stock;
            this.TotalPrice = totalPrice;
        }

        internal int Stock { get => stock; set => stock = value; }
        internal int Quantity { get => quantity; set => quantity = value; }
        internal decimal Price { get => price; set => price = value; }
        internal string Size { get => size; set => size = value; }
        internal string Name { get => name; set => name = value; }
        internal decimal TotalPrice { get => totalPrice; set => totalPrice = value; }

        //this method is used to return an appropriate view on the cart
        public String  writeToCartView()
        {
       
            return this.Name.PadRight(40 - this.Name.Length)+"\t\t\t"+ this.Size.PadRight(40 - this.Size.Length) + "\t\t" 
                + this.Quantity.ToString() + "\t\t\t\t" + Utility.addCurrencySymbol(this.TotalPrice);
        }

        public override string ToString()
        {
            return "[MealName:- " + this.Name + ", MealSize:- " + this.Size + ", Quantity:- " + this.Quantity + ", TotalPrice:- " + this.totalPrice +"]";
        }
        public  string wr()
        {
            return "[MealName:- " + this.Name + ", MealSize:- " + this.Size + ", Quantity:- " + this.Quantity + ", Stock:- " + this.stock + "]";
        }

     
    }
}
