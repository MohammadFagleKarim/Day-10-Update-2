using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD_Coffee_Shop_With_DB.Model;
using BD_Coffee_Shop_With_DB.BLL;

namespace BD_Coffee_Shop_With_DB
{
    public partial class CustomerUi : Form
    {
        public string Id;

        CustomersManager _CustomersManager = new CustomersManager();

        public CustomerUi()
        {
            InitializeComponent();
        }

        private void customerAddBtn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();

            customers.CustomerName = customerNameTextBox.Text;

            //Set Name as Mandatory
            if (String.IsNullOrEmpty(customerNameTextBox.Text))
            {
                MessageBox.Show("Name can not be Empty!!!");
                return;
            }
            //Set Address as Mandatory
            if (String.IsNullOrEmpty(customerAddressTextBox.Text))
            {
                MessageBox.Show("Address can not be Empty!!!");
                return;
            }
            //Set Contact as Mandatory
            if (String.IsNullOrEmpty(customerContactTextBox.Text))
            {
                MessageBox.Show("Contact can not be Empty!!!");
                return;
            }

            //Check UNIQUE
            if (_CustomersManager.IsCustomerNameExist(customers))
            {
                MessageBox.Show(customerNameTextBox.Text + " Already Exists!");
                return;
            }

            customers.Address = customerAddressTextBox.Text;
            customers.Contact = customerContactTextBox.Text;

            bool isAdded = _CustomersManager.CustomersAdd(customers);

            if (isAdded)
            {
                MessageBox.Show("Saved");
                customerDataGridView.DataSource = _CustomersManager.Display();
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            customerNameTextBox.Text = "";
            customerContactTextBox.Text = "";
            customerAddressTextBox.Text = "";
        }

        private void customerDeleteBtn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();

            customers.CustomerName = customerNameTextBox.Text;
            customers.Address = customerAddressTextBox.Text;
            customers.Contact = customerContactTextBox.Text;
            customers.CustomerId = Convert.ToInt32(Id);


            ////Set ID as Mandatory

            //if (String.IsNullOrEmpty(idTextBox.Text))
            //{
            //    MessageBox.Show("ID Can not be Empty!!!");
            //    return;
            //}


            bool isDeleted = _CustomersManager.CustomersDelete(customers);

            if (isDeleted)
            {
                MessageBox.Show("Deleted");
                customerDataGridView.DataSource = _CustomersManager.Display();
            }
            else
            {
                MessageBox.Show(" Not Deleted");
            }

            customerNameTextBox.Text = "";
            customerContactTextBox.Text = "";
            customerAddressTextBox.Text = "";
        }

        private void customerUpdateBtn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();

            customers.CustomerName = customerNameTextBox.Text;
            customers.Contact = customerContactTextBox.Text;
            customers.Address = customerAddressTextBox.Text;
            customers.CustomerId = Convert.ToInt32(Id);

            ////Set ID as Mandatory

            //if (String.IsNullOrEmpty(idTextBox.Text))
            //{
            //    MessageBox.Show("ID Can not be Empty!!!");
            //    return;
            //}

            bool isUpdated = _CustomersManager.CustomersUpdate(customers);

            if (isUpdated)
            {
                MessageBox.Show("Updated");
                customerDataGridView.DataSource = _CustomersManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }

            customerNameTextBox.Text = "";
            customerContactTextBox.Text = "";
            customerAddressTextBox.Text = "";
        }

        private void customerSearchBtn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();

            customers.CustomerName = customerNameTextBox.Text;
            
            //Set Name as Mandatory

            if (String.IsNullOrEmpty(customerNameTextBox.Text))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }

            customerDataGridView.DataSource = _CustomersManager.Search(customers);

            customerNameTextBox.Text = "";
        }

        private void customerShowBtn_Click(object sender, EventArgs e)
        {
            customerDataGridView.DataSource = _CustomersManager.Display();
        }

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.customerDataGridView.Rows[e.RowIndex];
                Id = row.Cells[0].Value.ToString();
                customerNameTextBox.Text = row.Cells[1].Value.ToString();
                customerAddressTextBox.Text = row.Cells[2].Value.ToString();
                customerContactTextBox.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
