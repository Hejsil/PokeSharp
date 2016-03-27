﻿using System;
using Utility;

namespace PokeSharp.Pokemon
{
    /// <summary>
    /// The data type for a pokemons nature.
    /// </summary>
    public class Nature
    {
        /// <summary>
        /// The name of the nature.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The modifiers the nature modifies the pokemons stats with.
        /// </summary>
        public Fraction[] Modifiers { get; set; }

        public Nature()
        {
            Modifiers = new Fraction[6];
        }
    }
}