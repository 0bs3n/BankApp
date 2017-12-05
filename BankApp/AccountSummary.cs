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
    public partial class AccountSummary : Form
    {
        public Banking Context = new Banking();
        public Customers Customer;
        public int Customer_Id;
        public void getCustomer()
        {
            var customer = (from cust in this.Context.Customers
                            where cust.CustomerID == this.Customer_Id
                            select cust).Single();
            this.Customer = customer;
        }

        private string titleCase(string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
        
        public AccountSummary(int customer_id, double balance)
        {
            this.Customer_Id = customer_id;
            getCustomer();
            InitializeComponent();
            lblGreeting.Text = "Hello, " + titleCase(this.Customer.FirstName);

            var data = (from txns in this.Context.Transactions
                       join cust in this.Context.Customers
                       on txns.AccountNo equals cust.AccountNo
                       where cust.AccountNo == this.Customer_Id
                       select txns).ToList();

            dataGridView1.DataSource = data;
        }
    }
}
