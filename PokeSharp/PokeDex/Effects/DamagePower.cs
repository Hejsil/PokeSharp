using System;

namespace PokeSharp.PokeDex.Effects
{
    /// <summary>
    /// An effect that does damage to a pokemon, based on 
    /// </summary>
    public class DamagePower : IEffect
    {
        /// <summary>
        /// The power of the effect.
        /// </summary>
        public int Power { get; set; }

        /// <summary>
        /// The category of the effect.
        /// </summary>
        public Category DamageCategory { get; set; }

        /// <summary>
        /// The defends value used to calculate damage.
        /// </summary>
        public TargetDefends DefendsValue { get; set; }

        public void Apply(Pokemon user, params Pokemon[] targets)
        {
            foreach (var target in targets)
            {

            }
        }
        
        /// <summary>
        /// The category the damage falls under.
        /// This also determins what stat of the users is used to calculate damage.
        /// </summary>
        public enum Category
        {
            Phycical,
            Special
        }

        /// <summary>
        /// The defends value of the targets that is used to calculate damage.
        /// </summary>
        public enum TargetDefends
        {
            Same,
            Opposite,
            Ignore
        }
    }
}
