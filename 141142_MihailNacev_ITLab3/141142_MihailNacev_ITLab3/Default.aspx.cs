using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _141142_MihailNacev_ITLab3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)

                lblTime.Text = DateTime.Now.ToString();

        }

        protected void btnTIme_Click(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToString();
        }
    }
}