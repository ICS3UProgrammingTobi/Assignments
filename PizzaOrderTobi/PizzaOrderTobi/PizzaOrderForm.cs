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


            //show the labels
            this.lblSubtotalAnswer.Show();
            this.lblHstAnswer.Show();
            this.lblTotalAnswer.Show();

        }
    }
}
