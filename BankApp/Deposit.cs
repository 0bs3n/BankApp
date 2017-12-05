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
    public partial class Deposit : Form
    {
        public int Customer_Id;
        public int Account_No;
        public Deposit(int customer_id, int account_no)
        {
            InitializeComponent();
            this.Customer_Id = customer_id;
            this.Account_No = account_no;
        }

        private void btnConfirmDeposit_Click(object sender, EventArgs e)
        {
            decimal da;
            if (!decimal.TryParse(txtDepositAmount.Text, out da))
                lblDepositAmount.Text = "Please enter a number!";
            else
            {
                var be = new Banking();
                var data = (from account in be.Accounts
                            where account.AccountNo == Account_No
                            select account).Single();

                data.Balance += da;
                var deposit = new Transactions("d", data.AccountNo, da, DateTime.Now);

                be.Transactions.InsertOnSubmit(deposit);
                be.SubmitChanges();
                Close();

            }

        }
    }
}
