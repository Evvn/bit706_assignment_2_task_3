using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customer_app
{
    public partial class CustomerApp : Form
    {
        public Controller control = new Controller();
        public CustomerApp()
        {
            // add test customerss
            control.CreateCustomer("Michael", "Scott", true);
            control.CreateCustomer("Pam", "Beesly", false);
            control.CreateCustomer("Dwight", "Shrute", false);

            // add test accounts to each test customer with varying balances
            // and 200 overdraft for omni (interest and fail fees are fixed)
            control.CreateAccount(control.AllCustomers[0], "everyday", 100, 0);
            control.CreateAccount(control.AllCustomers[0], "investment", 200, 0);
            control.CreateAccount(control.AllCustomers[0], "omni", 300, 200);

            control.CreateAccount(control.AllCustomers[1], "everyday", 400, 0);
            control.CreateAccount(control.AllCustomers[1], "investment", 500, 0);
            control.CreateAccount(control.AllCustomers[1], "omni", 600, 200);

            control.CreateAccount(control.AllCustomers[2], "everyday", 700, 0);
            control.CreateAccount(control.AllCustomers[2], "investment", 800, 0);
            control.CreateAccount(control.AllCustomers[2], "omni", 900, 200);

            InitializeComponent();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            // launch customer management form
            frmCustomerManagement CustMgmt = new frmCustomerManagement(control);
            control.AttachObserver(CustMgmt);
            CustMgmt.Show();
        }

        private void btnManageCustomerAccounts_Click(object sender, EventArgs e)
        {
            // launch account management form
            frmManageAccounts AccMgmt = new frmManageAccounts(control);
            control.AttachObserver(AccMgmt);
            AccMgmt.Show();
        }
    }
}
