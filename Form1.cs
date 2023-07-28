using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Zurbano
{
    public partial class Form1 : Form
    {
        //Constant value for the prices.
        const decimal SMALL = 10.00m, MEDIUM = 15.00m, LARGE = 20.00m, ADDS=1.00m;

        //Variables for holding the value of subtotal and total of a customer, and the total sales of the day.
        decimal subTotal, total, totalSalesPerDay;

        //Variables to hold the string value(names) of the selected size and add-ons.
        string sizeSelection, addSelection="";

        //flavorIndex and sizeIndex variables are used to determine the index 
        //of the selected flavor and size to access the itemSoldPerDay array.
        //customer and day variables are used to count the day and the no. of customer for a day.
        int flavorIndex, sizeIndex, customer=0, day=1;

        //Array to count the no. of item/milkshake sold for a day.
        int[,] itemSoldPerDay = new int[8, 3];

        //Array to count the no. of item/milkshake ordered by the customer.
        //This will serve as temporary storage before clicking the place order button.
        int[,] itemSoldPerCustomer = new int [8,3];

        //String array  to hold the names of the flavors to be accessed when showing the statistics.
        string[] flavors = { "Banana Cream Pie        ",
                             "Cherry Vanilla              ",
                             "Fruity Pebble               ",
                             "Oreo Cheesecake         ",
                             "Peanut Butter Brownie",
                             "S'mores                          ",
                             "Salted Caramel              ",
                             "Strawberry Shortcake    "};


        public Form1()
        {
            InitializeComponent();
        }

        //Combo Box Method
            private void cmboFlavor_SelectedIndexChanged(object sender, EventArgs e)
            {
                //Getting and storing the index of the selected flavor from the combo box.
                flavorIndex = cmboFlavor.SelectedIndex;  
                //When a flavor is selected, it enables the Add Button.
                btnAdd.Enabled = true;
            }


        //Radio Button Method
            private void radSmall_CheckedChanged(object sender, EventArgs e)
            {   
                //Getting the index of the selected size.
                sizeIndex = 0;      
                //Assigning the price to the sub total.
                subTotal = SMALL;
                //Storing the name of the selected size.
                sizeSelection = radSmall.Text;
            }
            private void radMedium_CheckedChanged(object sender, EventArgs e)
            {
                sizeIndex = 1;
                subTotal = MEDIUM;
                sizeSelection = radMedium.Text;
            }
            private void radLarge_CheckedChanged(object sender, EventArgs e)
            {
                sizeIndex = 2;
                subTotal = LARGE;
                sizeSelection = radLarge.Text;
            }


        //Add Order Button
            private void btnAdd_Click(object sender, EventArgs e)
            {
                //Displaying all the selected order/s in the richtextbox.
                rtxtOrder.Text += "\n" + sizeSelection + " " + cmboFlavor.Text;

                    //Getting and storing all the selected items in the listbox
                    //and will add $1.00 in the subtotal for every selected items.
                    foreach (string addOns in lstAddOns.SelectedItems)
                    {
                        addSelection += "\t" + addOns + "\n";
                        subTotal += ADDS;
                    }

                rtxtOrder.Text += "\n\twith:\n";
                
                //To display "No Add-Ons" if there is no selected item in the listbox.
                if (addSelection == "")
                    rtxtOrder.Text += "\tNo Add- Ons\n";
                else
                    rtxtOrder.Text += addSelection;

                //To Display the sub total per order.
                rtxtOrder.Text += "\tSub-total: " + subTotal.ToString("C") + "\n";

                //To compute and display the total price of the customer.
                total += subTotal;
                txtTotal.Text = total.ToString("C");

                //To count the no. of item/s ordered by the customer.
                itemSoldPerCustomer[flavorIndex, sizeIndex] += 1;
                
                //Setting the value of subtotal to 0.
                subTotal = 0;

                //To clear all the selected items.
                clearSelection();
                
                //Disabling the Add Order button and enabling the Reset and Place Order button.
                btnAdd.Enabled = false;
                btnPlace.Enabled = true;
                btnReset.Enabled = true;
            }


        //Reset Button Method
            private void btnReset_Click(object sender, EventArgs e)
            {
                //Clearing all selected items and the displays in the richtextbox.
                clearSelection();
                clearDisplay();
                //Disabling all buttons.
                clearButton();

                //Setting all value of itemSoldPerCustomer to zero.
                for (int i = 0; i <= itemSoldPerDay.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j <= itemSoldPerDay.GetLength(1) - 1; j++)
                    {
                        itemSoldPerCustomer[i, j] = 0;
                    }
                }
            }

        //Place Order Button Method
            private void btnPlace_Click(object sender, EventArgs e)
            {
                //Counting the no. of items ordered by the customer.
                for(int i=0; i<=itemSoldPerDay.GetLength(0)-1; i++)
                {
                    for(int j=0; j<=itemSoldPerDay.GetLength(1)-1; j++)
                    {
                        itemSoldPerDay[i, j] += itemSoldPerCustomer[i, j];
                        itemSoldPerCustomer[i, j] = 0;
                    }
                }

                //To compute the total sales per day.
                totalSalesPerDay += total;

                //Clearing all selected items and the displays in the richtextbox.
                clearSelection();
                clearDisplay();
                //Disabling all buttons.
                clearButton();

                //The customer counter will increment and display in the label for customer.
                customer++;
                lblCustomer.Text = "Customer " + (customer+1);
            }


        //User defined Method to clear the selection.
            private void clearSelection()
            {
                radSmall.Checked = false;
                radMedium.Checked = false;
                radLarge.Checked = false;
                cmboFlavor.SelectedIndex = -1;
                lstAddOns.ClearSelected();
                addSelection = "";
            }

        //User defined Method to clear the display on the richtextbox and textbox object.
        private void clearDisplay()
            {
                rtxtOrder.Text = "Order/s:";
                txtTotal.Text = "";
                subTotal = 0;
                total = 0;
            }
        
        //User defined method to disabled the Add, Place and Reset buttons.
            private void clearButton()
            {
                btnAdd.Enabled = false;
                btnPlace.Enabled = false;
                btnReset.Enabled = false;
            }



        //File - End Day Method
            private void endDay_FileMenu_Click(object sender, EventArgs e)
            {
                //String variale to store the statistics of the day.
                string stat; 

                //Storing the desired display of the statistics in stat(string) variable.
                stat = "Day " + day + "\n\n";
                stat += "Flavor\t\t\t Small\t\t Medium\t\t Large\n\n";

                //Accessing all the value stored in itemSoldPerDay array and concatenate it in stat.
                for (int i = 0; i <= itemSoldPerDay.GetLength(0) - 1; i++)
                {
                    stat += flavors[i] + "\t";
                    for (int j = 0; j <= itemSoldPerDay.GetLength(1) - 1; j++)
                    {
                        stat += itemSoldPerDay[i, j] + "\t\t";
                    }
                    stat += "\n";
                }

                //Adding and storing the value of the totalSalesPerDay in stat.
                stat += "Total Sales: " + totalSalesPerDay.ToString("C");
                //Adding and storing the value of customer(counter) in stat.
                stat += "\nNo. of Customer: " + customer;

                //Accessing the stored string value of stat and displaying it in a message box.
                MessageBox.Show(stat, "Statistics");

                //Returning the value of customer to 0 and display Customer 1 in the label for customer.
                customer = 0;
                lblCustomer.Text = "Customer " + (customer+1);

                //The day(counter) is incremented by 1 and display it in the label for day.
                day++;
                lblDay.Text = "Day" + day;

                //Setting the value of itemSoldPerDay and itemSoldPerCustomer array to 0.
                for (int i = 0; i <= itemSoldPerDay.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j <= itemSoldPerDay.GetLength(1) - 1; j++)
                    {
                        itemSoldPerDay[i, j] = 0;
                        itemSoldPerCustomer[i, j] = 0;
                    }
                }

                //Setting the value of totalSalesPerDay to 0.
                totalSalesPerDay = 0;
            }
        

        //File - Reset Day Method
            private void resetDay_FileMenu_Click(object sender, EventArgs e)
            {
                //The day(counter) was reset to 1 as well as the display in the label for day.
                day = 1;
                lblDay.Text = "Day " + day;
                //Message box showing that the day was back to day 1.
                MessageBox.Show("Back to Day 1.", "Reset Day");
            }


        //File - Exit Method
            private void exit_FileMenu_Click(object sender, EventArgs e)
            {
                //To exit and close the application.
                Application.Exit();
            }
        

        
        //Edit - Background Color Method
            private void bgColor_EditMenu_Click(object sender, EventArgs e)
            {
                //First, you must drag the colorDialog1(in Toolbox) to the form.
                //To change the background color of the form:
                colorDialog1.Color = this.BackColor;
                if (colorDialog1.ShowDialog() != DialogResult.Cancel)
                    this.BackColor = colorDialog1.Color;
            }


        //Edit - Font Color  Method
            private void fontColor_EditMenu_Click(object sender, EventArgs e)
            {
                //To change the font color of the form as well as the panel1 color:
                colorDialog1.Color = this.ForeColor;
                colorDialog1.Color = panel1.BackColor;
                if (colorDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    this.ForeColor = colorDialog1.Color;
                    panel1.BackColor = colorDialog1.Color;
                }
            }


        //Edit - Font Style Method
            private void fontStyle_EditMenu_Click(object sender, EventArgs e)
            {
                //First, you must drag the fontDialog1(in Toolbox) to the form.
                //To change the font style of the form:
                fontDialog1.Font = this.Font;
                if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                    this.Font = fontDialog1.Font;
            }


        //Help - About Method
            private void about_HelpMenu_Click(object sender, EventArgs e)
            {
                //Displaying the name and the version of the application in a Message Box.
                MessageBox.Show("Mr. Frostie Ordering Application\n\n" +
                    "Version 1.0", "About");
            }
    }
}
