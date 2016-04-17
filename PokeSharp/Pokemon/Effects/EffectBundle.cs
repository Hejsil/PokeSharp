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
        public List<IEffect> BeforeMove
        {
            get { return _beforemove; }
            set { _beforemove = value; }
        }
        private List<IEffect> _beforemove = new List<IEffect>();


        /// <summary>
        /// The effects that take place just after a move is used.
        /// </summary>
        public List<IEffect> AfterMove
        {
            get { return _aftermove; }
            set { _aftermove = value; }
        }
        private List<IEffect> _aftermove = new List<IEffect>();


        /// <summary>
        /// The effects that take place just before the pokemon having the ability is being hit. 
        /// </summary>
        public List<IEffect> BeforeHit
        {
            get { return _beforehit; }
            set { _beforehit = value; }
        }
        private List<IEffect> _beforehit = new List<IEffect>();


        /// <summary>
        /// The effects that take place just after the pokemon having the ability has been hit.
        /// </summary>
        public List<IEffect> AfterHit
        {
            get { return _afterhit; }
            set { _afterhit = value; }
        }
        private List<IEffect> _afterhit = new List<IEffect>();


        /// <summary>
        /// The effects that take place at the start of the turn.
        /// </summary>
        public List<IEffect> StartTurn
        {
            get { return _startturn; }
            set { _startturn = value; }
        }
        private List<IEffect> _startturn = new List<IEffect>();


        /// <summary>
        /// The effects that take place at the end of the turn.
        /// </summary>
        public List<IEffect> EndTurn
        {
            get { return _endturn; }
            set { _endturn = value; }
        }
        private List<IEffect> _endturn = new List<IEffect>();

        /// <summary>
        /// The effects that take place when the pokemon is sendt in to battle.
        /// </summary>
        public List<IEffect> OnSendIn
        {
            get { return _onsendin; }
            set { _onsendin = value; }
        }
        private List<IEffect> _onsendin;
    }
}
