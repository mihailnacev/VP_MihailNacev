using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Airports
{
    public partial class AddAirport : Form
    {
        public Airport airp;
        public AddAirport()
        {
            InitializeComponent();
        }

        private void tbGrad_Validating(object sender, CancelEventArgs e)
        {
            if (tbGrad.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbGrad,"Внесете град!");
            }
            else
            {
                errorProvider1.SetError(tbGrad, null);
            }
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbIme, "Внесете име!");
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
            }
        }

        private void tbKratenka_Validating(object sender, CancelEventArgs e)
        {
            if (tbKratenka.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbKratenka, "Внесете кратенка!");
            }
            else
            {
                errorProvider1.SetError(tbKratenka, null);
            }
        }

        private void btnZacuvaj_Click(object sender, EventArgs e)
        {
            airp = new Airport(tbIme.Text,tbGrad.Text,tbKratenka.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
