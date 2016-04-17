using System.Collections.Generic;
using PokeSharp.Pokemon.Effects;

namespace PokeSharp.Pokemon
{
    /// <summary>
    /// The data type for a move.
    /// </summary>
    public class Move
    {
        /// <summary>
        /// The name of the move.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The desciption of the move.
        /// </summary>
        public string Desciption { get; set; }

        /// <summary>
        /// The accuracy of the move. If it's over 100, it cant miss.
        /// </summary>
        public int Accuracy { get; set; }

        /// <summary>
        /// The type of the move.
        /// </summary>
        public PokemonType Type { get; set; }

        /// <summary>
        /// The effects the move have.
        /// </summary>
        public List<IMoveEffect> Effects
        {
            get { return _effects; }
            set { _effects = value; }
        }
        private List<IMoveEffect> _effects = new List<IMoveEffect>();


        public Move(PokemonType type)
        {
            Type = type;
        }
    }
}