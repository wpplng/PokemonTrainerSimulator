﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    public class Charmander : FirePokemon, IEvolvable
    {
        private int _evolveAtLevel = 11;
        // Constructor for Charmander that sets the Type to Fire and initializes the base class
        public Charmander(int level, List<Attack> attacks) : base("Charmander", level, attacks) { }

        // Implementation of the Evolve method from the IEvolvable interface
        public Pokemon Evolve()
        {
            Name = "Charmeleon";
            Level += 10;
            Console.WriteLine($"Charmander is evolving... Now it's {Name}! Level {Level}");
            return new Charmeleon(Level, Attacks);
        }

        // Override Speak method from Pokemon class
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Char!");
        }

        // Override RaiseLevel from Pokemon class
        public override Pokemon RaiseLevel()
        {
            base.RaiseLevel();
            if (Level >= _evolveAtLevel)
                return Evolve();
            return this;
        }
    }
}
