using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BD_Coffee_Shop_With_DB.Model;

namespace BD_Coffee_Shop_With_DB.Repository
{
    public class OrdersRepository
    {
        public bool OrdersAdd(Orders orders)
        {
            bool isadded = false;
            //Connection

            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"INSERT INTO Orders (Quantity, TotalPrice, Customer, Item) VALUES ('" + orders.Quantity + "', '" + orders.TotalPrice + "', '" + orders.Customer + "', '" + orders.Item + "') ";
            SqlCommand sqlCommand = new SqlCommand(commandString, conn);
            
            //Open

            conn.Open();

            //Execute

            int isExucuted = sqlCommand.ExecuteNonQuery();

            if (isExucuted > 0)
            {
                isadded = true;
            }

            //Close

            conn.Close();

            return isadded;
        }

        //public bool IsCustomerNameExist(Orders orders)
        //{
        //    bool exist = false;

        //    //Connection

        //    string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
        //    SqlConnection conn = new SqlConnection(connectionString);

        //    //Command

        //    string commandString = @"SELECT * FROM Orders WHERE Customer = '" + orders.Customer + "'";
        //    SqlCommand sqlCommand = new SqlCommand(commandString, conn);

        //    //Open

        //    conn.Open();

        //    //Execute

        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //    DataTable dataTable = new DataTable();
        //    sqlDataAdapter.Fill(dataTable);
        //    // showdataGridView.DataSource = dataTable;

        //    if (dataTable.Rows.Count > 0)
        //    {
        //        exist = true;
        //    }

        //    //Close

        //    conn.Close();

        //    return exist;
        //}

        public DataTable Display()
        {
            //Connection

            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"SELECT OrdersId, Customer, Item, Quantity, TotalPrice FROM Orders";
            SqlCommand sqlCommand = new SqlCommand(commandString, conn);
            
            //Open

            conn.Open();

            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //List<Orders> orders = new List<Orders>();

            //while (sqlDataReader.Read())
            //{
            //    Orders order = new Orders();
            //    order.OrdersId = Convert.ToInt32(sqlDataReader["OrdersId"]);
            //    //order.CustomersId = Convert.ToInt32(sqlDataReader["CustomersId"]);
            //    //order.ItemsId = Convert.ToInt32(sqlDataReader["ItemsId"]);
            //    order.Customer = sqlDataReader["Customer"].ToString();
            //    order.Item = sqlDataReader["Item"].ToString();
            //    order.Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
            //    order.TotalPrice = Convert.ToDouble(sqlDataReader["TotalPrice"]);

            //    orders.Add(order);
            //}

            //Execute

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //showdataGridView.DataSource = dataTable;

            //if (dataTable.Rows.Count > 0)
            //{
            //    showdataGridView.DataSource = dataTable;
            //}

            //else
            //{
            //    MessageBox.Show("Data Tabel not found");
            //}

            //Close

            conn.Close();

            return dataTable;
        }

        public DataTable CustomerCombo()
        {
            //Connection

            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"SELECT CustomerId, CustomerName FROM Customers";
            SqlCommand sqlCommand = new SqlCommand(commandString, conn);
            
            //Open

            conn.Open();

            //Execute

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            // showdataGridView.DataSource = dataTable;

            //if (dataTable.Rows.Count > 0)
            //{
            //    showdataGridView.DataSource = dataTable;
            //}

            //else
            //{
            //    MessageBox.Show("Data Tabel not found");
            //}

            //Close

            conn.Close();

            return dataTable;
        }

        public DataTable ItemCombo()
        {
            //Connection

            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"SELECT ItemId, ItemName FROM Items";
            SqlCommand sqlCommand = new SqlCommand(commandString, conn);

            //Open

            conn.Open();

            //Execute

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            // showdataGridView.DataSource = dataTable;

            //if (dataTable.Rows.Count > 0)
            //{
            //    showdataGridView.DataSource = dataTable;
            //}

            //else
            //{
            //    MessageBox.Show("Data Tabel not found");
            //}

            //Close

            conn.Close();

            return dataTable;
        }
    }
}
