using System;
using Utility;

namespace PokeSharp.PokeDex
{
    /// <summary>
    /// The data type for a pokemons nature.
    /// </summary>
    public class Nature
    {
        /// <summary>
        /// The id of the nature. Used by other data types to refer to this nature.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the nature.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The modifiers the nature modifies the pokemons stats with.
        /// </summary>
        public Fraction[] Modifiers { get; set; }
    }
}