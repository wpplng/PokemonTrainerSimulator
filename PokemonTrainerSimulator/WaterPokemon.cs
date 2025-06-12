using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    public abstract class WaterPokemon : Pokemon
    {
        // Constructor for WaterPokemon that sets the Type to Water
        public WaterPokemon(string name, int level, List<Attack> attacks) : base(name, level, attacks) 
        {
            Type = ElementType.Water;
        }
    }
}
