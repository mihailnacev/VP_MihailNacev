using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141142_MihailNacev_VPLab5
{
    public class Igrach
    {
        public string Ime { get; set; }
        public int Poeni { get; set; }

        public Igrach(string ime,int poeni)
        {
            Ime = ime;
            Poeni = poeni;
        }

        override
        public string ToString()
        {
            return Ime +" "+ Poeni + " поени"+"\n";
        }
    }
}
