using CompanyServiceClient.CompanyWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CompanyServiceClient {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void button1_Click(object sender, EventArgs e) {
            CompanyPublicServiceClient proxy = new CompanyPublicServiceClient("BasicHttpBinding_ICompanyPublicService");
            label1.Text = proxy.GetPublicInfo();
        }
        protected void button2_Click(object sender, EventArgs e) {
            CompanyConfidentialServiceClient proxy = new CompanyConfidentialServiceClient("NetTcpBinding_ICompanyConfidentialService");
            label2.Text = proxy.GetConfidentialInfo();
        }
    }
}