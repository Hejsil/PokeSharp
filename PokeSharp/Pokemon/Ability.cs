using PokeSharp.Pokemon.Effects;
using System.Collections.Generic;

namespace PokeSharp.Pokemon
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
        public EffectBundle Effects
        {
            get { return _effects; }
            set { _effects = value; }
        }
        private EffectBundle _effects = new EffectBundle();
    }
}