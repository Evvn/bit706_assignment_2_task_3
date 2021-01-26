using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace customer_app
{
    public partial class frmCustomerManagement : Form, IObserver
    {
        public Controller control;

        public frmCustomerManagement(Controller c)
        {
            InitializeComponent();
            control = c;

            ListCustomers();
        }

        private void ListCustomers()
        {

            // clear list first to reset on update
            listCustomers.Items.Clear();

            foreach (Customer c in control.AllCustomers)
            {
                listCustomers.Items.Add(c);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            // get selected customer from list
            Customer selectedCustomer = (Customer)listCustomers.SelectedItem;
            // dispatch action to controller if not null
            if (selectedCustomer != null) 
            { 
                control.DeleteCustomer(selectedCustomer.ID);
            }
            
        }

        public new void Update()
        {
            ListCustomers();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // launch add customer form with observer
            frmAddCustomer AddCust = new frmAddCustomer(control);
            control.AttachObserver(AddCust);
            AddCust.Show();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            // launch edit customer form with observer and selected cust prop
            Customer selectedCust = (Customer)listCustomers.SelectedItem;
            frmEditCustomer EditCust = new frmEditCustomer(control, selectedCust);
            control.AttachObserver(EditCust);
            EditCust.Show();
        }
    }
}
