using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AngularApi
{
    public class SQL
    {
        public static DataTable Exec(string srg)
        {
            string connectionString = @"Data Source=wdb4.my-hosting-panel.com;Initial Catalog = nurlans1_smartjano; Persist Security Info=True;User ID = nurlans1_smartjano; Password=C8*z2yy6";
            SqlConnection sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
            SqlCommand sorgu = new SqlCommand(srg, sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqlcon.Close();
            return dt;
        }

    }
}
