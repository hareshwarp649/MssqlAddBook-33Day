using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MssqlAddBook33_16
{
    internal class AddressBookData
    {
        #region DB Connection String
        public static string connectionString = @"Data Source=DESKTOP-C7TGR0I;Initial Catalog=Address_Book_Service;Integrated Security=True";
        #endregion

        #region Get All the Contacts From Database to Console
        public void GetContactDetailsByDataAdapter(string query)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlConnection connection;
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(ds);
                    foreach (DataRow dataRow in ds.Tables[0].Rows)
                    {
                        Console.WriteLine(dataRow["FirstName"] + "," + dataRow["LastName"] + "," + dataRow["AddressDetails"] + "," + dataRow["City"] + "," + dataRow["StateName"] + "," + dataRow["Zip"] + "," + dataRow["PhoneNo"] + "," + dataRow["Email"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
