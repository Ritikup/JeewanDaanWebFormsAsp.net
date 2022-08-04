using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webproj2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                if (Session["role"]==null)
                {
                    LinkButton1.Visible = true;    //User Login Link Button
                    LinkButton2.Visible = true; //Sign Up Button
                    LinkButton3.Visible = false; //Logout user link button
                    LinkButton4.Visible = false; //Hello User link Button


                    LinkButton6.Visible = true; //adminlogin user link button
                    LinkButton11.Visible = false; //Logout user link button
                    LinkButton12.Visible = false; //Logout user link button

                }

                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false;    //User Login Link Button
                    LinkButton2.Visible = false; //Sign Up Button
                    LinkButton3.Visible = true; //Logout user link button
                    LinkButton4.Visible = true; //Hello User link Button
                    LinkButton4.Text = "Hello "+Session["FullName"].ToString();


                    LinkButton6.Visible = true; //adminlogin user link button
                    LinkButton11.Visible = false; //Logout user link button
                    LinkButton12.Visible = false; //Logout user link button

                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false;    //User Login Link Button
                    LinkButton2.Visible = false; //Sign Up Button
                    LinkButton3.Visible = true; //Logout user link button
                    LinkButton4.Visible = true; //Hello User link Button
                    LinkButton5.Visible = true;//Manage pharmacy
                    LinkButton4.Text = "Hello Admin " ;

                    LinkButton6.Visible = false; //adminlogin user link button
                    LinkButton11.Visible = true; //Logout user link button
                    LinkButton12.Visible = true; //Logout user link button

                }

            }

            catch(Exception ex) { 
            
            }


        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminManageHospital.aspx");

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLogin.aspx");

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserSignup.aspx");


        }
       

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["userId"] = "";
            Session["FullName"] = "";
            Session["DOB"] = "";
            Session["role"] = "";

            LinkButton1.Visible = true;    //User Login Link Button
            LinkButton2.Visible = true; //Sign Up Button
            LinkButton3.Visible = false; //Logout user link button
            LinkButton4.Visible = false; //Hello User link Button


            LinkButton6.Visible = true; //adminlogin user link button
            LinkButton11.Visible = false; //Logout user link button
            LinkButton12.Visible = false; //Logout user link button

            Response.Redirect("homepage.aspx");


        }

        protected void LinkButton5_Click1(object sender, EventArgs e)
        {
            Response.Redirect("AdminManagePharmacy.aspx");
        }

        protected void Linkbtn4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPharmacy.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewHospital.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminManageUser.aspx");
        }
    }
}