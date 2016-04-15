using PokeSharp.Utility;
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
        public int[] BaseStats
        {
            get { return _basestates; }
            set
            {
                Util.EnsureSize(value, 6);
                _basestates = value;
            }
        }
        private int[] _basestates = new int[6];


        /// <summary>
        /// The pokemons types.
        /// </summary>
        public PokemonType[] Types
        {
            get { return _types; }
            set
            {
                Util.EnsureSize(value, 2);
                _types = value;
            }
        }
        private PokemonType[] _types = new PokemonType[2];


        /// <summary>
        /// The abilities the pokemon can have.
        /// </summary>
        public List<Ability> PotentialAbilities
        {
            get { return _potentialabilities; }
            set { _potentialabilities = value; }
        }
        private List<Ability> _potentialabilities = new List<Ability>();


        /// <summary>
        /// The pokemons evolutions.
        /// </summary>
        public List<Evolution> Evolutions
        {
            get { return _evolutions; }
            set { _evolutions = value; }
        }
        private List<Evolution> _evolutions = new List<Evolution>();


        /// <summary>
        /// The moves the pokemon can learn.
        /// </summary>
        public List<LearnMove> LearnableMoves
        {
            get { return _learnablemoves; }
            set { _learnablemoves = value; }
        }
        private List<LearnMove> _learnablemoves = new List<LearnMove>();
    }
}
