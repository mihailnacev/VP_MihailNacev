using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_SportsBet
{
    public class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public Team(string Name,string Country)
        {
            this.Name = Name;
            this.Country = Country;
        }

        override
        public string ToString()
        {
            return String.Format("{0}- {1}", Name,Country);
        }
    }
}
