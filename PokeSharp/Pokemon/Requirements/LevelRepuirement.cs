using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSharp.Pokemon.Requirements
{
    public class LevelRepuirement : IRequirement
    {
        public string Description
        {
            get { return "Pokemon is equal to, or above level [" + Level + "]"; }
        }

        public int Level { get; set; }

        public bool IsMet(Pokemon pokemon)
        {
            return pokemon.Level >= Level;
        }
    }
}
