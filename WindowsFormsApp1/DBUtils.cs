using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            String connStr = "Data Source=DESKTOP-OCADQAF;Initial Catalog=QLSVien;Persist Security Info=True;User ID=sa;Password=Dockersql123";
            SqlConnection conn = new SqlConnection(connStr);

            return conn;
        }
    }
}
