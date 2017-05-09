using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Happersett_Final.ServiceReference1;

namespace Happersett_Final
{
    public partial class QuestionB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Happersett_productClient client = new Happersett_productClient();
            string variable = Text1.Value.ToString();
            grbProduct.DataSource = client.ReturnProducts(variable);
            grbProduct.DataBind();

        }
    }
}