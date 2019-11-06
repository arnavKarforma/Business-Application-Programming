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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        //To circulate the data that is not yet added to the cart
        Menu choosenMenu = new Menu("", "", 0,0,0,0);
        //To circulate the data that has been added to tyhe cart
        private List<Menu> addedToCart = new List<Menu>();
        //To circulate that data that has been done ion the day but not comitted to the transaction log
        private static Dictionary<String,List<Menu>> inSession = new Dictionary<String,List<Menu>>();
        int rowIndex = 0;
        static decimal totalbill = 0M;

        //Encapsulation of the data types on form level
        public List<Menu> AddedToCart { get => addedToCart; set => addedToCart = value; }
        public static Dictionary<string, List<Menu>> InSession { get => inSession; set => inSession = value; }
        public Menu ChoosenMenu { get => choosenMenu; set => choosenMenu = value; }

        //Event handler on selection of menustrip's Full Irish meal
        private void toolStripMenuItemFullIrish_Click(object sender, EventArgs e)
        {
            mealValueLabel.Text = Repository.names[0];
            ChoosenMenu.Name = Repository.names[0];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of menustrip's Irish Grill meal
        private void toolStripMenuItemIrishGrill_Click(object sender, EventArgs e)
        {
            mealValueLabel.Text = Repository.names[1];
            ChoosenMenu.Name = Repository.names[1];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of menustrip's Belmullet Grill meal
        private void toolStripMenuItemBelmulletGrill_Click(object sender, EventArgs e)
        {
            mealValueLabel.Text = Repository.names[2];
            ChoosenMenu.Name = Repository.names[2];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of menustrip's Curry Special meal
        private void toolStripMenuItemCurrySpecial_Click(object sender, EventArgs e)
        {
            mealValueLabel.Text = Repository.names[3];
            ChoosenMenu.Name = Repository.names[3];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of menustrip's IrishStew meal
        private void toolStripMenuIrishStew_Click(object sender, EventArgs e)
        {
            mealValueLabel.Text = Repository.names[4];
            ChoosenMenu.Name = Repository.names[4];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of menustrip's Student Stew meal
        private void toolStripMenuStudentStew_Click(object sender, EventArgs e)
        {
            mealValueLabel.Text = Repository.names[5];
            ChoosenMenu.Name = Repository.names[5];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of menustrip's Bacon Cabbage meal
        private void toolStripMenuBaconCabbage_Click(object sender, EventArgs e)
        {
            mealValueLabel.Text = Repository.names[6];
            ChoosenMenu.Name = Repository.names[6];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of menustrip's Colcannon
        private void toolStripMenuColcannon_Click(object sender, EventArgs e)
        {
            mealValueLabel.Text = Repository.names[7];
            ChoosenMenu.Name = Repository.names[7];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of menustrip's Boxty Special meal
        private void toolStripBoxtySpecial_Click(object sender, EventArgs e)
        {
            mealValueLabel.Text = Repository.names[8];
            ChoosenMenu.Name = Repository.names[8];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of menustrip's Boxty Special meal
        private void toolStripMenuAtlantic_Click(object sender, EventArgs e)
        {
            mealValueLabel.Text = Repository.names[9];
            ChoosenMenu.Name = Repository.names[9];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of SnackBox Special meal
        private void toolStripSnackBox_Click(object sender, EventArgs e)
        {
            mealValueLabel.Text = Repository.names[11];
            ChoosenMenu.Name = Repository.names[11];
            populateOrderBox(ChoosenMenu);

        }

        //Event handler on selection of Leprechaun meal size
        private void toolStripMenuLeprechaun_Click(object sender, EventArgs e)
        {
            sizeValueLabel.Text = Repository.sizes[0];
            ChoosenMenu.Size = Repository.sizes[0];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of Child meal size
        private void toolStripMenuChild_Click(object sender, EventArgs e)
        {
            sizeValueLabel.Text = Repository.sizes[1];
            ChoosenMenu.Size = Repository.sizes[1];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of Adult meal size
        private void toolStripMenuAdult_Click(object sender, EventArgs e)
        {
            sizeValueLabel.Text = Repository.sizes[2]; ;
            ChoosenMenu.Size = Repository.sizes[2];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of Student meal size
        private void toolStripMenuStudent_Click(object sender, EventArgs e)
        {
            sizeValueLabel.Text = Repository.sizes[3];
            ChoosenMenu.Size = Repository.sizes[3];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of Cuchulainn meal size
        private void leprechaunToolStripMenuCuchulainn_Click(object sender, EventArgs e)
        {
            sizeValueLabel.Text = Repository.sizes[4];
            ChoosenMenu.Size = Repository.sizes[4];
            populateOrderBox(ChoosenMenu);
        }

        //Event handler on selection of menustrip's Coddle meal
        private void toolStripMenuCoddle_Click(object sender, EventArgs e)
        {
            mealValueLabel.Text = Repository.names[10];
            ChoosenMenu.Name = Repository.names[10];
            populateOrderBox(ChoosenMenu);
        }

        //this method intends to populate the order box with correct details based on selection and price file
        public void populateOrderBox(Menu menu)
        {
            cartEmptyLabel.Hide();
            orderEmptyLabel.Hide();
            if(ChoosenMenu.Name != "")
            {
                mealLabel.Show();
                mealValueLabel.Show();
            }
            if(ChoosenMenu.Size != "")
            {
                sizeLabel.Show();
                sizeValueLabel.Show();
            }
            if (ChoosenMenu.Name != "" & ChoosenMenu.Size != "")
            {
                try
                {
                    System.Data.DataTable dt = Utility.ConvertCSVtoDataTable(Repository.priceFile);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (Utility.ToASCII(dt.Rows[i][0].ToString()).Equals(Utility.ToASCII(ChoosenMenu.Size)))
                        {
                            rowIndex = i;
                        }
                    }
                    ChoosenMenu.Price = decimal.Parse(dt.Rows[rowIndex][ChoosenMenu.Name].ToString().Substring(1));
                    priceValueLabel.Text = Utility.addCurrencySymbol(ChoosenMenu.Price);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Something went wrong in populateOrderBox");
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show("Operation cannot be completed now!!!! Calls for Developers attention.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
    
                priceLabel.Show();
                priceValueLabel.Show();
                priceValueLabel.Show();
                priceLabel.Show();
                quantityLabel.Show();
                QuantityTextBox.Show();
                addToOrderButton.Show();
                clearOrderButton.Show();
            }
            

        }
        //this is an event handler on main form load
        private void MenuForm_Load(object sender, EventArgs e)
        {
            defaultView();
            this.FormClosed += (s, args) =>
            {
                Utility.writeToTransactionLog(InSession);

            };
        }
        //This method intends to restore the default view of the form
        public void defaultView()
        {
            mealValueLabel.Text = "";
            sizeValueLabel.Text = "";
            priceValueLabel.Text = "";
            QuantityTextBox.Value = 0;
            mealLabel.Hide();
            mealValueLabel.Hide();
            sizeLabel.Hide();
            sizeValueLabel.Hide();
            quantityLabel.Hide();
            QuantityTextBox.Hide();
            addToOrderButton.Hide();
            clearOrderButton.Hide();
            priceLabel.Hide();
            priceValueLabel.Hide();
            cartEmptyLabel.Show();
            orderEmptyLabel.Hide();
            cartButtonsGroupBox.Hide();
            cartCheckedListBox.Hide();
            totalCostlabel.Hide();
            totalCostListBox.Hide();
            cartLabel.Hide();
            addToOrderButton.Enabled = false;
        }

        //its an event handler on click of addToOrderButton, it adds the data filled to the cart on the stock availability or displays proper message
        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChoosenMenu.Quantity == 0)
                {
                    MessageBox.Show("Please fill quantity to proceed", "Number of meals not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                System.Data.DataTable dt = Utility.ConvertCSVtoDataTable(Repository.stockFile);
                ChoosenMenu.Stock = int.Parse(dt.Rows[rowIndex][ChoosenMenu.Name].ToString());
                int availableStock = ChoosenMenu.Stock;
                int stockUsed = availableStock - ChoosenMenu.Quantity;
                int i = 0;
                foreach (var cart in AddedToCart)
                {
                    if (cart.Name.Equals(ChoosenMenu.Name) && (availableStock >= ChoosenMenu.Quantity) && cart.Size.Equals(ChoosenMenu.Size))
                    {
                        i += cart.Quantity;
                    }
                }
                availableStock = ChoosenMenu.Stock - i;
                if (availableStock <= 0)
                {
                    MessageBox.Show("Out of Stock", "Shortage of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ChoosenMenu = new Menu("", "", 0, 0, 0, 0);
                    defaultView();
                    if (addedToCart.Any())
                    {
                        cartEmptyLabel.Hide();
                        orderEmptyLabel.Show();
                        cartCheckedListBox.Show();
                        totalCostlabel.Show();
                        totalCostListBox.Show();
                        cartLabel.Show();
                        cartButtonsGroupBox.Show();
                    }
                    else
                    {
                        cartEmptyLabel.Show();
                        orderEmptyLabel.Hide();
                    }
                    return;
                }
                if (availableStock < ChoosenMenu.Quantity)
                {

                    MessageBox.Show("Not Sufficient Stock available to Order. Available stock is " + availableStock, "Shortage of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuantityTextBox.Value = availableStock;
                    QuantityTextBox.Focus();
                    QuantityTextBox.Select();
                    return;

                }
                stockUsed -= i;
                ChoosenMenu.Stock = stockUsed;
                Console.WriteLine("remaining stock  " + ChoosenMenu.Stock);
                ChoosenMenu.TotalPrice = ChoosenMenu.Price * ChoosenMenu.Quantity;
                totalbill += ChoosenMenu.TotalPrice;
                totalCostListBox.Items.Clear();
                totalCostListBox.Items.Add(Utility.addCurrencySymbol(totalbill));
                AddedToCart.Add(ChoosenMenu);
                var items = cartCheckedListBox.Items;
                items.Add(ChoosenMenu.writeToCartView());
                ChoosenMenu = new Menu("", "", 0, 0, 0, 0);
                defaultView();
                cartEmptyLabel.Hide();
                orderEmptyLabel.Show();
                cartButtonsGroupBox.Show();
                cartCheckedListBox.Show();
                totalCostlabel.Show();
                totalCostListBox.Show();
                cartLabel.Show();


            }
            catch(Exception ex)
            {
                Console.WriteLine("Something went wrong in addToOrderButton_Click");
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Operation cannot be completed now!!!! Calls for Developers attention.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //its an event handler on click of deleteSelected button, which deletes the particular order from the cart
        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in cartCheckedListBox.CheckedItems.OfType<string>().ToList())
                {
                    int i = cartCheckedListBox.SelectedIndex;
                    cartCheckedListBox.Items.Remove(item);
                    totalbill -= addedToCart.ElementAt(i).TotalPrice;
                    AddedToCart.RemoveAt(i);
                }
                totalCostListBox.Items.Clear();
                totalCostListBox.Items.Add(Utility.addCurrencySymbol(totalbill));
                if (!AddedToCart.Any())
                {
                    cartClear();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong in deleteSelectedButton_Click");
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Operation cannot be completed now!!!! Calls for Developers attention.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //its an event handler on Numeric Up down used to take the input of the quantity
        private void QuantityTextBox_ValueChanged(object sender, EventArgs e)
        {
            addToOrderButton.Enabled = true;
            if (!(QuantityTextBox.Value == 0))
            {
                ChoosenMenu.Quantity = (int)QuantityTextBox.Value;
                addToOrderButton.Enabled = true;
            }
            else
            {
                ChoosenMenu.Quantity = 0;
            }
        }

        //its an event handler used to clear all the orders details filled
        private void clearOrderButton_Click(object sender, EventArgs e)
        {
            ChoosenMenu = new Menu("", "", 0, 0, 0,0);
            defaultView();
            if (AddedToCart.Any())
            {
                orderEmptyLabel.Show();
                cartEmptyLabel.Hide();
            }
           }

        // Its an event handler on click of clearCart Button, it clears all the orders that were in cart
        private void calearCartButton_Click(object sender, EventArgs e)
        {
            cartClear();
        }

        //this the method used to clear the cart, it gets called whenever we require to clear all the orders in cart
        public void cartClear()
        {
            AddedToCart = new List<Menu>();
            totalbill = 0;
            totalCostListBox.Items.Clear();
            cartCheckedListBox.Items.Clear();
            cartButtonsGroupBox.Hide();
            cartCheckedListBox.Hide();
            totalCostlabel.Hide();
            totalCostListBox.Hide();
            cartLabel.Hide();
            orderEmptyLabel.Hide();
            cartEmptyLabel.Show();
        }

        //It is an evehandler triggered onClick of the Confirm Button, it updates the stock and saves the transaction to be latter saved on application exit 
        private void confirmButton_Click(object sender, EventArgs e)
        {
            try{
                System.Text.StringBuilder display = new StringBuilder();
                String finalDisplay = null;
                decimal ttlbill = 0M;
                String trnc = "";
                int i = 1;
                foreach (Menu m in AddedToCart)
                {

                    ttlbill += m.TotalPrice;
                    display.Append(i + ". " + m + Environment.NewLine);
                    i++;
                }
                display.Append("Total Bill:- " + Utility.addCurrencySymbol(ttlbill));
                trnc = Utility.generateID();
                finalDisplay = "Transc. No. :- " + trnc + Environment.NewLine + display;
                MessageBox.Show("This is your Order Reciept" + "\n" + finalDisplay, "ORDER !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InSession.Add(trnc, AddedToCart);
                Utility.writeToCSV(AddedToCart);
                cartClear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong in confirmButton_Click");
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Operation cannot be completed now!!!! Calls for Developers attention.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //its an onClick event handler of exit Button, it updates the transaction log whenever the application is closed
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //its triggered onClick of menustrip stock report, it gives the live update of the stock report
        private void stockToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.ShowDialog();
        }
    }
}
