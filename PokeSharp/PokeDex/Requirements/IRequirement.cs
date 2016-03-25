namespace PokeSharp.PokeDex.Requirements
{
    /// <summary>
    /// An interface for requirements that differnt things need, before they can happen.
    /// </summary>
    public interface IRequirement
    {
        /// <summary>
        /// Checks whether a pokemon meets the requirement.
        /// </summary>
        /// <param name="pokemon"></param>
        /// <returns></returns>
        bool IsMet(Pokemon pokemon);
    }
}