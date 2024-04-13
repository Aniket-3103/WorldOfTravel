using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ESE_PROJECT
{
    public partial class Flightfind : System.Web.UI.Page
    {
        public static int rate;
        protected void Page_Load(object sender, EventArgs e)
        {

            checkFlight();
            
        }

        void checkFlight()
        {
            string maincon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(maincon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from flight_presents where Source='" + Session["from"].ToString() + "' and Destination='" + Session["to"].ToString() + "' and Date='" + Session["date"].ToString() + "';", con);

            SqlDataReader sr = cmd.ExecuteReader();
            if (sr.HasRows == true)
            {
                GridView1.DataSource = sr;
                GridView1.DataBind();
            }
            else
            {
                Label3.Text = "No flights available";
                Button2.Visible = false;
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
                Session["rate"] = GridView1.Rows[i].Cells[3].Text;
            if (login.check == 0)
            {
                Response.Write("<script>alert('Login to your account for booking');</script>");
                return;
            }
            if (Label3.Text!="No flights available")
            {
                SqlCommand cmd;
                string maincon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlConnection sc = new SqlConnection(maincon);
                sc.ConnectionString = "Data Source='LAPTOP-7GQIH06O\\SQLEXPRESS';" + "Initial Catalog='Ese'; Integrated Security = 'SSPI'";
                sc.Open();
                cmd = new SqlCommand("insert into flight_booking values('" + Session["Uname"].ToString() + "', '" + Session["from"].ToString() + "','" + Session["to"].ToString() + "', '" + Session["date"].ToString() + "'," + Int16.Parse(Session["no_of_pass"].ToString()) + "," +(Int16.Parse(Session["no_of_pass"].ToString())*Int16.Parse(Session["rate"].ToString())) + "," + "'12:00pm')");
                cmd.Connection = sc;
                cmd.ExecuteNonQuery();
                sc.Close();
                Response.Write("<script>alert('Flight booked succesfully');</script>");
            }
        }
    }
}