using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _141142_MihailNacev_VPLab5
{
    public partial class Form1 : Form
    {
        public int vreme { get; set; }
        public Equation ravenka;
        public int poeni { get; set; }
        public List<Igrach> lista;
        public Form1()
        {
            InitializeComponent();
            lista = new List<Igrach>();
            vreme = 60;
            poeni = 0;
            lblVreme.Text = string.Format("00:{0:00}",vreme);
            lblPoeni.Text = poeni.ToString();
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar2.Value = vreme;
            Random r = new Random();
            int operacija = r.Next(1, 5);
            if (operacija == 1)
            {
                int operand1 = r.Next(1, 100);
                int operand2 = r.Next(1, 100);
                ravenka = new Equation(operand1, operand2, '+');
            }
            if (operacija == 2)
            {
                int operand1 = r.Next(1, 100);
                int operand2 = r.Next(1, 100);
                ravenka = new Equation(operand1, operand2, '*');
            }

            if (operacija == 3)
            {
                int operand1 = r.Next(1, 100);
                int operand2 = r.Next(1, 100);
                while (operand1 < operand2)
                {
                    operand1 = r.Next(1, 100);
                    operand2 = r.Next(1, 100);
                }
                ravenka = new Equation(operand1, operand2, '-');
            }

            if (operacija == 4)
            {
                int operand1 = r.Next(1, 100);
                int operand2 = r.Next(1, 100);
                while (operand1%operand2!=0 || operand1<operand2)
                {
                    operand1 = r.Next(1, 100);
                    operand2 = r.Next(1, 100);
                }
                ravenka = new Equation(operand1, operand2, '/');
            }

            tbOperand1.Text = ravenka.Operand1.ToString();
            tbOperand2.Text = ravenka.Operand2.ToString();
            tbOperator.Text = ravenka.Operacija.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                if (vreme > 0)
                {
                    vreme--;
                    progressBar2.Value = vreme;
                    lblVreme.Text = string.Format("00:{0:00}", vreme);
                }
                else
                {
                    timer1.Stop();
                    lista.Add(new Igrach(tbIme.Text, poeni));
                    vreme = 60;
                    poeni = 0;
                    progressBar1.Value = 0;
                    tbOperand1.Text = "";
                    tbOperand2.Text = "";
                    tbOperator.Text = "";
                    tbRezultat.Text = "";
                    lblPoeni.Text = "";
                }
            }
        }

        private void btnPogodi_Click(object sender, EventArgs e)
        {

            if (tbRezultat.Text != "")
            {
                int pogodenaVrednost = Convert.ToInt16(tbRezultat.Text);
                if (pogodenaVrednost == ravenka.Rezultat)
                {
                    poeni++;
                    lblPoeni.Text = poeni.ToString();
                    progressBar1.Value = poeni;
                    Random r = new Random();
                    int operacija = r.Next(1, 4);
                    if (operacija == 1)
                    {
                        int operand1 = r.Next(1, 100);
                        int operand2 = r.Next(1, 100);
                        ravenka = new Equation(operand1, operand2, '+');
                    }
                    if (operacija == 2)
                    {
                        int operand1 = r.Next(1, 100);
                        int operand2 = r.Next(1, 100);
                        ravenka = new Equation(operand1, operand2, '*');
                    }

                    if (operacija == 3)
                    {
                        int operand1 = r.Next(1, 100);
                        int operand2 = r.Next(1, 100);
                        while (operand1 < operand2)
                        {
                            operand1 = r.Next(1, 100);
                            operand2 = r.Next(1, 100);
                        }
                        ravenka = new Equation(operand1, operand2, '-');
                    }

                    if (operacija == 4)
                    {
                        int operand1 = r.Next(1, 100);
                        int operand2 = r.Next(1, 100);
                        while (operand1 % operand2 != 0 || operand1 < operand2)
                        {
                            operand1 = r.Next(1, 100);
                            operand2 = r.Next(1, 100);
                        }
                        ravenka = new Equation(operand1, operand2, '/');
                    }

                    tbOperand1.Text = ravenka.Operand1.ToString();
                    tbOperand2.Text = ravenka.Operand2.ToString();
                    tbOperator.Text = ravenka.Operacija.ToString();
                  
                }
            }
            
        }

        private void btnIgraci_Click(object sender, EventArgs e)
        {
            lista = lista.OrderByDescending(x => x.Poeni).ToList();
            StringBuilder sb = new StringBuilder();
            foreach(Igrach igrach in lista)
            {
                sb.Append(igrach.ToString());
            }
            MessageBox.Show(sb.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
