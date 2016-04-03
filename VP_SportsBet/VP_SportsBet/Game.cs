using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_SportsBet
{
    public class Game
    {
        public Team homeTeam { get; set; }
        public Team guestTeam { get; set; }
        public double[] Coeff { get; set; }
        public string code { get; set; }

        public Game() { Coeff = new double[3]; }

        override
        public string ToString()
        {
            return String.Format("{0}: {1}-{2} {3:0.00} {4:0.00} {5:0.00}",code,homeTeam.Name,guestTeam.Name,Coeff[0],Coeff[1],Coeff[2]);
        }
    }
}
