using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141142_MihailNacev_VPLab4
{
    public class ProductItem
    {
        public Produkt prod { get; set; }
        public double kolicina { get; set; }

        public ProductItem(Produkt produkt,double kolicina)
        {
            this.prod = produkt;
            this.kolicina = kolicina;
        }

        override
        public string ToString()
        {
            return String.Format("{0} {1:0.0} x {2:0.0} = {3:0.00}",prod,kolicina,prod.cena,prod.cena * kolicina);
        }
    }
}
