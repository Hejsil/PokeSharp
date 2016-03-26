using System.Collections.Generic;

namespace PokeSharp.PokeDex
{
    /// <summary>
    /// A data type reprecenting a pokedex. The pokedex contains all infomation about the pokemon world.
    /// </summary>
    public class PokeDex
    {
        /// <summary>
        /// All pokemons in the pokedex.
        /// </summary>
        public List<BasePokemon> Pokemons { get; set; }

        /// <summary>
        /// All moves in the pokedex.
        /// </summary>
        public List<Move> Moves { get; set; }

        /// <summary>
        /// All natures in the pokedex.
        /// </summary>
        public List<Nature> Natures { get; set; }

        /// <summary>
        /// All types in the pokedex.
        /// </summary>
        public List<PokemonType> Types { get; set; }

        /// <summary>
        /// All the abilities in the pokedex.
        /// </summary>
        public List<Ability> Abilities { get; set; }
    }
}
