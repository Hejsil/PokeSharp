namespace PokeSharp.PokeDex.Requirements
{
    public interface IRequirement
    {
        bool IsMet(Pokemon pokemon);
    }
}