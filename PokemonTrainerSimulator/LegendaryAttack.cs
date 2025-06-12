using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    public class LegendaryAttack : Attack
    {
        // Constructor for LegendaryAttack that initializes the base class with specific values
        public LegendaryAttack(Attack baseAttack) 
            : base("Legendary" + baseAttack.Name, baseAttack.Type, baseAttack.BasePower)
        {
        }
        // Override the Use method to provide a unique implementation for LegendaryAttack
        public override void Use(int level)
        {
            int totalPower = BasePower + (level * 2); // Increased power based on level
            Console.WriteLine($"{Name} unleashes a legendary strike with total power {totalPower}!");
        }
    }
}
