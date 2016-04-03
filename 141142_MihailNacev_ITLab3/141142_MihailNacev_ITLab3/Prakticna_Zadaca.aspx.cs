using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _141142_MihailNacev_ITLab3
{
    public partial class Prakticna_Zadaca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                //dataSource
                string[] vrednosti = { "Јануари", "Февруари", "Март", "Април","Мај","Јуни","Јули","Август","Септември","Октомври","Ноември","Декември"};
                ddlMesec.DataSource = vrednosti;
                ddlMesec.DataBind();
                //dinamicko popolnuvanje na ddlDen
                for (int i = 1; i <= 31; i++)
                {
                    ListItem li = new ListItem(i.ToString());
                    ddlDen.Items.Add(li);
                }
                //dinamicko popolnuvanje na ddlGodina
                for (int i = 2016; i >= 2010; i--) {
                    ListItem li = new ListItem(i.ToString());
                    ddlGodina.Items.Add(li);
                }
                //dinamicko popolnuvanje na ddlCas
                for(int i = 0; i < 24; i++)
                {
                    ListItem li = new ListItem();
                    if (i < 10)
                        li.Text = String.Format("0{0}:00", i);
                    else
                        li.Text = String.Format("{0}:00", i);
                    ddlVreme.Items.Add(li);
                }

            }
        }

        protected void btnPodnesi_Click(object sender, EventArgs e)
        {
            try {
                lblPatnik.Text = txtIme.Text + " " + txtPrezime.Text;
                lblOd.Text = ddlOd.SelectedItem.Text;
                lblDo.Text = ddlDo.SelectedItem.Text;
                lblSredstvo.Text = lstSredstvo.SelectedItem.Text;
                lblZona.Text = rblZona.SelectedItem.Text;
                lblKlasa.Text = rblKlasa.SelectedItem.Text;
                lblVreme.Text = ddlDen.SelectedItem.Text + "." + ddlMesec.SelectedItem.Text + "." + ddlGodina.SelectedItem.Text + " во " + ddlVreme.SelectedItem.Text + " часот";
                lblPosluga.Text = "";
                foreach (ListItem li in cblPosluga.Items) {
                    if (li.Selected) {
                        lblPosluga.Text += (li.Text + " ");
                    }
                }
                imgSlika.ImageUrl = lstSredstvo.SelectedItem.Value;
                if (rblZona.SelectedIndex != -1 && rblKlasa.SelectedIndex != -1 && cblPosluga.SelectedIndex != -1)
                    pnlPanela.Visible = true;
            }
            catch(NullReferenceException) { }


        }
    }
}