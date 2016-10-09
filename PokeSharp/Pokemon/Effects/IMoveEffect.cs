using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSharp.Pokemon.Effects
{
    public interface IMoveEffect
    {
        void Apply(Move move, Pokemon user, params Pokemon[] targets);
    }
}
