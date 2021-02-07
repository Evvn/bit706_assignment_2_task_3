using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace customer_app
{
    public partial class frmAddAccount : Form, IObserver
    {
        public Controller control;
        public Customer customer;
        public List<string> accountTypes = new List<string>{"everyday", "investment", "omni"};

        public frmAddAccount(Controller c, Customer cust)
        {
            InitializeComponent();

            control = c;
            customer = cust;

            lblCustomerName.Text = "Customer: " + customer.ToString();

            ListAccountTypes();
            CheckForOmni();
        }

        public void ListAccountTypes()
        {
            foreach (string s in accountTypes)
            {
                comboAccountType.Items.Add(s);
            }
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            // on close click
            this.Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // make sure account type is selected
            if (comboAccountType.SelectedIndex == -1)
            {
                lblErrorSelectAccount.Text = "Select an account type to create";
                return;
            }

            string accountType = accountTypes[comboAccountType.SelectedIndex];
            decimal openingBalance = numOpeningBalance.Value;
            decimal overdraftLimit = numOverdraftLimit.Value;

            control.CreateAccount(customer, accountType, openingBalance, overdraftLimit);

            // on create, close
            this.Close();
        }

        private void comboAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // hide error message
            lblErrorSelectAccount.Text = "";
            CheckForOmni();
        }

        private void CheckForOmni()
        {
            // if combobox is empty
            if (comboAccountType.SelectedIndex == -1)
            {
                // hide overdraft limit settings and set to 0
                lblOverdraftLimit.Hide();
                numOverdraftLimit.Hide();
                numOverdraftLimit.Value = 0;
                return;
            }

            // if not empty, check type
            if (accountTypes[comboAccountType.SelectedIndex] == "omni")
            {
                // show overdraft options if omni acc selected
                lblOverdraftLimit.Show();
                numOverdraftLimit.Show();
            }
            else
            {
                // hide overdraft limit settings
                lblOverdraftLimit.Hide();
                numOverdraftLimit.Hide();
                numOverdraftLimit.Value = 0;
            }
        }
    }
}
