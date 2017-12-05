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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isValid(string username, string password)
        {
            var bkObject = new Banking();
            IQueryable<Customers> data;
            data = (from Customer in bkObject.Customers
                    where (Customer.UserName == username)
                    select Customer);
            if (data.ToArray().Length == 0)
            {
                lblResponse.Text = "Account does not exist!";
                return false;
            } 

            return (data.Single().Password == password);

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (!isValid(txtUserName.Text, txtPass.Text))
                lblResponse.Text = "Account does not exist!";
            else
            {
                var be = new Banking();
                var data = (from customer in be.Customers
                       join account in be.Accounts
                       on customer.AccountNo equals account.AccountNo
                       where customer.UserName == txtUserName.Text
                       select customer).Single();

                var data1 = (from customer in be.Customers
                            join account in be.Accounts
                            on customer.AccountNo equals account.AccountNo
                            where customer.UserName == txtUserName.Text
                            select account).Single();

                var main = new Main((double)data1.Balance, data.CustomerID, data.AccountNo);
                main.ShowDialog();
            }

        }
    }
}
