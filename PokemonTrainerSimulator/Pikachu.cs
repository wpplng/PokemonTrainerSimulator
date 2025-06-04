using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    public class Pikachu : ElectricPokemon
    {
        // Constructor for Pikachu that sets the Type to Electric and initializes the base class
        public Pikachu(string name, int level, List<Attack> attacks) : base(name, level, attacks) { }
    }
}
