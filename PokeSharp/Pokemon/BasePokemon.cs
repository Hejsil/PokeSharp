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
        public int[] BaseStats { get; set; }

        /// <summary>
        /// The pokemons types.
        /// </summary>
        public PokemonType[] Types { get; set; }

        /// <summary>
        /// The abilities the pokemon can have.
        /// </summary>
        public Ability[] PotentialAbilities { get; set; }

        /// <summary>
        /// The pokemons evolutions.
        /// </summary>
        public List<Evolution> Evolutions { get; set; }

        /// <summary>
        /// The moves the pokemon can learn.
        /// </summary>
        public List<LearnMove> LearnableMoves { get; set; }

        public BasePokemon()
        {
            BaseStats = new int[6];
            Types = new PokemonType[2];
            Evolutions = new List<Evolution>();
            PotentialAbilities = new Ability[3];
            LearnableMoves = new List<LearnMove>();
    }
    }
}
