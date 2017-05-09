using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Happersett_Final
{
    public partial class Product_Details : System.Web.UI.Page
    {
        ProdList myCart;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["product_id"];
                if (id != null)
                {
                    g_prod.DataSource = DataAccess.selectQuery("SELECT * FROM Product WHERE ProductID= " + id);
                    g_prod.DataBind();
                }
            }
            //if (Session["mycart"] != null)
            //{
            //    //int counter = 0;
            //    //Response.Cookies["itemcount"].Value = counter.ToString();
            //    //foreach (var item in myCart.Items)
            //    //{
            //    //    counter++; 
            //    //}


            //}

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["myCart"] == null)
            {
                myCart = new ProdList();
                Session["myCart"] = myCart;
            }
            string id = Request.QueryString["product_id"];
            myCart = (ProdList)Session["myCart"];
            DataTable dt = DataAccess.selectQuery("SELECT * FROM Product WHERE ProductID= " + Request.QueryString["product_id"]);
            DataRow row = dt.Rows[0];


            myCart.Insert(new Prod(Int32.Parse(id),
            row["Name"].ToString(),
            row["Description"].ToString(),
            Double.Parse(row["Price"].ToString()),
            row["Type"].ToString()
            ));

        }
    }
}