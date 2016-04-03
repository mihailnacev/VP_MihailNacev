using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _141142_MihailNacev_ITLab3
{
    public partial class Logiranje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtPoraka_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnProveri_Click(object sender, EventArgs e)
        {
            if (txtLozinka.Text.Equals("интернет технологии"))
            {
                txtPoraka.Focus();
                btnPrvaStrana.Enabled = true;
            }
            else {
                txtPoraka.Text = "Грешка !!! ";
                btnPrvaStrana.Enabled = true;
            }
        }
    }
}