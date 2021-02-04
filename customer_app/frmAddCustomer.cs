using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace customer_app
{
    public partial class frmAddCustomer : Form, IObserver
    {
        public Controller control;
        public frmAddCustomer(Controller c)
        {
            InitializeComponent();
            control = c;
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            // on cancel click
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            bool isBankStaff = checkIsBankStaff.Checked;
            // on add click
            control.CreateCustomer(fName, lName, isBankStaff);
            this.Close();
        }
    }
}
