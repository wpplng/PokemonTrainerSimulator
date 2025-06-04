using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    public class Squirtle : WaterPokemon
    {
        // Constructor for Squirtle that sets the Type to Water and initializes the base class
        public Squirtle(int level, List<Attack> attacks) : base("Squirtle", level, attacks) { }

    }
}
