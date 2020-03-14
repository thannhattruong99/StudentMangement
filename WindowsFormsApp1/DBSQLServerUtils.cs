using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class DBSQLServerUtils
    {
        public static SqlConnection GetDBConnection(String datasource, String database, String username, String password)
        {
            String connStr = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connStr);

            return conn;
        }
    }
}
