using System;
using System.Collections.Generic;
using Utility;

namespace PokeSharp.PokeDex
{
    /// <summary>
    /// The type a pokemon can be.
    /// </summary>
    public class PokemonType
    {
        /// <summary>
        /// The id of the pokemon type.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The effectiveness attacks have one this type.
        /// </summary>
        public Dictionary<PokemonType, Fraction> Effectiveness { get; set; }
    }
}
