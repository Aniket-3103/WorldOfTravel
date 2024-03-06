using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ESE_PROJECT
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection sc;
        SqlCommand cmd;
        public static int check=0;
        public static string prevPage;
        protected void Page_Load(object sender, EventArgs e)
        {
            sc = new SqlConnection();
            sc.ConnectionString = "Data Source='LAPTOP-7GQIH06O\\SQLEXPRESS';" + "Initial Catalog='Ese'; Integrated Security = 'SSPI'";
            sc.Open();

        }

       
        protected void Button1_Click(object sender, EventArgs e)
        {
            string uname = Request.Form["TextBox1"];
            string pass = Request.Form["TextBox2"];
            Session["Uname"] = TextBox1.Text;
            Session["Pass"] = TextBox2.Text;
            if (uname != null)
            {
                SqlDataAdapter ad = new SqlDataAdapter();
                cmd= new SqlCommand("select * from register where username='"+uname.ToString()+"' and " + "password='" + pass.ToString()+"' ");
                cmd.Connection = sc;
                ad.SelectCommand = cmd;
                DataTable dt = new DataTable();
                ad.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    check = 1;
                    Response.Redirect("home.aspx");
                }
                else
                {
                    Label4.Text = "Invalid username and password";
                }
            }
            sc.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }
    }
}