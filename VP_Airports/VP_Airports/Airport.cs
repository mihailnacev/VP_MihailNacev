using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Airports
{
    public class Airport
    {
        public string grad { get; set; }
        public string ime { get; set; }
        public string kratenka { get; set; }
        public List<Destination> lista;

        public Airport(string grad, string ime, string kratenka) {
            this.grad = grad;
            this.ime = ime;
            this.kratenka = kratenka;
            this.lista = new List<Destination>();
        }

        override
        public string ToString()
        {
            return String.Format("{0} - {1} - {2}",kratenka,ime,grad);
        }
    }
}
