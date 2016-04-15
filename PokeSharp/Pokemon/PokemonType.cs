using System.Collections.Generic;

namespace PokeSharp.Pokemon
{
    /// <summary>
    /// The type a pokemon can be.
    /// </summary>
    public class PokemonType
    {
        /// <summary>
        /// The name of the type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The effectiveness attacks have one this type.
        /// </summary>
        public Dictionary<string, double> Effectiveness
        {
            get { return _effectiveness; }
            set { _effectiveness = value; }
        }
        private Dictionary<string, double> _effectiveness = new Dictionary<string, double>();


        public PokemonType()
        {
        }
    }
}
