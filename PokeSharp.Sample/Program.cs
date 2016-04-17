using Newtonsoft.Json;
using PokeSharp.Pokemon;
using PokeSharp.Pokemon.Effects;
using System;
using System.IO;
using Utility;

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
            pokedex.Natures.Add(new Nature());
            pokedex.Pokemons.Add(new BasePokemon());
            pokedex.Types.Add(new PokemonType());
            pokedex.Moves.Add(new Move(pokedex.Types[0]));
            pokedex.Moves[0].Effects.Add(new DoDamage());

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

            var dex = PokeDex.GenerateRandom();
            
            Console.WriteLine("---Types---");
            Console.Write("{0, 6}", "VD A>");
            foreach (var type in dex.Types)
            {
                Console.Write("|{0, 6}", type.Name);
            }
            Console.WriteLine();

            foreach (var type in dex.Types)
            {
                Console.Write("{0, 6}", type.Name);

                foreach (var effect in type.Effectiveness)
                {
                    Console.Write("|{0, 6:N1}", effect.Value);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("---Pokemons---");
            foreach (var pokemon in dex.Pokemons)
            {
                Console.WriteLine("<{0}>", pokemon.Name);
                Console.WriteLine("\tTitle: {0}", pokemon.Title);
                Console.WriteLine("\tDescription: {0}", pokemon.Description);
                Console.WriteLine("\tStats: {0}", pokemon.BaseStats);
            }

            Console.ReadKey();
        }
    }
}
