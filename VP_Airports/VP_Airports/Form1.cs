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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Airport a = new Airport("SKP", "Александар Велики", "Скопје");
            lbAerodromi.Items.Add(a);
            a = new Airport("BAR","Ел Прат","Барселона");
            lbAerodromi.Items.Add(a);
            a = new Airport("VIE", "Виеана ИА", "Виена");
            lbAerodromi.Items.Add(a);
            a = new Airport("IST", "Ататурк ИА", "Истанбул");
            lbAerodromi.Items.Add(a);
        }

        private void btnDodadiAerodrom_Click(object sender, EventArgs e)
        {
            AddAirport forma = new AddAirport();
            if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbAerodromi.Items.Add(forma.airp);
            }
        }

        private void btnDodadiDestinacija_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            if(form.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                if (lbAerodromi.SelectedItem!=null)
                {
                    Airport airport = lbAerodromi.SelectedItem as Airport;
                    airport.lista.Add(form.dest);
                    foreach (Destination d in airport.lista)
                    {
                        lbDestinacii.Items.Add(d);
                    }
                }
            }
            try
            {
                tbNajskapa.Text = najskapaDestinacija().ToString();
                tbProsecna.Text = string.Format("{0:0.00}", prosecnaDolzina());
            }
            catch (Exception) { }
        }

        private Destination najskapaDestinacija()
        {
            Destination temp = lbDestinacii.Items[0] as Destination;
            foreach(object ob in lbDestinacii.Items)
            {
                Destination tekovno = ob as Destination;
                if (tekovno.cena >= temp.cena) temp = tekovno;
            }
            return temp;
        }
        private double prosecnaDolzina()
        {
            double zbir = 0;
            foreach (object ob in lbDestinacii.Items)
            {
                Destination d = ob as Destination;
                zbir += d.dolzina;
            }
            return zbir / (double)lbDestinacii.Items.Count;
        }

        private void btnIzbrisiAerodrom_Click(object sender, EventArgs e)
        {
           /* if (lbAerodromi.SelectedItem != null)
            {
                try
                {
                    lbAerodromi.Items.RemoveAt(lbAerodromi.SelectedIndex);
                }
                catch (Exception) { }
            }
            else
            {
                MessageBox.Show("Не селектиравте аеродром!");
            }
            */
        }

        private void lbAerodromi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAerodromi.SelectedIndex != -1)
            {
                Airport airport = lbAerodromi.SelectedItem as Airport;
                lbDestinacii.Items.Clear();
                foreach(Destination d in airport.lista)
                {
                    lbDestinacii.Items.Add(d);
                }
            }
            try {
                tbNajskapa.Text = najskapaDestinacija().ToString();
                tbProsecna.Text = string.Format("{0:0.00}", prosecnaDolzina());
            }
            catch (Exception) { }
        }
    }
}
