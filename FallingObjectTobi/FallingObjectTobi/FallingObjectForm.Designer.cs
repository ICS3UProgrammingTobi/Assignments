namespace FallingObjectTobi
{
    partial class frmFallingObject
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtSecondes = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblHeightOfObject = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(248, 113);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 30);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtSecondes
            // 
            this.txtSecondes.Location = new System.Drawing.Point(521, 63);
            this.txtSecondes.Name = "txtSecondes";
            this.txtSecondes.Size = new System.Drawing.Size(100, 22);
            this.txtSecondes.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(2, 65);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(502, 20);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Enter the time (in secondes) since you released the object";
            // 
            // lblHeightOfObject
            // 
            this.lblHeightOfObject.AutoSize = true;
            this.lblHeightOfObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightOfObject.Location = new System.Drawing.Point(2, 186);
            this.lblHeightOfObject.Name = "lblHeightOfObject";
            this.lblHeightOfObject.Size = new System.Drawing.Size(385, 20);
            this.lblHeightOfObject.TabIndex = 4;
            this.lblHeightOfObject.Text = "The height of the object above the ground is:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(518, 186);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 17);
            this.lblAnswer.TabIndex = 5;
            // 
            // frmFallingObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 300);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblHeightOfObject);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtSecondes);
            this.Controls.Add(this.btnCalculate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFallingObject";
            this.Text = "Falling Object Tobi";
            this.Load += new System.EventHandler(this.frmFallingObject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtSecondes;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblHeightOfObject;
        private System.Windows.Forms.Label lblAnswer;
    }
}

