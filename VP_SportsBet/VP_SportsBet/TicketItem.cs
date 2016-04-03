using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_SportsBet
{
    public class TicketItem
    {
        public Game game { get; set; }
        public int tip { get; set; }

        public TicketItem() { }

        override
        public String ToString()
        {
            return string.Format("{0}: {1} {2} {3:0.00}", game.code, game.homeTeam.Name, game.guestTeam.Name, game.Coeff[tip]);
        }
    }
}
