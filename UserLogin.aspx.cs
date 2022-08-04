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
    public partial class UserLogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                Response.Write("<script>alert('Please Provide all the fields');</script>");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                    }
                    SqlCommand cmd = new SqlCommand("select * from users where Email='" + TextBox1.Text.Trim() + "' AND password='" + TextBox2.Text.Trim() + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Response.Write("<script>alert('Login Successful');</script>");
                            Session["userId"] = dr.GetValue(0).ToString();
                            Session["FullName"] = dr.GetValue(1).ToString();
                            Session["DOB"] = dr.GetValue(2).ToString();
                            Session["role"] = "user";
                            Global.UID = dr.GetValue(0).ToString();




                        }

                        Response.Redirect("homepage.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Username or Password is Incorret !!!  Please Provide the valid Credentials');</script>");
                    }

                }
                catch (Exception ex)
                {

                }

            }
        }
    }
    }
