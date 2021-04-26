namespace InterestCalculator
{
    partial class frmInterestCalculator
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
            this.lblEnterAmount = new System.Windows.Forms.Label();
            this.txtEnterAmount = new System.Windows.Forms.TextBox();
            this.btnCalculateInterest = new System.Windows.Forms.Button();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterAmount
            // 
            this.lblEnterAmount.AutoSize = true;
            this.lblEnterAmount.Location = new System.Drawing.Point(28, 53);
            this.lblEnterAmount.Name = "lblEnterAmount";
            this.lblEnterAmount.Size = new System.Drawing.Size(71, 13);
            this.lblEnterAmount.TabIndex = 0;
            this.lblEnterAmount.Text = "Enter Amount";
            // 
            // txtEnterAmount
            // 
            this.txtEnterAmount.Location = new System.Drawing.Point(126, 46);
            this.txtEnterAmount.Name = "txtEnterAmount";
            this.txtEnterAmount.Size = new System.Drawing.Size(141, 20);
            this.txtEnterAmount.TabIndex = 1;
            // 
            // btnCalculateInterest
            // 
            this.btnCalculateInterest.Location = new System.Drawing.Point(316, 44);
            this.btnCalculateInterest.Name = "btnCalculateInterest";
            this.btnCalculateInterest.Size = new System.Drawing.Size(173, 54);
            this.btnCalculateInterest.TabIndex = 2;
            this.btnCalculateInterest.Text = "Calculate Interest";
            this.btnCalculateInterest.UseVisualStyleBackColor = true;
            this.btnCalculateInterest.Click += new System.EventHandler(this.btnCalculateInterest_Click);
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInterest.Location = new System.Drawing.Point(28, 133);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(0, 19);
            this.lblTotalInterest.TabIndex = 3;
            // 
            // frmInterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 261);
            this.Controls.Add(this.lblTotalInterest);
            this.Controls.Add(this.btnCalculateInterest);
            this.Controls.Add(this.txtEnterAmount);
            this.Controls.Add(this.lblEnterAmount);
            this.Name = "frmInterestCalculator";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblEnterAmount;
        internal System.Windows.Forms.TextBox txtEnterAmount;
        internal System.Windows.Forms.Button btnCalculateInterest;
        internal System.Windows.Forms.Label lblTotalInterest;
    }
}

