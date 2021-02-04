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

            InitializeComponent();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            // launch customer management form
            frmCustomerManagement CustMgmt = new frmCustomerManagement(control);
            control.AttachObserver(CustMgmt);
            CustMgmt.Show();
        }
    }
}
