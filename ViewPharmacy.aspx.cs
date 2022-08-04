using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace webproj2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ViewMore")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                Response.Redirect("~/PharmacyDetails.aspx?PID=" + row.Cells[0].Text);
            }

            if (e.CommandName == "CallNow")
            {
               // int index = Convert.ToInt32(e.CommandArgument);
                //GridViewRow row = GridView1.Rows[index];
                //Clipboard.SetText("your string");
                Response.Write("<script>alert('Phone Number Copied to the clipboard.');</script>");

            }

            if (e.CommandName == "Edit")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                Response.Redirect("~/PharmacyDetails.aspx?PID=" + row.Cells[0].Text);
            }

        }

    }
}