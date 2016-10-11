using PokeSharp.Pokemon;
using System;

namespace PokeSharp.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var settings = new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented,
            };

            /*
            var pokedex = new PokeDex();
            pokedex.Abilities.Add(new Ability());
            pokedex.Natures.Add(new NatureId());
            pokedex.Pokemons.Add(new BasePokemon());
            pokedex.Types.Add(new PokemonType());
            pokedex.MoveIds.Add(new Move(pokedex.Types[0]));
            pokedex.MoveIds[0].Effects.Add(new DoDamage());

            using (var file = File.CreateText("pokemon.json"))
            {
                file.Write(JsonConvert.SerializeObject(pokedex, settings));
            }

            PokeDex pokedex;

            using (var file = File.OpenText("pokedex.json"))
            {
                pokedex = JsonConvert.DeserializeObject<PokeDex>(file.ReadToEnd(), settings);
            }

            var pokemon = pokedex.MakePokemonInstance(pokedex.Pokemons[0]);
            */
        }
    }
}
