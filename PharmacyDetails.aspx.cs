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
    public partial class PharmacyDetails : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            int PID = Convert.ToInt32(Request.QueryString["PID"].ToString());
            
            getPharmacyByID(PID);
        }
        void getPharmacyByID(int a)
        {
            try
            {



                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("select * from Pharmacy where PID= @PID", con);
                cmd.Parameters.AddWithValue("@PID", a);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {

                    lblPharmacyName.Text = dt.Rows[0]["PharmacyName"].ToString();
                    txtPID.Text = dt.Rows[0]["PID"].ToString();
                    txtCity.Text = dt.Rows[0]["City"].ToString();
                    txtWard.Text = dt.Rows[0]["Ward"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    txtContact.Text = dt.Rows[0]["Contact_Number"].ToString();
                    Image1.ImageUrl = dt.Rows[0]["pharmacyPic"].ToString();
                    map.Attributes["src"]= dt.Rows[0]["Googlemap"].ToString();
                    map.Src = dt.Rows[0]["Googlemap"].ToString();

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



    }
}