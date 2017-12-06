namespace BankApp
{
    partial class Main
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
            this.lblBal = new System.Windows.Forms.Label();
            this.btnAccountSum = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Location = new System.Drawing.Point(47, 108);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(49, 13);
            this.lblBal.TabIndex = 0;
            this.lblBal.Text = "Balance:";
            // 
            // btnAccountSum
            // 
            this.btnAccountSum.Location = new System.Drawing.Point(300, 20);
            this.btnAccountSum.Name = "btnAccountSum";
            this.btnAccountSum.Size = new System.Drawing.Size(75, 39);
            this.btnAccountSum.TabIndex = 2;
            this.btnAccountSum.Text = "Account Summary";
            this.btnAccountSum.UseVisualStyleBackColor = true;
            this.btnAccountSum.Click += new System.EventHandler(this.btnAccountSum_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(300, 70);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 39);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdrawl";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(300, 120);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 39);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(117, 108);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 301);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnAccountSum);
            this.Controls.Add(this.lblBal);
            this.Name = "Main";
            this.Text = "Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Button btnAccountSum;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblBalance;
    }
}
