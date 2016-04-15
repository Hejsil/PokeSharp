using Newtonsoft.Json;
using PokeSharp.Pokemon;
using PokeSharp.Pokemon.Effects;
using System.IO;

namespace PokeSharp.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented,
            };

            /*
            var pokedex = new PokeDex();
            pokedex.Abilities.Add(new Ability());
            pokedex.Natures.Add(new Nature());
            pokedex.Pokemons.Add(new BasePokemon());
            pokedex.Types.Add(new PokemonType());
            pokedex.Moves.Add(new Move(pokedex.Types[0]));
            pokedex.Moves[0].Effects.Add(new DoDamage());

            using (var file = File.CreateText("pokemon.json"))
            {
                file.Write(JsonConvert.SerializeObject(pokedex, settings));
            }
            */

            PokeDex pokedex;

            using (var file = File.OpenText("pokedex.json"))
            {
                pokedex = JsonConvert.DeserializeObject<PokeDex>(file.ReadToEnd(), settings);
            }
        }
    }
}
