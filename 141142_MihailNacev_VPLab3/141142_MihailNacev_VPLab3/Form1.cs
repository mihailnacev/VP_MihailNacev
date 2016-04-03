using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _141142_MihailNacev_VPLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void calculateTotal()
        {
            // ... vasiot kod ovde ...
            float vkupno = 0;
            //zemanje na vrednosti od textBox-ovite i parsiranje
            float malaPica = 0;
            float.TryParse(MalaPica.Text, out malaPica);
            float srednaPica = 0;
            float.TryParse(SrednaPica.Text, out srednaPica);
            float golemaPica = 0;
            float.TryParse(GolemaPica.Text, out golemaPica);
            float feferonki = 0;
            float.TryParse(Feferonki.Text, out feferonki);
            float ekstraSirenje = 0;
            float.TryParse(EkstraSirenje.Text, out ekstraSirenje);
            float kecap = 0;
            float.TryParse(Kecap.Text, out kecap);
            float kolicinaKokaKola = 0;
            float.TryParse(KolicinaKokaKola.Text, out kolicinaKokaKola);
            float kolicinaSokOdJabolko = 0;
            float.TryParse(KolicinaSokOdJabolko.Text, out kolicinaSokOdJabolko);
            float kolicinaPivo = 0;
            float.TryParse(KolicinaPivo.Text, out kolicinaPivo);
            float cenaKokaKola = 0;
            float.TryParse(CenaKokaKola.Text, out cenaKokaKola);
            float cenaSokOdJabolko = 0;
            float.TryParse(CenaSokOdJabolko.Text, out cenaSokOdJabolko);
            float cenaPivo = 0;
            float.TryParse(CenaPivo.Text, out cenaPivo);
            float cenaDesert = 0;
            float.TryParse(CenaDesert.Text, out cenaDesert);
            float naplateno = 0;
            float.TryParse(Naplateno.Text, out naplateno);
            if (rbMala.Checked) vkupno += malaPica;
            if (rbSredna.Checked) vkupno += srednaPica;
            if (rbGolema.Checked) vkupno += golemaPica;
            if (cbFeferonki.Checked) vkupno += feferonki;
            if (cbEkstraSirenje.Checked) vkupno += ekstraSirenje;
            if (cbKecap.Checked) vkupno += kecap;
            vkupno += (kolicinaKokaKola * cenaKokaKola);
            vkupno += (kolicinaSokOdJabolko*cenaSokOdJabolko);
            vkupno += (kolicinaPivo*cenaPivo);
            vkupno += cenaDesert;
            vkupnoNaplata.Text = Convert.ToString(vkupno);
            vkKokaKola.Text = Convert.ToString(kolicinaKokaKola * cenaKokaKola);
            vkSokJabolko.Text = Convert.ToString(kolicinaSokOdJabolko * cenaSokOdJabolko);
            vkPivo.Text = Convert.ToString(kolicinaPivo * cenaPivo);
            ZaVrakanje.Text = Convert.ToString(naplateno-vkupno);
        }
        //postavuvanje na Eventite
        private void rbMala_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void rbSredna_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void rbGolema_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbFeferonki_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbEkstraSirenje_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbKecap_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void KolicinaKokaKola_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void KolicinaSokOdJabolko_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void KolicinaPivo_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void CenaKokaKola_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void CenaSokOdJabolko_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void CenaPivo_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void MalaPica_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void SrednaPica_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void GolemaPica_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void Feferonki_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void EkstraSirenje_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void Kecap_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0) CenaDesert.Text = "80";
            if (listBox1.SelectedIndex == 1) CenaDesert.Text = "120";
            if (listBox1.SelectedIndex == 2) CenaDesert.Text = "160";
            calculateTotal();

        }

        private void Naplateno_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (rbMala.Checked) sb.Append("Мала пица\n");
            if (rbSredna.Checked) sb.Append("Средна пица\n");
            if (rbGolema.Checked) sb.Append("Голема пица\n");
            if (cbFeferonki.Checked || cbEkstraSirenje.Checked || cbKecap.Checked) sb.Append("Додаток:\n");
            if (cbFeferonki.Checked) sb.Append("Феферони\n");
            if (cbEkstraSirenje.Checked) sb.Append("ЕкстраСирење\n");
            if (cbKecap.Checked) sb.Append("Кечап\n");
            if (Convert.ToDouble(KolicinaKokaKola.Text) >= 1) sb.Append(KolicinaKokaKola.Text + " " + "Кока кола\n");
            if (Convert.ToDouble(KolicinaSokOdJabolko.Text) >= 1) sb.Append(KolicinaSokOdJabolko.Text+" "+"Сок од јаболко\n");
            if (Convert.ToDouble(KolicinaPivo.Text) >= 1) sb.Append(KolicinaPivo.Text + " " + "Пиво\n");
            if (listBox1.SelectedIndex != -1) sb.Append("Десерт:\n");
            if (listBox1.SelectedIndex == 0) sb.Append("Овошна пита");
            if (listBox1.SelectedIndex == 1) sb.Append("Сладолед");
            if (listBox1.SelectedIndex == 2) sb.Append("Торта");
            MessageBox.Show(sb.ToString(), "Вашата нарачка",
                MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сакате да ја откажете нарачката?", "Откажи нарачка?",
                MessageBoxButtons.YesNo, // vid na dijalogot 
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
