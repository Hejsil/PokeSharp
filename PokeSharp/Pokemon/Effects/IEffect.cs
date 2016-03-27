namespace PokeSharp.Pokemon.Effects
{
    /// <summary>
    /// An interface for an effect that something can apply to a pokemon.
    /// </summary>
    public interface IEffect
    {
        /// <summary>
        /// Applies the effect to the targets.
        /// </summary>
        /// <param name="pokemon"></param>
        void Apply(Pokemon user, params Pokemon[] targets);
    }
}
