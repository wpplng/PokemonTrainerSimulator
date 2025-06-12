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

            // Initialize legendary attacks
            LegendaryAttack legendaryFlamethrower = new LegendaryAttack(flamethrower);
            LegendaryAttack legendaryWaterGun = new LegendaryAttack(waterGun);
            LegendaryAttack legendaryThunder = new LegendaryAttack(thunder);

            // Create instances of each Pokemon with their respective attacks
            Charmander charmander = new Charmander(10, new List<Attack> { flamethrower, inferno, legendaryFlamethrower });
            Squirtle squirtle = new Squirtle(3, new List<Attack> { waterGun, bubble, legendaryWaterGun });
            Pikachu pikachu = new Pikachu(4, new List<Attack> { thunder, spark, legendaryThunder });

            // Create a list of Pokemons to simulate
            List<Pokemon> pokemons = new List<Pokemon> { charmander, squirtle, pikachu };

            // Run the simulation for each Pokemon
            for (int i = 0; i < pokemons.Count; i++)
            {
                var updatedPokemon = pokemons[i].RaiseLevel();
                updatedPokemon.Speak();
                updatedPokemon.Attack();
                pokemons[i] = updatedPokemon; // if Pokemon evolves, change the reference in the list
                Console.WriteLine();
            }
        }
    }
}


