using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESE_PROJECT
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (login.check == 0)
            {
                Button2.Visible = false;
                Button3.Visible = false;
                Label3.Visible = false;
            }
            else if (login.check == 1)
            {
                Button2.Visible = true;
                Button1.Visible = false;
                Button3.Visible = true;
                Label3.Visible = true;
                Label3.Text = "Hello " + Session["Uname"];
            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            login.check = 0;
            Button1.Visible = true;
            Button2.Visible = false;
            Button3.Visible = false;
            
        }
        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("myBookings.aspx");
        }
    }
}