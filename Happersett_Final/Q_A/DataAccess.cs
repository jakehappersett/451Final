using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Happersett_Final
{
    public static class DataAccess
    {
        private static string myConnectionString;

        static DataAccess()
        {
            myConnectionString = WebConfigurationManager.ConnectionStrings["Final"].ConnectionString;
        }

        public static DataTable selectQuery(string query)
        {
            DataTable dt = new DataTable();
            SqlConnection cnn = new SqlConnection(myConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public static string count(string query)
        {
            SqlConnection cnn = new SqlConnection(myConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            int count = (int)cmd.ExecuteScalar();
            return count.ToString();
        }

        
}
}