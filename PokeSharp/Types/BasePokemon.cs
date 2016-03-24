using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSharp.Types
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
        /// The base stats of the pokemon.
        /// </summary>
        public int[] BaseStats { get; set; }

        /// <summary>
        /// The pokemons evolutions.
        /// </summary>
        public Evolution[] Evolutions { get; set; }
    }
}
