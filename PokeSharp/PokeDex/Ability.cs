using PokeSharp.PokeDex.Effects;
using System.Collections.Generic;

namespace PokeSharp.PokeDex
{
    /// <summary>
    /// The data type for an ability a pokemon can have.
    /// </summary>
    public class Ability
    {
        /// <summary>
        /// The name of the ability.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the ability.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The effects the ability have.
        /// </summary>
        public EffectBundle Effects { get; set; }

    }
}