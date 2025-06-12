
namespace PokemonTrainerSimulator
{
    public sealed class Charmeleon : FirePokemon
    {
        public Charmeleon(int level, List<Attack> attacks) : base("Charmeleon", level, attacks) { }

        // Override Speak method from Pokemon class
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Charmeleon!");
        }
    }
}