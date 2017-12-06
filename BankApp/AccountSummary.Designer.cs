using System.Drawing;
namespace BankApp
{
    partial class AccountSummary
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
        /// the contents of method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGreeting = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            SuspendLayout();
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Location = new Point(53, 29);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(0, 13);
            lblGreeting.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = 
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(640, 480);
            dataGridView1.TabIndex = 3;
            dataGridView1.ForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            // 
            // AccountSummary
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(740, 630);
            Controls.Add(dataGridView1);
            Controls.Add(lblGreeting);
            Name = "AccountSummary";
            Text = "AccountSummary";
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
