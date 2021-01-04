using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Final_Assignment
{
    public class DataBase
    {
        public static SqlConnection ConnectionDB()
        {
            string conString = @"Data Source=DESKTOP-K1TMDIH\SQLEXPRESS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(conString);
            return conn;

        }
    }
}
