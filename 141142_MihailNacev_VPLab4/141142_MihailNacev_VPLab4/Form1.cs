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
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            lstLista.Items.Add(new Produkt("Месо","Прехрана",200));
            lstLista.Items.Add(new Produkt("Млеко", "Прехрана", 50));
            lstLista.Items.Add(new Produkt("Вино", "Пијалоци", 220));
            lstLista.Items.Add(new Produkt("Пиво", "Пијалоци", 100));
            lstLista.Items.Add(new Produkt("Шампон", "Хигиена", 150));
            lstLista.Items.Add(new Produkt("Паста за заби", "Хигиена", 120));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NovProdukt form2 = new NovProdukt();
            if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lstLista.Items.Add(form2.produkt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата со продукти?", "Испразни ја листата?",
               MessageBoxButtons.YesNo, // vid na dijalogot 
               MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                lstLista.Items.Clear();
                tbPole1.Text = "";
                tbPole2.Text = "";
                tbPole3.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошничката со продукти?", "Испразни ја кошничката?",
               MessageBoxButtons.YesNo, // vid na dijalogot 
               MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                lstKosnicka.Items.Clear();
                calculateTotal();
            }
        }

        private void btnDodadiKosnicka_Click(object sender, EventArgs e)
        {
            try
            {
                Produkt produkt = (Produkt)lstLista.SelectedItem;
                double kolicina = (double)Kolicina.Value;
                ProductItem p = new ProductItem(produkt,kolicina);
                lstKosnicka.Items.Add(p);
                calculateTotal();
            }
            catch(Exception){ }
        }

        private void btnIzbrisiKosnicka_Click(object sender, EventArgs e)
        {
            try
            {
                ProductItem p = lstKosnicka.SelectedItem as ProductItem;
                lstKosnicka.Items.Remove(p);
                calculateTotal();
            }
            catch (Exception) { }
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produkt p = lstLista.SelectedItem as Produkt;
            tbPole1.Text = p.ime;
            tbPole2.Text = p.kategorija;
            tbPole3.Text = String.Format("{0:0.00}", p.cena);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                Produkt p = lstLista.SelectedItem as Produkt;
                lstLista.Items.Remove(p);
            }
            catch (Exception){ }
        }

        public void calculateTotal()
        {
            double vkupno = 0;
            foreach (Object item in lstKosnicka.Items)
            {
                ProductItem prod = item as ProductItem;
                vkupno += (prod.kolicina * prod.prod.cena);
            }
            tbVkupno.Text = String.Format("{0:0.00}",vkupno);
        }
        private void tbVkupno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
