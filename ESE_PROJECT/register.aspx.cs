using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ESE_PROJECT
{
    public partial class register : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection sc;
        protected void Page_Load(object sender, EventArgs e)
        {
            sc = new SqlConnection();

            sc.ConnectionString = "Data Source='LAPTOP-7GQIH06O\\SQLEXPRESS';" + "Initial Catalog='Ese'; Integrated Security = 'SSPI'";
            sc.Open();
        }

        protected void Button_1_Click(object sender, EventArgs e)
        {
            string fname = Request.Form["TextBox1"];
            string lname = Request.Form["TextBox2"];
            string age = Request.Form["TextBox4"];
            string email = Request.Form["TextBox5"];
            string uname = Request.Form["TextBox6"];
            string pass = Request.Form["TextBox7"];
            int i=0;
            if (Rb1.Checked == true)
            {
                i = 1;
            }
            else if (Rb2.Checked == true) { 
                i = 2;
            }
            else if (Rb3.Checked == true) {
                i = 3;
            }

            
            cmd = new SqlCommand("insert into register values('" + fname.ToString() + "', '" + lname.ToString() + "'," + i.ToString() + ", " + age.ToString() + ",'" + uname.ToString() + "','" + pass.ToString() + "'," + "'" + email.ToString() + "')");
           
            cmd.Connection = sc;
            cmd.ExecuteNonQuery();
		    sc.Close();
            Response.Redirect("Login.aspx");

        }
    }
}