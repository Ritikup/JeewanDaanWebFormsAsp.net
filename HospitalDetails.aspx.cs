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
    public partial class HospitalDetails : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            int HID = Convert.ToInt32(Request.QueryString["HID"].ToString());
            try
            {


                if (Session["userId"] == null)
                {
                    Label2.Text = "";
                }
                else
                {
                    Label2.Text = Session["userId"].ToString();
                }
            }
            catch (Exception ex)
            {

            }

            //  Label2.Text = Global.UID;
            getHospitalByID(HID);

        }

        void getHospitalByID(int a)
        {
            try
            {

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("select * from Hospitals where HID= @HID", con);
                cmd.Parameters.AddWithValue("@HID", a);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {

                    lblPharmacyName.Text = dt.Rows[0]["HospitalName"].ToString();
                    txtPID.Text = dt.Rows[0]["HID"].ToString();
                    txtCity.Text = dt.Rows[0]["City"].ToString();
                    txtWard.Text = dt.Rows[0]["Ward"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    txtContact.Text = dt.Rows[0]["Contact_Number"].ToString();
                    Label1.Text = dt.Rows[0]["HID"].ToString();
                    Image1.ImageUrl = dt.Rows[0]["hospitalPic"].ToString();
                    map.Attributes["src"] = dt.Rows[0]["Googlemap"].ToString();

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

        void bookingService()
        {
            try
            {

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                

                SqlCommand command = new SqlCommand("SpBooking", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PatientName", TextBox1.Text.Trim());
                command.Parameters.AddWithValue("@CustomerId", Label2.Text.Trim());
                command.Parameters.AddWithValue("@HospitalId", Label1.Text.Trim());

                command.Parameters.AddWithValue("@ICUBeds", TextBox9.Text.Trim());
                command.Parameters.AddWithValue("@CovidBeds", TextBox4.Text.Trim());
                command.Parameters.AddWithValue("@OxygenBeds", TextBox10.Text.Trim());
                command.Parameters.AddWithValue("@NormalBeds", TextBox5.Text.Trim());
                command.Parameters.AddWithValue("@VentilatorBeds", TextBox11.Text.Trim());



                int result=command.ExecuteNonQuery();
                if (result > 0)
                {
                    Response.Write("<script>alert('Booking done successfully.');</script>");
                }
                    
                

                con.Close();
               
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Write("<script>alert('Please login first to book  the services !!');</script>");
            }
           else if (Session["role"] == "admin")
            {
                Response.Write("<script>alert(' Admin cannot book the services.  Please login as a user to book the services!!');</script>");
            }
            else if (TextBox1.Text == "")
            {
                Response.Write("<script>alert('Patient Name cannot be empty !!');</script>");

            }
            else if (TextBox9.Text == "0" && TextBox10.Text == "0" && TextBox11.Text == "0" && TextBox4.Text == "0" && TextBox5.Text == "0")
            {
                Response.Write("<script>alert('You should book atleast one service !!');</script>");

            }

            else
            {

                bookingService();

            }

        }
    }
}