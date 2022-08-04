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
    public partial class AdminManageUser : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();

        }
        //Add Button Click//
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkUserExists())
            {
                Response.Write("<script>alert('User already exists with this email id, try using another email ID');</script>");

            }
            else
            {
                signupNewUser();
                GridView1.DataBind();

            }

        }
        //Update Button Click//
        protected void Button3_Click(object sender, EventArgs e)
        {
            updateUserkById();
        }
        // Delete Button Click//
        protected void Button2_Click(object sender, EventArgs e)
        {
            deleteBookByID();
        }
        //Go button Click
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            getUserById();
        }

        
        //UDF

        

        void deleteBookByID()
        {
            if (checkUserExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from users WHERE UserId='" + TextBox1.Text.Trim() + "';", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('User Deleted Successfully');</script>");

                    GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid Member ID');</script>");
            }
        }
        void updateUserkById()
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("Update users set FullName=@FullName,DOB=@DOB,ContactNo=@ContactNo,Email=@Email,Country=@Country,City=@City,password=@password where UserId ='" + TextBox1.Text.Trim() + "';", con);


                cmd.Parameters.AddWithValue("@FullName", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@DOB", DOBTXT.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNo", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@Country", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@City", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TextBox3.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                GridView1.DataBind();
                Response.Write("<script>alert('User Details updated successfully.');</script>");




            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }



        void getUserById()
        {
            try
            {



                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("select * from users where UserId='" + TextBox1.Text.Trim() + "';", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    
                    TextBox2.Text = dt.Rows[0]["FullName"].ToString();
                    TextBox9.Text = dt.Rows[0]["City"].ToString();
                    TextBox10.Text = dt.Rows[0]["Country"].ToString();
                    TextBox5.Text = dt.Rows[0]["Email"].ToString();
                    DOBTXT.Text =Convert.ToDateTime(dt.Rows[0]["DOB"]).ToString("yyyy-MM-dd");
                    TextBox4.Text = dt.Rows[0]["ContactNo"].ToString();
                    TextBox3.Text = dt.Rows[0]["password"].ToString();
                    


                }
                else
                {
                    Response.Write("<script>alert('Invalid User ID');</script>");

                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }


        bool checkUserExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Select * from users where Email='" + TextBox5.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;

            }

        }
        void signupNewUser()
        {
            try
            {
               


                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("Insert Into users values(@FullName,@DOB,@ContactNo,@Email,@Country,@City,@password)", con);
                    cmd.Parameters.AddWithValue("@FullName", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@DOB", DOBTXT.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNo", TextBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", TextBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@Country", TextBox10.Text.Trim());
                    cmd.Parameters.AddWithValue("@City", TextBox9.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", TextBox3.Text.Trim());

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('User Successfully Registered');</script>");

                
               
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }
    }
}