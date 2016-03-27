using System.Collections.Generic;

namespace PokeSharp.Pokemon.Effects
{
    /// <summary>
    /// A data type for effects that occur at certain points during battle.
    /// </summary>
    public class EffectBundle
    {
        /// <summary>
        /// The effects that take place just before a move is used.
        /// </summary>
        public List<IEffect> BeforeMove { get; set; }

        /// <summary>
        /// The effects that take place just after a move is used.
        /// </summary>
        public List<IEffect> AfterMove { get; set; }

        /// <summary>
        /// The effects that take place just before the pokemon having the ability is being hit. 
        /// </summary>
        public List<IEffect> BeforeHit { get; set; }

        /// <summary>
        /// The effects that take place just after the pokemon having the ability has been hit.
        /// </summary>
        public List<IEffect> AfterHit { get; set; }

        /// <summary>
        /// The effects that take place at the start of the turn.
        /// </summary>
        public List<IEffect> StartTurn { get; set; }

        /// <summary>
        /// The effects that take place at the end of the turn.
        /// </summary>
        public List<IEffect> EndTurn { get; set; }

        public EffectBundle()
        {
            BeforeHit = new List<IEffect>();
            AfterHit = new List<IEffect>();
            BeforeMove = new List<IEffect>();
            AfterMove = new List<IEffect>();
            StartTurn = new List<IEffect>();
            EndTurn = new List<IEffect>();
        }
    }
}
