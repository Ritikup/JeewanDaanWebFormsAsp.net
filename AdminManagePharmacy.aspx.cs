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
    public partial class AdminManagePharmacy : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        //Add Button
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkIfPharmacyExists())
            {
                Response.Write("<script>alert('Pharmacy Already Exists, try some other Pharmacy ID');</script>");
            }
            else
            {
                addNewPharmacy();
            }

        }
        //Update Button
        protected void Button3_Click(object sender, EventArgs e)
        {
            

            updatePharmacyById();
        }
        //Delete Button
        protected void Button2_Click(object sender, EventArgs e)
        {
            deletePharmacyByID();
        }



        void addNewPharmacy()
        {
            try
            {

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Pharmacy (PID ,PharmacyName,City,Ward,Email,Contact_Number,Googlemap,pharmacyPic) values (@HID,@HospitalName,@City,@Ward,@Email,@ContactNumber,@Googlemap,@hospitalPic)", con);

                cmd.Parameters.AddWithValue("@HID", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@HospitalName", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@City", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@Ward", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNumber", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Googlemap", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@hospitalPic", TextBox3.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Pharmacy added successfully.');</script>");
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        bool checkIfPharmacyExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from Pharmacy where PID = @HID", con);
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
        void updatePharmacyById()
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("Update Pharmacy set PharmacyName=@PharmacyName,City=@City,Ward=@Ward,Email=@Email,Contact_Number=@Contact_Number,Googlemap=@GoogleMap,pharmacyPic=@pharmacyPic where PID='" + TextBox1.Text.Trim() + "';", con);


                cmd.Parameters.AddWithValue("@PharmacyName", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@City", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@Ward", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@Contact_Number", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Googlemap", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@pharmacyPic", TextBox3.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                GridView1.DataBind();
                Response.Write("<script>alert('Pharmacy updated successfully.');</script>");




            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void getPharmacyById()
        {
            try
            {



                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("select * from Pharmacy where PID='" + TextBox1.Text.Trim() + "';", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox3.Text = dt.Rows[0]["pharmacyPic"].ToString();
                    TextBox2.Text = dt.Rows[0]["PharmacyName"].ToString();
                    TextBox9.Text = dt.Rows[0]["City"].ToString();
                    TextBox10.Text = dt.Rows[0]["Ward"].ToString();
                    TextBox5.Text = dt.Rows[0]["Email"].ToString();
                    TextBox4.Text = dt.Rows[0]["Contact_Number"].ToString();
                    TextBox6.Text = dt.Rows[0]["GoogleMap"].ToString();



                }
                else
                {
                    Response.Write("<script>alert('Invalid Pharmacy ID');</script>");

                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void deletePharmacyByID()
        {
            if (checkIfPharmacyExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE Pharmacy WHERE PID='" + TextBox1.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Pharmacy Deleted Successfully');</script>");

                    GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid Pharmacy ID');</script>");
            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
getPharmacyById();
        }
    }
}