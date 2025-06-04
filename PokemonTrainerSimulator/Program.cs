using System;

namespace PokemonTrainerSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Attack flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            Attack inferno = new Attack("Inferno", ElementType.Fire, 6);
            Attack waterGun = new Attack("Water Gun", ElementType.Water, 10);
            Attack bubble = new Attack("Bubble", ElementType.Water, 5);
            Attack thunder = new Attack("Thunder", ElementType.Electric, 15);
            Attack spark = new Attack("Spark", ElementType.Electric, 8);
        }
    }
}


