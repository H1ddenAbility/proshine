using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROProtocol
{
    public class PokemonSpawn
    {
        public string name { get; set; }
        public bool fish { get; set; }
        public bool surf { get; set; }
        public bool hitem { get; set; }
        public bool msonly { get; set; }
        public bool captured { get; set; }

        internal PokemonSpawn(int id, bool captured, bool surf, bool fish, bool hitem, bool msonly )
        {
            name = PokemonNamesManager.Instance.Names[id];
            this.surf = surf;
            this.fish = fish;
            this.hitem = hitem;
            this.msonly = msonly;
            this.captured = captured;
        }
    }
}
