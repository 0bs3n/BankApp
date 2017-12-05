namespace BankApp
{
    partial class Withdraw
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
            this.btnWithdrawConfirm = new System.Windows.Forms.Button();
            this.lblWithdrawAmount = new System.Windows.Forms.Label();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWithdrawConfirm
            // 
            this.btnWithdrawConfirm.Location = new System.Drawing.Point(153, 177);
            this.btnWithdrawConfirm.Name = "btnWithdrawConfirm";
            this.btnWithdrawConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawConfirm.TabIndex = 0;
            this.btnWithdrawConfirm.Text = "Confirm";
            this.btnWithdrawConfirm.UseVisualStyleBackColor = true;
            this.btnWithdrawConfirm.Click += new System.EventHandler(this.btnWithdrawConfirm_Click);
            // 
            // lblWithdrawAmount
            // 
            this.lblWithdrawAmount.AutoSize = true;
            this.lblWithdrawAmount.Location = new System.Drawing.Point(29, 106);
            this.lblWithdrawAmount.Name = "lblWithdrawAmount";
            this.lblWithdrawAmount.Size = new System.Drawing.Size(95, 13);
            this.lblWithdrawAmount.TabIndex = 1;
            this.lblWithdrawAmount.Text = "Withdrawl amount:";
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Location = new System.Drawing.Point(142, 103);
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(100, 20);
            this.txtWithdrawAmount.TabIndex = 2;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 352);
            this.Controls.Add(this.txtWithdrawAmount);
            this.Controls.Add(this.lblWithdrawAmount);
            this.Controls.Add(this.btnWithdrawConfirm);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdrawConfirm;
        private System.Windows.Forms.Label lblWithdrawAmount;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
    }
}
