using PokeSharp.Pokemon.Requirements;
using System.Collections.Generic;

namespace PokeSharp.Pokemon
{
    /// <summary>
    /// The data type for how a move is learned by a pokemon.
    /// </summary>
    public class LearnableMove
    {
        /// <summary>
        /// The move being learned.
        /// </summary>
        public Move Move { get; set; }

        /// <summary>
        /// The requirements for the move to be learned.
        /// </summary>
        public List<IRequirement> Requirements { get; set; } = new List<IRequirement>();

        /// <summary>
        /// Determins whether a pokemon can learn the move or not.
        /// </summary>
        /// <param name="pokemon"></param>
        /// <returns></returns>
        public bool CanLearn(Pokemon pokemon)
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