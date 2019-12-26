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
    public class ItemsRepository
    {
        public bool ItemsAdd(Items items)
        {
            bool Isadded = false;

            try
            {
                //Connection

                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command

                string commandString = @"INSERT INTO Items (ItemName, ItemPrice) VALUES ('" + items.ItemName + "','" + items.ItemPrice + "');";
                SqlCommand sqlCommand = new SqlCommand(commandString, conn);

                //Open

                conn.Open();

                //Execute

                int isExucuted = sqlCommand.ExecuteNonQuery();

                if (isExucuted > 0)
                {
                    Isadded = true;
                }

                //Close

                conn.Close();
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return Isadded;
        }

        public bool IsItemNameExist(Items items)
        {
            bool exist = false;

            //Connection

            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"SELECT * FROM Items WHERE ItemName = '" + items.ItemName + "' ";
            SqlCommand sqlCommand = new SqlCommand(commandString, conn);
            
            //Open

            conn.Open();

            //Execute

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //showdataGridView.DataSource = dataTable;
            
            if (dataTable.Rows.Count > 0)
            {
                exist = true;
            }
            
            //Close

            conn.Close();

            return exist;
        }

        public bool ItemsDelete(Items items)
        {
            bool isdeleted = false;
            //Connection

            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"DELETE FROM Items WHERE ItemId = '" + items.ItemId + "' ";
            SqlCommand sqlCommand = new SqlCommand(commandString, conn);

            //Open

            conn.Open();

            //Execute

            int isExucuted = sqlCommand.ExecuteNonQuery();

            if (isExucuted > 0)
            {
                isdeleted = true;
            }
            
            //Close

            conn.Close();

            return isdeleted;
        }

        public bool ItemsUpdate(Items items)
        {
            bool isupdate = false;
            
            //Connection

            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"UPDATE Items SET ItemName = '" + items.ItemName + "', ItemPrice = '" + items.ItemPrice + "' WHERE ItemId = '" + items.ItemId + "' ";
            SqlCommand sqlCommand = new SqlCommand(commandString, conn);

            //Open

            conn.Open();

            //Execute

            int isexecute = sqlCommand.ExecuteNonQuery();

            if (isexecute > 0)
            {
                isupdate = true;
            }

            //Close

            conn.Close();

            return isupdate;
        }

        public List<Items> Display()
        {
            //Connection

            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"SELECT * FROM Items";
            SqlCommand sqlCommand = new SqlCommand(commandString, conn);

            //Open

            conn.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Items> items = new List<Items>();

            while (sqlDataReader.Read())
            {
                Items item = new Items();
                item.ItemId = Convert.ToInt32(sqlDataReader["ItemId"]);
                item.ItemName = sqlDataReader["ItemName"].ToString();
                item.ItemPrice = Convert.ToDouble(sqlDataReader["ItemPrice"]);

                items.Add(item);
            }

            //Execute

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
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

            return items;
        }

        public DataTable Search(Items items)
        {
            //Connection
            
            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"SELECT * FROM Items WHERE ItemName ='" + items.ItemName + "'";
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
