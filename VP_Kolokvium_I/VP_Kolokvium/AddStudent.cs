using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VP_Kolokvium
{
    public partial class AddStudent : Form
    {
        public Student referenca;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            referenca = new Student(tbIme.Text, tbPrezime.Text, tbIndeks.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
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
                errorProvider1.SetError(tbIme, "Внесете име!");
            }
            else { 
              errorProvider1.SetError(tbIme,null);
            }
        }

        private void tbPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrezime.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPrezime, "Внесете презиме!");
            }
            else
            {
                errorProvider1.SetError(tbPrezime, null);
            }
        }

        private void tbIndeks_Validating(object sender, CancelEventArgs e)
        {
            if (tbIndeks.Text.Trim().Length !=6)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbIndeks, "Внесете индекс во правилен формат!");
            }
            else
            {
                errorProvider1.SetError(tbIndeks, null);
            }
        }
    }
}
