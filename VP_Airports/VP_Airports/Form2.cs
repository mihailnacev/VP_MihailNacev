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
    public partial class Form2 : Form
    {
        public Destination dest;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            dest = new Destination(tbIme.Text,Convert.ToInt32(nudDolzina.Value),Convert.ToInt32(nudCena.Value));
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
