using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    public class Charmander : FirePokemon
    {
        // Constructor for Charmander that sets the Type to Fire and initializes the base class
        public Charmander(string name, int level, List<Attack> attacks) : base(name, level, attacks) { }

    }
}
