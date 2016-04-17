using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSharp.Pokemon.Effects
{
    public interface IEffect
    {
        /// <summary>
        /// Applies the effect to the targets.
        /// </summary>
        /// <param name="pokemon"></param>
        void Apply(Pokemon user, params Pokemon[] targets);
    }
}
