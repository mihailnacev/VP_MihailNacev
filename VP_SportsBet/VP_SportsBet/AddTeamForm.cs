using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_SportsBet
{
    public partial class AddTeamForm : Form
    {
        public Team team;
        public AddTeamForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            team = new Team(tbIme.Text,tbDrzava.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbIme, "Внесете име на тим!");
            }
            else {
                errorProvider1.SetError(tbIme, null);
            }
        }

        private void tbDrzava_Validating(object sender, CancelEventArgs e)
        {
            if (tbDrzava.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbDrzava, "Внесете држава!");
            }
            else {
                errorProvider1.SetError(tbDrzava, null);
            }
        }
    }
}
