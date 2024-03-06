using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESE_PROJECT
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = " ";
        }

        

       

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (uname.Text == "scott" && pass.Text == "tiger")
            {
                Response.Write("<script>alert('Login successfull!!!');</script>");
            }
            else
            {
                Label1.Text = "Invalid username and password";
            }
        }
    }
}