using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace customer_app
{
    public partial class frmEditCustomer : Form, IObserver
    {
        public Controller control;
        public Customer editedCust;
        public frmEditCustomer(Controller c, Customer cust)
        {
            InitializeComponent();
            control = c;
            editedCust = cust;
            // pre-populate fields
            txtFirstName.Text = cust.FirstName;
            txtLastName.Text = cust.LastName;
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            // on update click
            control.EditCustomer(editedCust.ID, txtFirstName.Text, txtLastName.Text);
            this.Close();

        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            // on close click
            this.Close();
        }
    }
}
