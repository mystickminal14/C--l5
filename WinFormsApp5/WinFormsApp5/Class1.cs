using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Class1
    {
        public string connString()
        {
            string connString = @"Server = LAPTOP-8S66HJKL\MINAL; Database=users;Trusted_Connection=True";
            return connString;
        }
        
        public void insertData(string query)
        {
            var connectString = connString();


            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
