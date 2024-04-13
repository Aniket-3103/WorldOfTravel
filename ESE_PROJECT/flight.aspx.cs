using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ESE_PROJECT
{
    public partial class flight : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Label6.Visible = false;
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Calendar1.SelectedDate.Date.ToShortDateString();
            if(Calendar1.SelectedDate.Date.ToUniversalTime() <= System.DateTime.Now.ToUniversalTime())
             {
                Label6.Text = "Start Date Cannot be before tommorrow";
                TextBox3.Text = "";
                Calendar1.Visible = false;
            }
            Calendar1.Visible = false;
            Label6.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["from"] = TextBox1.Text.Trim();
            Session["to"] = TextBox2.Text.Trim();
            Session["date"] = TextBox3.Text.Trim();
            Session["no_of_pass"] = TextBox4.Text.Trim();
            Response.Redirect("Flightfind.aspx");
        }
    }
}