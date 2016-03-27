using System;
using System.Collections.Generic;
using Utility;

namespace PokeSharp.Pokemon
{
    /// <summary>
    /// The type a pokemon can be.
    /// </summary>
    public class PokemonType
    {
        /// <summary>
        /// The name of the type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The effectiveness attacks have one this type.
        /// </summary>
        public Dictionary<PokemonType, Fraction> Effectiveness { get; set; }

        public PokemonType()
        {
            Effectiveness = new Dictionary<PokemonType, Fraction>();
        }
    }
}
