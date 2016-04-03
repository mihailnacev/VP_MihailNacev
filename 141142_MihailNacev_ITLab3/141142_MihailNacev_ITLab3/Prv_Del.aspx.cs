using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _141142_MihailNacev_ITLab3
{
    public partial class Prv_Del : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                for (int i = 1; i <= 24; i++)
                {
                    ListItem li = new ListItem(i.ToString());
                    cblLista.Items.Add(li);

                }
            }

        }

        protected void btnKopce_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            foreach (ListItem listItem in cblLista.Items)
            {
                if (listItem.Selected)
                {
                    brojac++;
                }
            }
            lblLabela.Text = brojac.ToString();
        }
    }
}