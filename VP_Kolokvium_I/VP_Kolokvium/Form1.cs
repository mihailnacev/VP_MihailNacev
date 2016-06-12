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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Student s = new Student("James","LeBron","123234");
            lbStudenti.Items.Add(s);
            s = new Student("Bryant", "Cobe", "144332");
            lbStudenti.Items.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent forma = new AddStudent();
            if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                lbStudenti.Items.Add(forma.referenca);
            }
        }

        private void btnIzbrisiS_Click(object sender, EventArgs e)
        {
            if (lbStudenti.SelectedItem != null) {
                DialogResult result = MessageBox.Show("Дали сакате да го избришете тековниот студент?","Прашалник",MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Student pom = lbStudenti.SelectedItem as Student;
                    lbStudenti.Items.Remove(pom);
                }
            }
        }

        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            if (lbStudenti.SelectedItem != null) {
                Student s = lbStudenti.SelectedItem as Student;
                Random rand=new Random();
                for (int i = 0; i < nudBrojac.Value; i++)
                    s.lista.Add(new Predmet((i + 1), rand.Next(5,11)));
                lbPredmeti.Items.Clear();
                foreach (Predmet p in s.lista) {
                    lbPredmeti.Items.Add(p);
                }
            
            }

            try
            {
                if (lbPredmeti.Items.Count > 0) {
                    tbProsek.Text = string.Format("{0:0.00}", average()); 
                    tbPolozeni.Text = string.Format("{0}", polozeniPredmeti());
                }
                else
                {
                    tbProsek.Text = "";
                    tbPolozeni.Text = "";
                }
                    
            }
            catch (Exception) { }
        }

        private void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStudenti.SelectedIndex !=-1)
            {
                lbPredmeti.Items.Clear();
                Student s = lbStudenti.SelectedItem as Student;
                foreach (Predmet p in s.lista)
                {
                    lbPredmeti.Items.Add(p);
                }

            }

            try
            {
                if (lbPredmeti.Items.Count > 0)
                {
                    tbProsek.Text = average().ToString();
                    tbPolozeni.Text = polozeniPredmeti().ToString();
                }

            }
            catch (Exception) { }
        }

        public double average() {
            double brojac = 0;
            double suma = 0;
            foreach (object ob in lbPredmeti.Items) {
                Predmet p = ob as Predmet;
                if (p.ocena > 5)
                {
                    suma += p.ocena;
                    brojac++;
                }
            }
            return suma / brojac;
        
        }

        public int polozeniPredmeti() {
            int brojac = 0;
            foreach (object ob in lbPredmeti.Items)
            {
                Predmet p = ob as Predmet;
                if(p.ocena>5) brojac++;
            }
            return brojac;
        
        }

        private void lbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStudenti.SelectedIndex != -1)
            {
                lbPredmeti.Items.Clear();
                Student s = lbStudenti.SelectedItem as Student;
                foreach (Predmet p in s.lista)
                {
                    lbPredmeti.Items.Add(p);
                }

            }

            try
            {
                if (lbPredmeti.Items.Count > 0)
                {
                    tbProsek.Text = string.Format("{0:0.00}", average());
                    tbPolozeni.Text = string.Format("{0}", polozeniPredmeti());
                }
                else {
                    tbProsek.Text = "";
                    tbPolozeni.Text = "";
                }

            }
            catch (Exception) { }
        }
    }
}
