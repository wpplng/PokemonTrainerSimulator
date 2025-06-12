using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    // Abstract class representing a Pokemon, that cannot be instantiated directly
    public abstract class Pokemon
    {
        // Private fields to store name and level
        private string _name = string.Empty;
        private int _level;

        // Properties for Name and Level with validation
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 2 || value.Length > 15)
                    throw new ArgumentException("Name must be between 2 and 15 characters.");
                _name = value;
            }
        }
        public int Level
        {
            get => _level;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Level must be at least 1.");
                _level = value;
            }
        }
        // Property for Type, to be set by derived classes
        public ElementType Type { get; protected set; }
        // Property for Attacks, initialized in the constructor
        public List<Attack> Attacks { get; }

        // Constructor to initialize Name, Level, and Attacks
        public Pokemon(string name, int level, List<Attack> attacks)
        {
            Name = name;
            Level = level;
            Attacks = attacks ?? new List<Attack>();
        }

        // Method to choose an attack randomly
        public void RandomAttack()
        {
            Random random = new Random();
            int index = random.Next(Attacks.Count);
            Attacks[index].Use(Level);
        }

        // Method to display available attacks and let the user choose one
        public void Attack()
        {
            Console.WriteLine($"{Name}'s available attacks:");
            for (int i = 0; i < Attacks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Attacks[i].Name} ({Attacks[i].Type})");
            }

            Console.Write("Choose an attack (number): ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= Attacks.Count)
            {
                Attacks[choice - 1].Use(Level);
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }

        // Method to raise the level of the Pokemon that can be overridden by derived classes
        public virtual Pokemon RaiseLevel()
        {
            Level++;
            Console.WriteLine($"{Name} leveled up to {Level}!");
            return this;
        }

        // Method to simulate speaking, to be overridden by derived classes
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes a generic Pokemon sound!");
        }
    }
}
