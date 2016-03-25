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
        /// The nature the pokemon was born with.
        /// </summary>
        public Nature Nature { get; set; }
    }
}
