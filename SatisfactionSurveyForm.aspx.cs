using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webproj2
{
    public partial class SatisfactionSurveyForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Button1_Click(object sender, EventArgs e)
        {





            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Insert Into Feedback values (@FullName,@HospitalName,@Attitude,@Responding,@SeriousConcern,@ToiletNeeds,@Dressup,@StaffsAssign,@FoodQuality,@TempFood,@MenuChoices,@activities,@Therapy)", con);
            cmd.Parameters.AddWithValue("@FullName", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@HospitalName", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@Attitude", RadioButtonList1.Text.Trim());
            cmd.Parameters.AddWithValue("@Responding", RadioButtonList2.Text.Trim());
            cmd.Parameters.AddWithValue("@SeriousConcern", RadioButtonList3.Text.Trim());
            cmd.Parameters.AddWithValue("@ToiletNeeds", RadioButtonList4.Text.Trim());
            cmd.Parameters.AddWithValue("@Dressup", RadioButtonList5.Text.Trim());
            cmd.Parameters.AddWithValue("@StaffsAssign", RadioButtonList6.Text.Trim());
            cmd.Parameters.AddWithValue("@FoodQuality", RadioButtonList7.Text.Trim());
            cmd.Parameters.AddWithValue("@TempFood", RadioButtonList8.Text.Trim());
            cmd.Parameters.AddWithValue("@MenuChoices", RadioButtonList9.Text.Trim());
            cmd.Parameters.AddWithValue("@activities", RadioButtonList10.Text.Trim());
            cmd.Parameters.AddWithValue("@Therapy", RadioButtonList11.Text.Trim());






            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Thank You for your Valuable Feedback...');</script>");

        }
             }



}