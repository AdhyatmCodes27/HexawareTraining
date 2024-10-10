using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.DatabaseLayer
{
    public static class DBUtil
    {
        public static SqlConnection getDBConnection()
        {
            SqlConnection conn;
            string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ABC;Integrated Security=True";
            conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            return conn;
        }
    }
   // Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = ABC; Integrated Security = True
}