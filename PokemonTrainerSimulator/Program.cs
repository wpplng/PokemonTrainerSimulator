using System;

namespace PokemonTrainerSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize attacks for each ElementType
            Attack flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            Attack inferno = new Attack("Inferno", ElementType.Fire, 6);
            Attack waterGun = new Attack("Water Gun", ElementType.Water, 10);
            Attack bubble = new Attack("Bubble", ElementType.Water, 5);
            Attack thunder = new Attack("Thunder", ElementType.Electric, 15);
            Attack spark = new Attack("Spark", ElementType.Electric, 8);

            // Create instances of each Pokemon with their respective attacks
            Charmander charmander = new Charmander(5, new List<Attack> { flamethrower, inferno });
            Squirtle squirtle = new Squirtle(3, new List<Attack> { waterGun, bubble });
            Pikachu pikachu = new Pikachu(4, new List<Attack> { thunder, spark });

            // Create a list of Pokemons to simulate
            List<Pokemon> pokemons = new List<Pokemon> { charmander, squirtle, pikachu };

            // Run the simulation for each Pokemon
            foreach (var pokemon in pokemons)
            {
                pokemon.RaiseLevel();
                pokemon.Attack();

                if (pokemon is IEvolvable evolvable)
                {
                    evolvable.Evolve();
                }

                Console.WriteLine();
            }
        }
    }
}


