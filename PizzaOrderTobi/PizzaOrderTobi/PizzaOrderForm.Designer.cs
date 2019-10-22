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
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(628, 24);
            this.mnuFile.TabIndex = 0;
            this.mnuFile.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(93, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(12, 57);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(422, 25);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Select the size of pizza you would like:";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarge.Location = new System.Drawing.Point(79, 123);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(177, 25);
            this.lblLarge.TabIndex = 2;
            this.lblLarge.Text = "Large Pizza = 1";
            // 
            // lblExtraLarge
            // 
            this.lblExtraLarge.AutoSize = true;
            this.lblExtraLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraLarge.Location = new System.Drawing.Point(79, 176);
            this.lblExtraLarge.Name = "lblExtraLarge";
            this.lblExtraLarge.Size = new System.Drawing.Size(239, 25);
            this.lblExtraLarge.TabIndex = 3;
            this.lblExtraLarge.Text = "Extra Large Pizza = 2";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(466, 62);
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
            this.nudSize.Size = new System.Drawing.Size(34, 20);
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
            this.lblToppings.Location = new System.Drawing.Point(12, 235);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(451, 25);
            this.lblToppings.TabIndex = 5;
            this.lblToppings.Text = "Select how many toppings you would like:";
            // 
            // nudToppings
            // 
            this.nudToppings.Location = new System.Drawing.Point(469, 235);
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
            this.nudToppings.Size = new System.Drawing.Size(31, 20);
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
            this.lblSubTotal.Location = new System.Drawing.Point(12, 321);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(119, 25);
            this.lblSubTotal.TabIndex = 7;
            this.lblSubTotal.Text = "Subtotal =";
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHST.Location = new System.Drawing.Point(12, 366);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(77, 25);
            this.lblHST.TabIndex = 8;
            this.lblHST.Text = "HST =";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 417);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 25);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total =";
            // 
            // lblSubtotalAnswer
            // 
            this.lblSubtotalAnswer.AutoSize = true;
            this.lblSubtotalAnswer.Location = new System.Drawing.Point(181, 321);
            this.lblSubtotalAnswer.Name = "lblSubtotalAnswer";
            this.lblSubtotalAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblSubtotalAnswer.TabIndex = 10;
            this.lblSubtotalAnswer.Text = "label1";
            // 
            // lblHstAnswer
            // 
            this.lblHstAnswer.AutoSize = true;
            this.lblHstAnswer.Location = new System.Drawing.Point(181, 366);
            this.lblHstAnswer.Name = "lblHstAnswer";
            this.lblHstAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblHstAnswer.TabIndex = 11;
            this.lblHstAnswer.Text = "label2";
            // 
            // lblTotalAnswer
            // 
            this.lblTotalAnswer.AutoSize = true;
            this.lblTotalAnswer.Location = new System.Drawing.Point(181, 417);
            this.lblTotalAnswer.Name = "lblTotalAnswer";
            this.lblTotalAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblTotalAnswer.TabIndex = 12;
            this.lblTotalAnswer.Text = "label3";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(343, 356);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(81, 23);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "$9.99";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "$12.99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "1 Topping \t$0.75";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "2 Toppings \t$1.35";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(298, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "3 Toppings \t$2.15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "4 Toppings \t$2.75";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 569);
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

