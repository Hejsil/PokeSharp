using PokeSharp.Pokemon.Effects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokeSharp.Pokemon
{
    /// <summary>
    /// A data type reprecenting a pokedex. The pokedex contains all infomation about the pokemon world.
    /// </summary>
    public class PokeDex
    {
        /// <summary>
        /// All types in the pokedex.
        /// </summary>
        public double[,] TypeTable { get; set; }

        /// <summary>
        /// All natures in the pokedex.
        /// </summary>
        public double[,] NatureTable { get; set; }

        /// <summary>
        /// All moves in the pokedex.
        /// </summary>
        public List<Move> Moves { get; set; } = new List<Move>();

        /// <summary>
        /// All pokemons in the pokedex.
        /// </summary>
        public List<BasePokemon> Pokemons { get; set; } = new List<BasePokemon>();

        public Pokemon MakePokemonInstance(int pokemonId, int level = 1, int[] ivs = null, int[] evs = null)
        {
            throw new NotImplementedException();
        }


        private const int immuneChance = 10;
        private const int resistChance = 25;
        private const int weakChance = 25;
        private const int normalChance = 40;
        public static PokeDex GenerateRandom()
        {
            throw new NotImplementedException();
        }
    }
}
