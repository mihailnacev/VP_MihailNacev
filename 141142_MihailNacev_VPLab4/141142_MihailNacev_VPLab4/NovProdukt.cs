using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _141142_MihailNacev_VPLab4
{
    public partial class NovProdukt : Form
    {
        public Produkt produkt { get; set; }
        public NovProdukt()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Внесете име!");
            }
            else
            {
                tbCategory.Focus();
                errorProvider1.SetError(tbName, null);
            }
        }

        private void tbCategory_Validating(object sender, CancelEventArgs e)
        {
            if (tbCategory.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCategory, "Внесете категорија!");
            }
            else
            {
                errorProvider1.SetError(tbCategory, null);
                tbPrice.Focus();
            }
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrice.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPrice, "Внесете цена!");
            }
            else
            {
                errorProvider1.SetError(tbPrice, null);
                tbPrice.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if(tbName.Text.Length>0&& tbCategory.Text.Length>0&& tbPrice.Text.Length > 0)
            {
                produkt = new Produkt(tbName.Text, tbCategory.Text, Convert.ToDouble(tbPrice.Text));
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }

        }

    }
}
