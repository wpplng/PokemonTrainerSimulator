using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    public class Attack
    {
        // Properties for attack name, type, and base power
        public string Name { get; }
        public ElementType Type { get; }
        public int BasePower { get; }

        // Constructor to initialize the attack properties
        public Attack(string name, ElementType type, int basePower)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Type = type;
            BasePower = basePower;
        }

        // Method to simulate using the attack
        public virtual void Use(int level)
        {
            int totalPower = BasePower + level;
            Console.WriteLine($"{Name} hits with total power {totalPower}.");
        }
    }
}
