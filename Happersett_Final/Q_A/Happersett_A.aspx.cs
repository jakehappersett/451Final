using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace Happersett_Final
{
    public partial class Happersett_A : System.Web.UI.Page
    {
        ProdList myCart;
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Cookies["itemcount"].Expires = DateTime.Now.AddYears(1);
            if (Session["mycart"] != null)
            {
                myCart = (ProdList)Session["myCart"];
                Response.Cookies["itemcount"].Value = myCart.Items.Count.ToString();
                Label1.Text = Response.Cookies["itemcount"].Value;
            }
            else
            {
                Label1.Text = "no session";
            }

            //Response.Cookies["productcount"].Expires = DateTime.Now.AddYears(1);

            //string _connectionString = WebConfigurationManager.ConnectionStrings["Final"].ConnectionString;

            //SqlConnection con = new SqlConnection(_connectionString);

            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SELECT ProductID FROM Product";
            //cmd.Connection = con;

            //using (con)
            //{
            //    int counter = 0;
            //    con.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
                   
            //        counter++;
            //        Response.Cookies["productcount"].Value = counter.ToString();
            //    }
            //}
            
        }
    }
}