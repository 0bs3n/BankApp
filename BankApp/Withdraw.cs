using System;
using System.Linq;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Withdraw : Form
    {
        public Form ParentWindow;
        public int Customer_Id;
        public int Account_No;
        public Withdraw(int customer_id, int account_no)
        {
            InitializeComponent();
            this.Customer_Id = customer_id;
            this.Account_No = account_no;
        }

        private void btnWithdrawConfirm_Click(object sender, EventArgs e)
        {
            decimal wa;
            if (!decimal.TryParse(txtWithdrawAmount.Text, out wa))
                lblWithdrawAmount.Text = "Please enter a number!";
            else
            {
                var be = new Banking();
                var data = (from account in be.Accounts
                            where account.AccountNo == Account_No
                            select account).Single();
                decimal new_bal = data.Balance - wa;
                if (new_bal < 0)
                {
                    lblWithdrawAmount.Text = "Not enough Funds!";
                }
                else
                {
                    data.Balance = new_bal;
                    var withdrawal = 
                        new Transactions("w", data.AccountNo, wa, DateTime.Now);
                    be.Transactions.InsertOnSubmit(withdrawal);
                    be.SubmitChanges();
                    Close();
                }


            }

        }
    }
}
