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

            Response.Cookies["productcount"].Value = DataAccess.count("SELECT Count(ProductID) FROM Product");

        }
    }
}