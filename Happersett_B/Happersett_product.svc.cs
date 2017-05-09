using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace Happersett_B
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "product" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select product.svc or product.svc.cs at the Solution Explorer and start debugging.
    public class Happersett_product : IHappersett_product
    {

        public List<product> ReturnProducts()
        {
            List<product> products = new List<product>();

            string _connectionString = WebConfigurationManager.ConnectionStrings["matterhorn"].ConnectionString;

            //create a connection 
            SqlConnection con = new SqlConnection(_connectionString);

            //create command object
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT product_id, product_name FROM product";
            cmd.Connection = con;

            using (con)
            {
                con.Open(); //open connection
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    product p = new product();
                    p.id = (int)reader["product_id"];
                    p.name = (string)reader["product_name"];

                    products.Add(p);

                }

            }

            //open connection 

            //execute command 

            //read data 

            //add data to the list

            return products;
        }
    }
}
