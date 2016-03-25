using PokeSharp.PokeDex.Requirements;
using System.Collections.Generic;

namespace PokeSharp.PokeDex
{
    /// <summary>
    /// A data type contaning all the relevant data for an evolution.
    /// </summary>
    public class Evolution
    {
        /// <summary>
        /// The pokemon being evolved into.
        /// </summary>
        public BasePokemon Pokemon { get; set; }

        /// <summary>
        /// The requirements for the evolution to happen.
        /// </summary>
        public List<IRequirement> Requirements { get; set; }

        /// <summary>
        /// Determins whether a pokemon can evolve.
        /// </summary>
        /// <param name="pokemon"></param>
        /// <returns></returns>
        public bool CanEvolve(Pokemon pokemon)
        {
            foreach (var req in Requirements)
            {
                if (!req.IsMet(pokemon))
                    return false;
            }

            return true;
        }
    }
}