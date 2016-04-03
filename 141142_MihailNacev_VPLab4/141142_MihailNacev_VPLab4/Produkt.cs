using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141142_MihailNacev_VPLab4
{
    public class Produkt
    {
        public string ime { get; set; }
        public string kategorija { get; set; }
        public double cena { get; set; }

        public Produkt(string ime, string kategorija, double cena)
        {
            this.ime = ime;
            this.kategorija = kategorija;
            this.cena = cena;
        }

        override
        public string ToString()
        {
            return ime;
        }
    }
}
