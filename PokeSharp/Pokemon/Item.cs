using PokeSharp.Pokemon.Effects;

namespace PokeSharp.Pokemon
{
    /// <summary>
    /// A data type for items in the pokemon world.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The desciption of the item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The effects the item has, while being held by a pokemon.
        /// </summary>
        public EffectBundle Effects
        {
            get { return _effects; }
            set { _effects = value; }
        }
        private EffectBundle _effects = new EffectBundle();
    }
}