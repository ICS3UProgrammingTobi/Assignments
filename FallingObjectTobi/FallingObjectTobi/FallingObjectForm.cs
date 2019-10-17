/*
 * Created by: Tobi Adebayo
 * Created on: 16-10-2019
 * Created for: ICS3U Programming
 * Assignment #2 - Falling object
 * This program allows me to determine the height of a faling object 
 * after it has been dropped
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

namespace FallingObjectTobi
{
    public partial class frmFallingObject : Form
    {
        public frmFallingObject()
        {
            InitializeComponent();
            //hide the answer label
            this.lblAnswer.Hide();
            this.lblHeightOfObject.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmFallingObject_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //show the label's when the calculate button is clcked
            this.lblHeightOfObject.Show();
            this.lblAnswer.Show();

            //Declare local variable
            double second;
            double gravity;

            //convert from string to a double
            second = double.Parse(txtTime.Text);
            gravity=100 - (0.5 * 9.81 * Math.Pow(second, 2));

            this.lblAnswer.Text = Convert.ToString(gravity) + " meters";









        }
    }
}
