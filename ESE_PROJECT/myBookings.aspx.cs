using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ESE_PROJECT
{
    public partial class myBookings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkFlight();
            checkTrain();
            Label3.Visible = false;
            TextBox1.Visible = false;
            Label4.Visible = false;
            TextBox2.Visible = false;
        }

        void checkFlight()
        {
            string maincon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(maincon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from flight_booking where username='" +Session["Uname"].ToString() + "';", con);

            SqlDataReader sr = cmd.ExecuteReader();
            if (sr.HasRows == true)
            {
                GridView1.DataSource = sr;
                GridView1.DataBind();
            }
            else
            {
                GridView1.ShowHeaderWhenEmpty = true;
                GridView1.EmptyDataText = "No Flights found";
            }
        }


        void checkTrain()
        {
            string maincon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(maincon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from train_booking where username='" + Session["Uname"].ToString() + "';", con);

            SqlDataReader sr = cmd.ExecuteReader();
            if (sr.HasRows == true)
            {
                GridView2.DataSource = sr;
                GridView2.DataBind();
            }
            else
            {
                GridView2.ShowHeaderWhenEmpty = true;
                GridView2.EmptyDataText = "No Trains found";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label3.Visible = true;
            TextBox1.Visible = true;
            string dateDel = TextBox1.Text;
            string maincon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(maincon);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete  from flight_booking where username='" + Session["Uname"].ToString() + "' and Date='"+ dateDel+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            checkFlight();
            Response.Write("<script>alert('Flight deleted successfully');</script>");
            //Label3.Visible = false;
            //TextBox1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label4.Visible = true;
            TextBox2.Visible = true;
            string dateDel = TextBox2.Text;
            string maincon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(maincon);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from train_booking where username='" + Session["Uname"].ToString() + "' and Date='" + dateDel + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            checkTrain();
            Response.Write("<script>alert('Train deleted successfully');</script>");
            //Label4.Visible = false;
            //TextBox2.Visible = false;
        }
    }
}