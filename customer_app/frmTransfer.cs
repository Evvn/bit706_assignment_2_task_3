using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace customer_app
{
    public partial class frmTransfer : Form, IObserver
    {
        Controller control;
        Customer cust;

        public frmTransfer(Controller c, Customer customer)
        {
            InitializeComponent();

            control = c;
            cust = customer;

            GetCustomerInfo();
        }

        private void GetCustomerInfo()
        {
            lblSelectedCustomer.Text = lblSelectedCustomer.Text + cust.FirstName + " " + cust.LastName;

            foreach (Account a in cust.Accounts)
            {
                comboFromAccount.Items.Add(a);
                comboToAccount.Items.Add(a);
            }
        }

        private void btnMakeTransfer_Click(object sender, EventArgs e)
        {
            // confirm accounts are selected, if not display error
            if (comboFromAccount.SelectedIndex == -1 || comboToAccount.SelectedIndex == -1)
            {

                lblError.Text = "Please select a to and from account";
                return;
            }

            // check accounts are different
            if (comboFromAccount.SelectedItem == comboToAccount.SelectedItem)
            {
                lblError.Text = "Please select two different accounts";
                return;
            }

            if (numAmount.Value <= 0)
            {
                lblError.Text = "Please select a transfer amount > 0.";
                return;
            }

            // get selected accs
            Account fromAcc = cust.Accounts[comboFromAccount.SelectedIndex];
            Account toAcc = cust.Accounts[comboToAccount.SelectedIndex];

            // call transfer func and set output if failed
            string transferOutput = control.MakeTransfer(fromAcc, toAcc, numAmount.Value);
            lblError.Text = transferOutput;

            UpdateBalances();
        }

        private void UpdateBalances()
        {
            if (comboFromAccount.SelectedIndex == -1)
            {
                // if no from account selected
                lblFromBalance.Text = "Balance: ";
            } else
            {
                string fromBalance = cust.Accounts[comboFromAccount.SelectedIndex].Balance.ToString();
                lblFromBalance.Text = "Balance: $" + fromBalance;
            }

            if (comboToAccount.SelectedIndex == -1)
            {
                // if no to account selected
                lblToBalance.Text = "Balance: ";
            } else
            {
                string toBalance = cust.Accounts[comboToAccount.SelectedIndex].Balance.ToString();
                lblToBalance.Text = "Balance: $" + toBalance;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // cancel click
            this.Close();
        }

        private void comboFromAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBalances();
        }

        private void comboToAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBalances();
        }
    }
}
