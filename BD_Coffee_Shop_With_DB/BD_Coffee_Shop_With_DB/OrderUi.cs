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
    public partial class OrderUi : Form
    {
        OrdersManager _OrdersManager = new OrdersManager();

        public OrderUi()
        {
            InitializeComponent();
        }

        private void orderSaveBtn_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();

            orders.Customer = orderCustomerComboBox.Text;
            orders.Item = orderItemComboBox.Text;

            //int price = Convert.ToInt16(itemComboBox.SelectedValue);

            //MessageBox.Show("" + price);
            orders.Quantity = Convert.ToInt32(orderQuantityTextBox.Text);
            orders.TotalPrice = Convert.ToDouble(orderTotalPriceTextBox.Text);

            orders.OrdersId = Convert.ToInt32(orderCustomerComboBox.SelectedValue);

            //Set Name as Mandatory
            //if (String.IsNullOrEmpty(customernameTextBox.Text))
            //{
            //    MessageBox.Show("Name Can not be Empty!!!");
            //    return;
            //}

            //Check UNIQUE
            //if (_OrdersManager.IsCustomerNameExist(orders))
            //{
            //    MessageBox.Show(orders + " Already Exists!");
            //    return;
            //}

            //Check UNIQUE
            //if (_orderManager.IsInameExist(itemnameTextBox.Text))
            //{
            //    MessageBox.Show(itemnameTextBox.Text + " Already Exists!");
            //    return;
            //}

            bool isAdded = _OrdersManager.OrdersAdd(orders);

            if (isAdded)
            {
                MessageBox.Show("Saved");
                orderDataGridView.DataSource = _OrdersManager.Display();
                //order.TotalPrice = Convert.ToDouble(totalpriceTextBox.Text) * price;
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            orderQuantityTextBox.Text = "";
            orderTotalPriceTextBox.Text = "";
        }

        private void OrderUi_Load(object sender, EventArgs e)
        {
            orderCustomerComboBox.DataSource = _OrdersManager.CustomerCombo();
            orderItemComboBox.DataSource = _OrdersManager.ItemCombo();
        }
    }
}
