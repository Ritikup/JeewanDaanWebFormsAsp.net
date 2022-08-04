using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using webproj2.Models;

namespace webproj2
{
    public partial class Dashview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            IEnumerable<Resources> resobj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:7228/api/");
            var consumeApi = hc.GetAsync("Resources");
            consumeApi.Wait();

            var Readdata = consumeApi.Result;

            if (Readdata.IsSuccessStatusCode)
            {
                var displayrecords = Readdata.Content.ReadAsAsync<IList<Resources>>();

                displayrecords.Wait();
                resobj = displayrecords.Result;
                GridView1.DataSource = resobj;
                GridView1.DataBind();


            }



        }
    }
}