using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Airports
{
    public class Destination
    {
        public string ime { get; set; }
        public Int32 dolzina { get; set; }
        public Int32 cena { get; set; }

        public Destination(string ime, Int32 dolzina, Int32 cena)
        {
            this.ime = ime;
            this.dolzina = dolzina;
            this.cena = cena;
        }

        override
        public string ToString()
        {
            return string.Format("{0} {1} km - {2} EUR",ime,dolzina,cena);
        }
    }
}
