using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROProtocol
{
    public class PokedexPokemon
    {
        // 1: Seen | 2 : Captured | 3 : Obtained by evolving
        int id { get;  set; }
        string name { get;  set; }

        internal PokedexPokemon(int id, int pokeid)
        {
            this.id = id;
            name = PokemonNamesManager.Instance.Names[pokeid];
        }

        public override string ToString()
        {
            return name;
        }

        public bool isCaught()
        {
            return (id == 2 || id == 3);
        }
    }
}
