using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141142_MihailNacev_VPLab5
{
    public class Equation
    {
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        public char Operacija { get; set; }
        public int Rezultat { get; set; }

        public Equation(int operand1,int operand2,char operacija)
        {
            Operand1 = operand1;
            Operand2 = operand2;
            Operacija = operacija;
            Rezultat = presmetajRezultat();
        }

        public int presmetajRezultat()
        {
            if (Operacija == '+') return Operand1 + Operand2;
            if (Operacija == '*') return Operand1 * Operand2;
            if (Operacija == '-') return Operand1 - Operand2;
            if (Operacija == '/') return Operand1 / Operand2;
            return 0;
        }
    }
}
