/*
   * Created by: Tobi adebayo
   * Created on: 20-10-2019
   * Created for: ICS3U Programming
   * Assignment – #2 - Falling object
   * This program calculates the height of and object after being dropped
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

namespace FallingObjectTobiV2
{
    public partial class FalingObjectForm : Form
    {
        public FalingObjectForm()
        {
            InitializeComponent();
            //hide the labels
            lblAnswer.Hide();
            lblHeight.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
            //Make and exit buton
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblHeight.Show();
            lblAnswer.Show();

            // declare local variables
            double time, answer;

            // Convert from string to double
            time = double.Parse(txtTime.Text);

            // Calculation for time
            answer = 100 - (0.5 * 9.81 * Math.Pow(time, 2));

            // Add the "M" at the end
            lblAnswer.Text = Convert.ToString(answer) + "m";

            //Put it already hit the ground after it has hit the ground
            if (time > Math.Sqrt((100/9.81)))
            {
                lblAnswer.Text = "It already hit the ground!";

            }

        }
    }
}
