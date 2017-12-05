using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Main : Form
    {
        public int Customer_Id;
        public int Account_No;

        public Main(double balance, int customer_id, int account_no)
        {
            this.InitializeComponent();
            lblBalance.Text = "$" + balance.ToString();
            this.Customer_Id = customer_id;
            this.Account_No = account_no;
        }

        private double GetBalance()
        {
            var dbContext = new Banking();
            var data = (from account in dbContext.Accounts
                        join customer in dbContext.Customers
                        on account.AccountNo equals customer.AccountNo
                        where account.AccountNo == this.Account_No
                        select account).Single();

            return (double)data.Balance;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var w = new Withdraw(this.Customer_Id, this.Account_No);
            w.ShowDialog();
            lblBalance.Text = "$" + GetBalance().ToString();
            
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit d = new Deposit(this.Customer_Id, this.Account_No);
            d.ShowDialog();
            lblBalance.Text = "$" + GetBalance().ToString();
        }

        private void btnAccountSum_Click(object sender, EventArgs e)
        {
            AccountSummary a = new AccountSummary(this.Customer_Id, GetBalance());
            a.ShowDialog();
        }
    }
}
