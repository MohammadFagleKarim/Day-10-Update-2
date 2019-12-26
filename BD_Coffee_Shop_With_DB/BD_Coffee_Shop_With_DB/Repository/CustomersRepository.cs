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
    public class CustomersRepository
    {
        public bool CustomersAdd(Customers customers)
        {
            bool IsAdded = false;

            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //Command
                string commandString = @"INSERT INTO Customers(CustomerName, Address, Contact) VALUES ('" + customers.CustomerName + "', '" + customers.Address + "', '" + customers.Contact + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, conn);

                //Execute
                conn.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    IsAdded = true;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return IsAdded;
        }

        public bool IsCustomerNameExist(Customers customers)
        {
            bool exist = false;

            //Connection

            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"SELECT * FROM Customers WHERE CustomerName ='" + customers.CustomerName + "' ";
            SqlCommand sqlCommand = new SqlCommand(commandString, conn);

            //Open

            conn.Open();

            //Execute

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            // showdataGridView.DataSource = dataTable;
            
            if (dataTable.Rows.Count > 0)
            {
                exist = true;
            }
            
            //Close

            conn.Close();

            return exist;
        }

        public bool CustomersDelete(Customers customers)
        {
            bool isdeleted = false;

            //Connection

            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"DELETE FROM Customers where CustomerId = '" + customers.CustomerId + "' ";
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

        public bool CustomersUpdate(Customers customers)
        {
            bool isupdate = false;
            
            //Connection

            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"UPDATE Customers SET CustomerName = '" + customers.CustomerName + "', Contact='" + customers.Contact + "', Address = '" + customers.Address + "' WHERE CustomerId = '" + customers.CustomerId + "' ";
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

        public List<Customers> Display()
        {
            //Connection

            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"SELECT * FROM Customers";
            SqlCommand sqlCommand = new SqlCommand(commandString, conn);

            //Open

            conn.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Customers> customers = new List<Customers>();

            while (sqlDataReader.Read())
            {
                Customers customer = new Customers();
                customer.CustomerId = Convert.ToInt32(sqlDataReader["CustomerId"]);
                customer.CustomerName = sqlDataReader["CustomerName"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.Contact = sqlDataReader["Contact"].ToString();

                customers.Add(customer);
            }

            //Execute

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
            //showdataGridView.DataSource = dataTable;

            //if (dataTable.Rows.Count > 0)
            //{
            //    //showdataGridView.DataSource = dataTable;
            //}

            //else
            //{
            //    //MessageBox.Show("Data Tabel not found");
            //}

            //Close

            conn.Close();

            return customers;
        }

        public DataTable Search(Customers customers)
        {
            //Connection

            string connectionString = @"Server=DESKTOP-0LIAG2C\SQLEXPRESS; DataBase=BDCoffeeShopBD; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Command

            string commandString = @"SELECT * FROM Customers WHERE CustomerName ='" + customers.CustomerName + "'";
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
