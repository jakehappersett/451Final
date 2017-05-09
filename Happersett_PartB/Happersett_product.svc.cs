using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace Happersett_PartB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Happersett_product" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Happersett_product.svc or Happersett_product.svc.cs at the Solution Explorer and start debugging.
    public class Happersett_product : IHappersett_product
    {
        public List<product> ReturnProducts(string id)
        {
            List<product> products = new List<product>();

            string _connectionString = WebConfigurationManager.ConnectionStrings["Final"].ConnectionString;

            SqlConnection con = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ProductID, Name, Type,  Description FROM Product WHERE ProductID = " +id;
            cmd.Connection = con;

            using (con)
            {
                con.Open(); 
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    product p = new product();
                    p.id = (int)reader["ProductID"];
                    p.name = (string)reader["Name"];
                    p.description = (string)reader["Description"];
                    //i can't figure out what is wrong with this, every time i add price i get an error?
//                    p.price = (double)reader["Price"];
                    p.type = (string)reader["Type"];

                    products.Add(p);
                }
            }

            return products;
        }
    }
}
