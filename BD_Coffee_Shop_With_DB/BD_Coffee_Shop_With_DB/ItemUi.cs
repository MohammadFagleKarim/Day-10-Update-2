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
    public partial class ItemUi : Form
    {
        public string Id;

        ItemsManager _ItemsManager = new ItemsManager();

        public ItemUi()
        {
            InitializeComponent();
        }

        private void itemAddBtn_Click(object sender, EventArgs e)
        {
            Items items = new Items();

            items.ItemName = itemNameTextBox.Text;
            
            //Set Name as Mandatory
            if (String.IsNullOrEmpty(itemNameTextBox.Text))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }

            //Set Price as Mandatory
            if (String.IsNullOrEmpty(itemPriceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }

            items.ItemPrice = Convert.ToDouble(itemPriceTextBox.Text);

            //Check UNIQUE
            if (_ItemsManager.IsItemNameExist(items))
            {
                MessageBox.Show(items.ItemName + " Already Exists!");
                return;
            }

            bool isAdded = _ItemsManager.ItemsAdd(items);
            
            if (isAdded)
            {
                MessageBox.Show("Saved");
                itemDataGridView.DataSource = _ItemsManager.Display();
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            itemNameTextBox.Text = "";
            itemPriceTextBox.Text = "";
        }

        private void itemDeleteBtn_Click(object sender, EventArgs e)
        {
            Items items = new Items();

            items.ItemId = Convert.ToInt32(Id);
            
            bool isDeleted = _ItemsManager.ItemsDelete(items);

            if (isDeleted)
            {
                MessageBox.Show("Deleted");
                itemDataGridView.DataSource = _ItemsManager.Display();
            }
            else
            {
                MessageBox.Show(" Not Deleted");
            }

            itemNameTextBox.Text = "";
            itemPriceTextBox.Text = "";
        }

        private void itemUpdateBtn_Click(object sender, EventArgs e)
        {
            Items items = new Items();

            items.ItemName = itemNameTextBox.Text;
            items.ItemId = Convert.ToInt32(Id);

            //Set Name as Mandatory
            if (String.IsNullOrEmpty(itemNameTextBox.Text))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }

            //Set Price as Mandatory
            if (String.IsNullOrEmpty(itemPriceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }
            
            items.ItemPrice = Convert.ToDouble(itemPriceTextBox.Text);
            
            bool isUpdated = _ItemsManager.ItemsUpdate(items);

            if (isUpdated)
            {
                MessageBox.Show("Updated");
                itemDataGridView.DataSource = _ItemsManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }

            itemNameTextBox.Text = "";
            itemPriceTextBox.Text = "";
        }

        private void itemSearchBtn_Click(object sender, EventArgs e)
        {
            Items items = new Items();

            //Set Name as Mandatory

            if (String.IsNullOrEmpty(itemNameTextBox.Text))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }

            items.ItemName = itemNameTextBox.Text;

            itemDataGridView.DataSource = _ItemsManager.Search(items);

            itemNameTextBox.Text = "";
        }

        private void itemShowBtn_Click(object sender, EventArgs e)
        {
            itemDataGridView.DataSource = _ItemsManager.Display();
        }

        private void itemDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.itemDataGridView.Rows[e.RowIndex];
                Id = row.Cells[0].Value.ToString();
                itemNameTextBox.Text = row.Cells[1].Value.ToString();
                itemPriceTextBox.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
