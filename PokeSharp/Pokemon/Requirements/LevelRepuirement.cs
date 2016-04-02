using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSharp.Pokemon.Requirements
{
    public class LevelRepuirement : IRequirement
    {
        public Compare LevelComparison { get; set; }
        public int Level { get; set; }

        public bool IsMet(Pokemon pokemon)
        {
            switch (LevelComparison)
            {
                case Compare.GreaterEqual:
                    return pokemon.Level >= Level;
                case Compare.LesserEqual:
                    return pokemon.Level <= Level;
                case Compare.Greater:
                    return pokemon.Level > Level;
                case Compare.Lesser:
                    return pokemon.Level < Level;
                case Compare.Equal:
                    return pokemon.Level == Level;
                default:
                    throw new NotImplementedException();
            }
        }

        public enum Compare
        {
            GreaterEqual,
            LesserEqual,
            Greater,
            Lesser,
            Equal
        }
    }
}
