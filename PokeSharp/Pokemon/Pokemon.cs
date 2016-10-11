using System;
using System.Linq;
using PokeSharp.Pokemon.Enums;

namespace PokeSharp.Pokemon
{
    /// <summary>
    /// The data type for a specific pokemon, that a trainer has caught.
    /// </summary>
    public class Pokemon
    {
        public const int MaxTotalEv = 510;
        public const int MaxEv = 252;
        public const int MaxIv = 31;
        public const int StatCount = 6;

        /// <summary>
        /// The pokemons nickname.
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// The level of the pokemon.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// The evs the pokemon has optained.
        /// </summary>
        public int[] EVs { get; } = new int[StatCount];

        /// <summary>
        /// The ivs the pokemon was born with.
        /// </summary>
        public int[] IVs { get; } = new int[StatCount];
        
        /// <summary>
        /// Calculates stats using the formulars from bulbapedia (In Generation III onward):
        /// http://bulbapedia.bulbagarden.net/wiki/Statistic
        /// </summary>
        /// <returns></returns>
        public int[] Stats
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// The bonuses applied to the pokemon during battle.
        /// This includes loosing health.
        /// </summary>
        public int[] Bonuses { get; } = new int[Enum.GetValues(typeof(Stats)).Length];
        
        /// <summary>
        /// The PokemonId pokemon.
        /// </summary>
        public int PokemonId { get; set; }

        /// <summary>
        /// The moves the pokemon have.
        /// </summary>
        public int[] MoveIds { get; } = new int[4];

        /// <summary>
        /// The @Ability the pokemon have.
        /// </summary>
        public int AbilityId { get; set; }

        /// <summary>
        /// The nature the pokemon was born with.
        /// </summary>
        public int NatureId { get; set; }

        public Pokemon(int pokemonId)
        {
            PokemonId = pokemonId;
        }
    }
}
