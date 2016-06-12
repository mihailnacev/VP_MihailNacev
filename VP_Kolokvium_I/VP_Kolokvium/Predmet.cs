using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VP_Kolokvium
{
    public class Predmet
    {
        public int rBr;
        public int ocena;

        public Predmet(int rBr, int ocena) 
        {
            this.rBr = rBr;
            this.ocena = ocena;
        }

        public override string ToString()
        {
            return "Предмет " + rBr+" ("+ocena+")";
        }
    }
}
