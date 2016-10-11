using System;
using System.Collections.Generic;

namespace PokeSharp.Pokemon
{
    /// <summary>
    /// A data type for the base data of a pokemon.
    /// </summary>
    public class BasePokemon
    {
        /// <summary>
        /// The pokemons name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The pokemons title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The desciption of the pokemon.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The base stats of the pokemon.
        /// </summary>        
        public int[] BaseStats { get; set; } = new int[6];
        
        /// <summary>
        /// The pokemons types.
        /// </summary>
        public List<int> Types { get; set; } = new List<int>();
        
        /// <summary>
        /// The pokemons evolutions.
        /// </summary>
        public List<Evolution> Evolutions { get; set; } = new List<Evolution>();


        /// <summary>
        /// The moves the pokemon can learn.
        /// </summary>
        public List<LearnableMove> LearnableMoves { get; set; } = new List<LearnableMove>();
    }
}
