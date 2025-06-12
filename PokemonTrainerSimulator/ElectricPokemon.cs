using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    public abstract class ElectricPokemon : Pokemon
    {
        // Constructor for ElectricPokemon that sets the Type to Electric
        public ElectricPokemon(string name, int level, List<Attack> attacks) : base(name, level, attacks) 
        {
            Type = ElementType.Electric;
        }
    }
}
