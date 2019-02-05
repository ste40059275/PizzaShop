using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class frmPizza : Form
    {
        public frmPizza()
        {
            InitializeComponent();
        }





        //Variables to hold the values 
        public static double dPrice, dSubTotal, dDiscount = 0;
        public static int dTotal = 0;

        private void pichawiian_MouseLeave(object sender, EventArgs e)
        {
            //code to clear the pizza name and price display.
            lblPizza.Text = "";
        }

        private void pichawiian_click(object sender, EventArgs e)
        {
            //code to add the pizza name and price to the list box and variable
            lstOrder.Items.Add("Hawaiian £8.99");
            dPrice = 8.99;

            dSubTotal = dSubTotal + dPrice;
        }

        private void picFourCheese_Click(object sender, EventArgs e)
        {
            //code to add the pizza name and price to the list box
            lstOrder.Items.Add("Four Cheese £7.99");
            dPrice = 7.99;


            dSubTotal = dSubTotal + dPrice;
        }

        private void picVeg_click(object sender, EventArgs e)
        {
            //code to add the pizza name and price to the list box
            lstOrder.Items.Add("Vegetarian £6.49");
            dPrice = 6.49;


            dSubTotal = dSubTotal + dPrice;
        }

        private void picMeatFeast_Click(object sender, EventArgs e)
        {
            //code to add the pizza name and price to the list box
            lstOrder.Items.Add("Meat Feast £8.99");
            dPrice = 8.99;


            dSubTotal = dSubTotal + dPrice;
        }

        private void picPepperoni_Click(object sender, EventArgs e)
        {
            //code to add the pizza name and price to the list box
            lstOrder.Items.Add("Pepperoni £6.99");
            dPrice = 6.99;


            dSubTotal = dSubTotal + dPrice;
        }


        private void picMargareta_Click(object sender, EventArgs e)
        {
            //code to add the pizza name and price to the list box
            lstOrder.Items.Add("Margareta £6.49");
            dPrice = 6.49;


            dSubTotal = dSubTotal + dPrice;
        }


        private void picFourcheese_MouseHover(object sender, EventArgs e)
        {
            //Code to display price of pizza
            lblPizza.Text = "Four Cheese £7.99";

        }

        private void picVeg_MouseLeave(object sender, EventArgs e)
        {
            //Code to display price of pizza
            lblPizza.Text = "Vegetarian £6.49";

        }

        private void picMeatFeast_MouseLeave(object sender, EventArgs e)
        {
            //Code to display price of pizza
            lblPizza.Text = "Meat Feast £8.99";

        }


        private void picPepperoni_MouseHover(object sender, EventArgs e)
        {
            //Code to display price of pizza
            lblPizza.Text = "Pepperoni £6.99";

        }

        private void picMargareta_MouseHover(object sender, EventArgs e)
        {
            //Code to display price of pizza
            lblPizza.Text = "Margareta £6.49";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //code to reset the order form

            lblDiscountD.Text = "";

            chkRegular.Checked = true;
            lblSubtotalD.Text = "";
            lblTotalD.Text = "";

            dSubTotal = 0;
            dTotal = 0;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //code to calculate the total and discount if the total is >£20 or customer is regular
            lblSubtotalD.Text = dSubTotal.ToString("#0.00");

            if (dSubTotal >= 20.0 || chkRegular.Checked == true)
            {
                dDiscount = dSubTotal / 100 * 50;
                dTotal = Convert.ToInt32(dSubTotal - dDiscount);


            }
            else
            {
                dDiscount = 0;
            }

            dTotal = Convert.ToInt32(dSubTotal - dDiscount);
            lblDiscountD.Text = dDiscount.ToString("#0.00");
            lblTotalD.Text = dTotal.ToString("#0.00");


        }

        private void btnUndo_click(object sender, EventArgs e)
        {
            //code to remove the last item from the list
            lstOrder.Items.RemoveAt(lstOrder.Items.Count - 1);
            dSubTotal = dSubTotal - dPrice;
            lblDiscountD.Text = "";
            lblSubtotalD.Text = "";
            lblTotalD.Text = "";
            btnUndo.Enabled = false;

        }

        private void Invoice()
        {
            //local variable to store result
            DialogResult dr;
            //accept response 
            dr = MessageBox.Show("Are you sure you want to Proceed?",
                "Confirm Order",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if yes close program
            if (dr == DialogResult.No)
            {
                //Find frmInvoice
                frmInvoice sw = new frmInvoice();

                //hide frmpizza
                this.Hide();

                //show frminvoice
                sw.show();
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Invoice();
        }

        private void pichawiian_MouseHover_1(object sender, EventArgs e)
        {
            //code to display price of pizza
            lblPizza.Text = "Hawaiian £8.99";

        }









    }


}
