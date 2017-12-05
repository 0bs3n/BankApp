namespace BankApp
{
    partial class Deposit
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
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.btnConfirmDeposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(165, 153);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDepositAmount.TabIndex = 0;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(45, 156);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(84, 13);
            this.lblDepositAmount.TabIndex = 1;
            this.lblDepositAmount.Text = "Deposit amount:";
            // 
            // btnConfirmDeposit
            // 
            this.btnConfirmDeposit.Location = new System.Drawing.Point(180, 240);
            this.btnConfirmDeposit.Name = "btnConfirmDeposit";
            this.btnConfirmDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmDeposit.TabIndex = 2;
            this.btnConfirmDeposit.Text = "Confirm";
            this.btnConfirmDeposit.UseVisualStyleBackColor = true;
            this.btnConfirmDeposit.Click += new System.EventHandler(this.btnConfirmDeposit_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 385);
            this.Controls.Add(this.btnConfirmDeposit);
            this.Controls.Add(this.lblDepositAmount);
            this.Controls.Add(this.txtDepositAmount);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Button btnConfirmDeposit;
    }
}
