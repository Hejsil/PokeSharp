using System.Collections.Generic;

namespace PokeSharp.Pokemon
{
    /// <summary>
    /// A data type reprecenting a pokedex. The pokedex contains all infomation about the pokemon world.
    /// </summary>
    public class PokeDex
    {
        /// <summary>
        /// All types in the pokedex.
        /// </summary>
        public List<PokemonType> Types
        {
            get { return _types; }
            set { _types = value; }
        }
        private List<PokemonType> _types = new List<PokemonType>();
        
        /// <summary>
        /// All moves in the pokedex.
        /// </summary>
        public List<Move> Moves
        {
            get { return _moves; }
            set { _moves = value; }
        }
        private List<Move> _moves = new List<Move>();

        /// <summary>
        /// All natures in the pokedex.
        /// </summary>
        public List<Nature> Natures
        {
            get { return _natures; }
            set { _natures = value; }
        }
        private List<Nature> _natures = new List<Nature>();

        /// <summary>
        /// All the abilities in the pokedex.
        /// </summary>
        public List<Ability> Abilities
        {
            get { return _abilities; }
            set { _abilities = value; }
        }
        private List<Ability> _abilities = new List<Ability>();

        /// <summary>
        /// All pokemons in the pokedex.
        /// </summary>
        public List<BasePokemon> Pokemons
        {
            get { return _pokemons; }
            set { _pokemons = value; }
        }
        private List<BasePokemon> _pokemons = new List<BasePokemon>();
    }
}
