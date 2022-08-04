using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webproj2
{

    public partial class AdminManageHospital : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           

            GridView1.DataBind();

        }
        // User Defined Functions

        //For getting Hospital by id
        void updateHospitalById()
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("Update Hospitals set HospitalName=@HospitalName,City=@City,Ward=@Ward,Email=@Email,Contact_Number=@Contact_Number,APIKey=@APIKey,Googlemap=@GoogleMap,hospitalPic=@hospitalPic where HID='" + TextBox1.Text.Trim() + "';", con);


                cmd.Parameters.AddWithValue("@HospitalName", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@City", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@Ward", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@Contact_Number", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@APIKey", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@Googlemap", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@hospitalPic", TextBox3.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                GridView1.DataBind();
                Response.Write("<script>alert('Hospital updated successfully.');</script>");




            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void getHospitalById()
        {
            try
            {



                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("select * from Hospitals where HID='" + TextBox1.Text.Trim() + "';", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox3.Text = dt.Rows[0]["hospitalPic"].ToString();
                    TextBox2.Text = dt.Rows[0]["HospitalName"].ToString();
                    TextBox9.Text = dt.Rows[0]["City"].ToString();
                    TextBox10.Text = dt.Rows[0]["Ward"].ToString();
                    TextBox5.Text = dt.Rows[0]["Email"].ToString();
                    TextBox4.Text = dt.Rows[0]["Contact_Number"].ToString();
                    TextBox7.Text = dt.Rows[0]["APIKey"].ToString();
                    TextBox6.Text = dt.Rows[0]["GoogleMap"].ToString();


                }
                else
                {
                    Response.Write("<script>alert('Invalid Hospital ID');</script>");

                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void deleteHospitalByID()
        {
            if (checkIfHospitalExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE Hospitals WHERE HID='" + TextBox1.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Hospital Deleted Successfully');</script>");

                    GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid Hospital ID');</script>");
            }
        }

        
        void addNewHospital()
        {
            try
            {


               
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Hospitals (HID ,HospitalName,City,Ward,Email,Contact_Number,APIKey,Googlemap,hospitalPic) values (@HID,@HospitalName,@City,@Ward,@Email,@ContactNumber,@APIKey,@Googlemap,@hospitalPic)", con);

                cmd.Parameters.AddWithValue("@HID", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@HospitalName", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@City", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@Ward", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNumber", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@APIKey", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@Googlemap", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@hospitalPic", TextBox3.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Hospital added successfully.');</script>");
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        bool checkIfHospitalExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from Hospitals where HID = @HID", con);
                cmd.Parameters.AddWithValue("@HID", TextBox1.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkIfHospitalExists())
            {
                Response.Write("<script>alert('Hospital Already Exists, try some other Hospital ID');</script>");
            }
            else
            {
                addNewHospital();
            }
           
         

        }
        

       
      
        //Delete Button Click
        

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
           getHospitalById();
        }
        //Update Button Click

        protected void Button3_Click1(object sender, EventArgs e)
        {
            updateHospitalById();
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            deleteHospitalByID();
        }
    }
}