using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace customer_app
{
    public partial class frmManageAccounts : Form, IObserver
    {
        public Controller control;

        public frmManageAccounts(Controller c)
        {
            InitializeComponent();

            control = c;

            ListCustomers();
        }

        public void ListCustomers()
        {
            // add existing customers to combo box
            // clear combobox first to reset on update
            comboCustomers.Items.Clear();
            // also reset current balance reading
            lblCurrentBalance.Text = "Current balance: ";

            foreach (Customer c in control.AllCustomers)
            {
                comboCustomers.Items.Add(c);
            }
        }

        private void comboCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when customer is selected, print all customers accounts to combo box
            // clear combobox first to reset on update
            comboAccounts.Items.Clear();
            // also reset current balance reading
            lblCurrentBalance.Text = "Current balance: ";

            // clear selected value too
            comboAccounts.ResetText();

            foreach (Account a in control.AllCustomers[comboCustomers.SelectedIndex].Accounts)
            {
                comboAccounts.Items.Add(a);
            }

        }

        private void comboAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when account is selected, print current account balance
            Customer selectedCust = control.AllCustomers[comboCustomers.SelectedIndex];
            Account selectedAcc = selectedCust.Accounts[comboAccounts.SelectedIndex];
            string accountBalance = selectedAcc.Balance.ToString();
            lblCurrentBalance.Text = "Current balance: $" + accountBalance;
        }

        private void btnAddInterest_Click(object sender, EventArgs e)
        {
            // confirm account is selected, if not display error
            if (comboCustomers.SelectedIndex == -1 || comboAccounts.SelectedIndex == -1)
            {
                lblCurrentBalance.Text = "Invalid selection, please pick a customer and account";
                return;
            }

            // get selected acc
            Customer selectedCust = control.AllCustomers[comboCustomers.SelectedIndex];
            Account selectedAcc = selectedCust.Accounts[comboAccounts.SelectedIndex];

            // call interest func and set output
            string interestOutput = selectedAcc.GetInterest();
            lblCurrentBalance.Text = interestOutput;
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            // add new account button click
            // if no cust selected, return error
            if (comboCustomers.SelectedIndex == -1)
            {
                lblCurrentBalance.Text = "You must first select a customer to create an account for";
                return;
            }

            Customer selectedCust = control.AllCustomers[comboCustomers.SelectedIndex];
            // launch form here
            frmAddAccount AddAcc = new frmAddAccount(control, selectedCust);
            control.AttachObserver(AddAcc);
            AddAcc.Show();
        }

        private void btnMakeDeposit_Click(object sender, EventArgs e)
        {
            // check that cust and acc are selected
            if (comboCustomers.SelectedIndex == -1 || comboAccounts.SelectedIndex == -1)
            {
                lblCurrentBalance.Text = "Invalid selection, please pick a customer and account";
                return;
            }

            // get selected acc
            Customer selectedCust = control.AllCustomers[comboCustomers.SelectedIndex];
            Account selectedAcc = selectedCust.Accounts[comboAccounts.SelectedIndex];

            if (numAmount.Value <= 0)
            {
                lblCurrentBalance.Text = "Please deposit a positive amount > 0.";
            } else
            {
                control.MakeDeposit(selectedAcc, numAmount.Value);
                lblCurrentBalance.Text = "Current balance: $" + selectedAcc.Balance.ToString();
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // check that cust and acc are selected
            if (comboCustomers.SelectedIndex == -1 || comboAccounts.SelectedIndex == -1)
            {
                lblCurrentBalance.Text = "Invalid selection, please pick a customer and account";
                return;
            }

            // get selected acc
            Customer selectedCust = control.AllCustomers[comboCustomers.SelectedIndex];
            Account selectedAcc = selectedCust.Accounts[comboAccounts.SelectedIndex];

            if (numAmount.Value <= 0)
            {
                lblCurrentBalance.Text = "Please withdraw a positive amount > 0.";
            }
            else
            {
                
                try
                {
                    control.MakeWithdrawal(selectedAcc, numAmount.Value);
                    // if get to here, no exception
                    lblCurrentBalance.Text = "Current balance: $" + selectedAcc.Balance.ToString();
                } catch (Exception exc)
                {
                    lblCurrentBalance.Text = exc.Message;
                }
            }
        }

        private void btnMakeTransfer_Click(object sender, EventArgs e)
        {
            // add new account button click
            // if no cust selected, return error
            if (comboCustomers.SelectedIndex == -1)
            {
                lblCurrentBalance.Text = "You must first select a customer to make a transfer for.";
                return;
            }

            Customer selectedCust = control.AllCustomers[comboCustomers.SelectedIndex];
            // launch form here
            frmTransfer MakeTransfer = new frmTransfer(control, selectedCust);
            control.AttachObserver(MakeTransfer);
            MakeTransfer.Show();
        }
    }
}
