/*
 * Created by: Tobi Adebayo
 * Created on: 22-10-2019
 * Created for: ICS3U Programming
 * Assignment #3b - Pizza order
 * This program calculates the cost of a pizza with toppings
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

namespace PizzaOrderTobi
{
    public partial class frmPizzaOrder : Form
    {
        //// Declare constants and variables
        const double LARGE_PIZZA = 9.99;
        const double EXTRALARGE_PIZZA = 12.99;
        const double HST = 0.13;
        const double ONE_TOPPING = 0.75;
        const double TWO_TOPPINGS = 1.35;
        const double THREE_TOPPINGS = 2.15;
        const double FOUR_TOPPINGS = 2.75;

        public frmPizzaOrder()
        {
            InitializeComponent();
            //Hide the labels
            this.lblSubtotalAnswer.Hide();
            this.lblHstAnswer.Hide();
            this.lblTotalAnswer.Hide();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare the variables
            double size, toppings,subtotal, Tax, total;
            size =Convert.ToInt32(nudSize.Value);
            toppings = Convert.ToInt32(nudSize.Value);


            //show the label
            this.lblSubtotalAnswer.Show();
            this.lblHstAnswer.Show();
            this.lblTotalAnswer.Show();

            //User choice of pizza size
            if (nudSize.Value==1)
            {
                size = LARGE_PIZZA;
            }
            else if (nudSize.Value==2)
            {
                size = EXTRALARGE_PIZZA;
            }

            // User choice of toppings
            if (nudToppings.Value == 1)
            {
                toppings = ONE_TOPPING;
            }
            else if (nudToppings.Value == 2)
            {
                toppings = TWO_TOPPINGS;
            }
            else if (nudToppings.Value == 3)
            {
                toppings = THREE_TOPPINGS;
            }
            else if (nudToppings.Value==4)
            {
                toppings = FOUR_TOPPINGS;
            }

            // Calculate 
            subtotal = size + toppings;
            lblSubtotalAnswer.Text = String.Format("${0:0.00}", subtotal);
            //Calculate tax
            Tax = HST * subtotal;
            lblHstAnswer.Text = String.Format("${0:0.00}", Tax);
            // Calculate and display the final total
            total = Tax + subtotal;

            lblTotalAnswer.Text = String.Format("${0:0.00}", total);
        }
    }
}
