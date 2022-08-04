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
    public partial class UserSignup : System.Web.UI.Page
    {

        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Signup Button Click Event:
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text==""||TextBox2.Text==""||TextBox3.Text==""||TextBox4.Text==""||TextBox5.Text==""||TextBox6.Text==""||TextBox8.Text==""||TextBox10.Text=="")
            {
                Response.Write("<script>alert('Please Provide all the fields');</script>");


            }
           else if (checkUserExists())
            {
                Response.Write("<script>alert('User already exists with this email id, try using another email ID');</script>");

            }
            else
            {
                signupNewUser();

            }


        }
        //User Defined Methods
        bool checkUserExists() {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Select* from users where Email='"+TextBox4.Text.Trim()+"';", con);
                SqlDataAdapter da=new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex) {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;

            }

        }
        void signupNewUser() {
            try
            {
                if (TextBox8.Text.Trim() == TextBox10.Text.Trim())
                {


                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("Insert Into users values(@FullName,@DOB,@ContactNo,@Email,@Country,@City,@password)", con);
                    cmd.Parameters.AddWithValue("@FullName", TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@DOB", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNo", TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", TextBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@Country", TextBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@City", TextBox6.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", TextBox8.Text.Trim());

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Sign Up Successful. Go to Login');</script>");

                }
                else
                {
                    Response.Write("<script>alert('Passwords Do Not Match');</script>");

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }
    }
}