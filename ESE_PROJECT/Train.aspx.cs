using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ESE_PROJECT
{
    public partial class Train : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["fromT"] = TextBox1.Text.Trim();
            Session["toT"] = TextBox2.Text.Trim();
            Session["dateT"] = TextBox3.Text.Trim();
            Session["no_of_passT"] = TextBox4.Text.Trim();
            Response.Redirect("Trainfind.aspx");
        }

        
    }
}