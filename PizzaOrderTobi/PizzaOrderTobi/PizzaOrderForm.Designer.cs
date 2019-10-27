namespace PizzaOrderTobi
{
    partial class frmPizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.lblExtraLarge = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblToppings = new System.Windows.Forms.Label();
            this.nudToppings = new System.Windows.Forms.NumericUpDown();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblHST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotalAnswer = new System.Windows.Forms.Label();
            this.lblHstAnswer = new System.Windows.Forms.Label();
            this.lblTotalAnswer = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mnuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuFile.Size = new System.Drawing.Size(837, 28);
            this.mnuFile.TabIndex = 0;
            this.mnuFile.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(46, 24);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(116, 26);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(16, 70);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(517, 31);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Select the size of pizza you would like:";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarge.Location = new System.Drawing.Point(105, 151);
            this.lblLarge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(217, 31);
            this.lblLarge.TabIndex = 2;
            this.lblLarge.Text = "Large Pizza = 1";
            // 
            // lblExtraLarge
            // 
            this.lblExtraLarge.AutoSize = true;
            this.lblExtraLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraLarge.Location = new System.Drawing.Point(105, 217);
            this.lblExtraLarge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtraLarge.Name = "lblExtraLarge";
            this.lblExtraLarge.Size = new System.Drawing.Size(293, 31);
            this.lblExtraLarge.TabIndex = 3;
            this.lblExtraLarge.Text = "Extra Large Pizza = 2";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(541, 79);
            this.nudSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudSize.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(45, 22);
            this.nudSize.TabIndex = 4;
            this.nudSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(16, 289);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(555, 31);
            this.lblToppings.TabIndex = 5;
            this.lblToppings.Text = "Select how many toppings you would like:";
            // 
            // nudToppings
            // 
            this.nudToppings.Location = new System.Drawing.Point(568, 227);
            this.nudToppings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudToppings.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudToppings.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudToppings.Name = "nudToppings";
            this.nudToppings.Size = new System.Drawing.Size(41, 22);
            this.nudToppings.TabIndex = 6;
            this.nudToppings.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(16, 395);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(147, 31);
            this.lblSubTotal.TabIndex = 7;
            this.lblSubTotal.Text = "Subtotal =";
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHST.Location = new System.Drawing.Point(16, 450);
            this.lblHST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(97, 31);
            this.lblHST.TabIndex = 8;
            this.lblHST.Text = "HST =";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(16, 513);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 31);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total =";
            // 
            // lblSubtotalAnswer
            // 
            this.lblSubtotalAnswer.AutoSize = true;
            this.lblSubtotalAnswer.Location = new System.Drawing.Point(241, 395);
            this.lblSubtotalAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotalAnswer.Name = "lblSubtotalAnswer";
            this.lblSubtotalAnswer.Size = new System.Drawing.Size(46, 17);
            this.lblSubtotalAnswer.TabIndex = 10;
            this.lblSubtotalAnswer.Text = "label1";
            // 
            // lblHstAnswer
            // 
            this.lblHstAnswer.AutoSize = true;
            this.lblHstAnswer.Location = new System.Drawing.Point(241, 450);
            this.lblHstAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHstAnswer.Name = "lblHstAnswer";
            this.lblHstAnswer.Size = new System.Drawing.Size(46, 17);
            this.lblHstAnswer.TabIndex = 11;
            this.lblHstAnswer.Text = "label2";
            // 
            // lblTotalAnswer
            // 
            this.lblTotalAnswer.AutoSize = true;
            this.lblTotalAnswer.Location = new System.Drawing.Point(241, 513);
            this.lblTotalAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAnswer.Name = "lblTotalAnswer";
            this.lblTotalAnswer.Size = new System.Drawing.Size(46, 17);
            this.lblTotalAnswer.TabIndex = 12;
            this.lblTotalAnswer.Text = "label3";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(457, 438);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 28);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "$9.99";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "$12.99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "1 Topping \t$0.75";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "2 Toppings \t$1.35";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "3 Toppings \t$2.15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(605, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "4 Toppings \t$2.75";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 700);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalAnswer);
            this.Controls.Add(this.lblHstAnswer);
            this.Controls.Add(this.lblSubtotalAnswer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHST);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.nudToppings);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.lblExtraLarge);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order Tobi";
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.Label lblExtraLarge;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.NumericUpDown nudToppings;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblHST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotalAnswer;
        private System.Windows.Forms.Label lblHstAnswer;
        private System.Windows.Forms.Label lblTotalAnswer;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

