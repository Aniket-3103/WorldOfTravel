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
    public partial class Trainfindaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkTrain();
        }

        void checkTrain()
        {
            string maincon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(maincon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from train_presents where Source='" + Session["fromT"].ToString() + "' and Destination='" + Session["toT"].ToString() + "' and Date='" + Session["dateT"].ToString() + "';", con);

            SqlDataReader sr = cmd.ExecuteReader();
            if (sr.HasRows == true)
            {
                GridView1.DataSource = sr;
                GridView1.DataBind();
            }
            else
            {
                Label3.Text = "No trains available";
                Button2.Visible = false;
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                Session["rateT"] = GridView1.Rows[i].Cells[4].Text;
                Session["time"] = GridView1.Rows[i].Cells[3].Text;
            }
            if (login.check == 0)
            {
                Response.Write("<script>alert('Login to your account for booking');</script>");
                return;
            }
            if (Label3.Text != "No trains available")
            {
                SqlCommand cmd;
                string maincon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlConnection sc = new SqlConnection(maincon);
                sc.ConnectionString = "Data Source='LAPTOP-7GQIH06O\\SQLEXPRESS';" + "Initial Catalog='Ese'; Integrated Security = 'SSPI'";
                sc.Open();
                cmd = new SqlCommand("insert into train_booking values('" + Session["Uname"].ToString() + "', '" + Session["fromT"].ToString() + "','" + Session["toT"].ToString() + "', '" + Session["dateT"].ToString() + "'," + Int16.Parse(Session["no_of_passT"].ToString()) + "," + (Int16.Parse(Session["no_of_passT"].ToString()) * Int16.Parse(Session["rateT"].ToString())) + ",'" + Session["time"]+ "')");
                cmd.Connection = sc;
                cmd.ExecuteNonQuery();
                sc.Close();
                Response.Write("<script>alert('Train booked succesfully');</script>");
            }
        }
    }
}