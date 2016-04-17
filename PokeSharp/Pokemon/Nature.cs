using Utility;

namespace PokeSharp.Pokemon
{
    /// <summary>
    /// The data type for a pokemons nature.
    /// </summary>
    public class Nature
    {
        /// <summary>
        /// The name of the nature.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The modifiers the nature modifies the pokemons stats with.
        /// </summary>
        public double[] Modifiers
        {
            get { return _modifiers; }
            set
            {
                Util.EnsureSize(value, 6);
                _modifiers = value;
            }
        }
        private double[] _modifiers = new double[6] { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0 };
    }
}