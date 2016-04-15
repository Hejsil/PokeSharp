using PokeSharp.Pokemon.Requirements;
using System.Collections.Generic;

namespace PokeSharp.Pokemon
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
        public List<IRequirement> Requirements
        {
            get { return _requirements; }
            set { _requirements = value; }
        }
        private List<IRequirement> _requirements = new List<IRequirement>();


        public Evolution(BasePokemon pokemon)
        {
            Pokemon = pokemon;
        }

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