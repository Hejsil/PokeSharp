using System;

namespace PokeSharp.PokeDex
{
    /// <summary>
    /// The data type for a specific pokemon, that a trainer has caught.
    /// </summary>
    public class Pokemon
    {
        /// <summary>
        /// The pokemons nickname.
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// The base pokemon.
        /// </summary>
        public BasePokemon Base { get; set; }

        /// <summary>
        /// The level of the pokemon.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// The evs the pokemon has optained.
        /// </summary>
        public int[] EVs { get; set; }

        /// <summary>
        /// The ivs the pokemon was born with.
        /// </summary>
        public int[] IVs { get; set; }

        /// <summary>
        /// The bonuses applied to the pokemon during battle.
        /// This includes loosing health.
        /// </summary>
        public int[] Bonuses { get; set; }

        /// <summary>
        /// The moves the pokemon have.
        /// </summary>
        public Move[] Moves { get; set; }

        /// <summary>
        /// The ability the pokemon have.
        /// </summary>
        public Ability Ability { get; set; }

        /// <summary>
        /// The item the pokemon is holding.
        /// </summary>
        public Item HoldItem { get; set; }

        /// <summary>
        /// The nature the pokemon was born with.
        /// </summary>
        public Nature Nature { get; set; }

        /// <summary>
        /// Calculates stats using the formulars from bulbapedia (In Generation III onward):
        /// http://bulbapedia.bulbagarden.net/wiki/Statistic
        /// </summary>
        /// <returns></returns>
        public int[] CalculateStats()
        {
            int[] res = new int[6];

            res[0] = ((2 * Base.BaseStats[0] + IVs[0] + EVs[0]/4) * Level) / 100 + Level + 10;

            for (int i = 1; i < 6; i++)
            {
                res[i] = (int)((((2 * Base.BaseStats[i] + IVs[i] + EVs[i] / 4) * Level) / 100 + 5) * Nature.Modifiers[i]);
            }

            return res;
        }
    }
}
