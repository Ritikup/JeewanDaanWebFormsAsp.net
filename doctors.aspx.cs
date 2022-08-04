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
    public partial class doctors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            IEnumerable<Docotor> docobj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:7228/api/");
            var consumeApi = hc.GetAsync("Doctor");
            consumeApi.Wait();

            var Readdata = consumeApi.Result;

            if (Readdata.IsSuccessStatusCode)
            {
                var displayrecords = Readdata.Content.ReadAsAsync<IList<Docotor>>();

                displayrecords.Wait();
                docobj = displayrecords.Result;
                GridView1.DataSource = docobj;
                GridView1.DataBind();




            }
        }
    }
}