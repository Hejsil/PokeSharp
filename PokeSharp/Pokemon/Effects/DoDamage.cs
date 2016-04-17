using PokeSharp.Pokemon.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace PokeSharp.Pokemon.Effects
{
    /// <summary>
    /// The effect that deals damage to targets, using power and stats to calculate the damage.
    /// </summary>
    public class DoDamage : IMoveEffect
    {
        /// <summary>
        /// The power of the effect.
        /// </summary>
        public int Power { get; set; }

        /// <summary>
        /// The stat used by the user to determin damage.
        /// </summary>
        public Category OffensiveStat { get; set; }

        /// <summary>
        /// The stat used by targets to determin damage.
        /// </summary>
        public Defends DefendsStat { get; set; }

        public void Apply(Move move, Pokemon user, params Pokemon[] targets)
        {
            var userstats = user.CalculateStats();
            int[] targetstats;
            int attack, defends, statindex;
            double modifier;

            if (OffensiveStat == Category.Physical)
            {
                // Attack stat is index 1
                statindex = 1;
                attack = userstats[statindex];
            }
            else
            {
                // Special attack stat is index 3
                statindex = 3;
                attack = userstats[statindex];
            }

            foreach (var target in targets)
            {
                targetstats = target.CalculateStats();

                if (DefendsStat == Defends.Same)
                    // Defends stat for an offensive stat is always attackstatindex + 1
                    defends = targetstats[statindex + 1];
                else if (DefendsStat == Defends.Opposite)
                    // If special, then statindex - 1 = Defends.
                    // If phycical, then statindex + 3 = SpecialDefens.
                    defends = targetstats[(OffensiveStat == Category.Special) ?
                                           targetstats[statindex - 1] :
                                           targetstats[statindex + 3]];
                else
                    defends = 1;

                modifier = (user.Base.Types.Contains(move.Type)) ? 1.5 : 1.0;
                
                foreach (var type in user.Base.Types)
                {
                    if (type != null)
                        modifier *= type.Effectiveness[move.Type.Name];
                }

                Func<int, double> func = x => (x <= 3) ? 0.5 * Math.Pow(x, 3) - 2.0 * Math.Pow(x, 2) - 5.5 * x + 23 : 1;
                modifier *= (Util.RandomDouble() < 1.0 / func(user.Bonuses[(int)Stats.Crit])) ? 1.5 : 1.0;

                modifier *= 1.0 + user.Bonuses[(int)Stats.DmgMul] / 100.0;
                
                modifier *= Util.RandomInt(85, 100) / (double)100;

                // Using damage fomular from bulbapedia: http://bulbapedia.bulbagarden.net/wiki/Damage
                target.Bonuses[0] -= (int)((((2 * user.Level + 10) / 250) * (attack / defends) * Power + 2) * modifier);
            }
        }

        public enum Category
        {
            Special  = 0,
            Physical = 1
        }

        public enum Defends
        {
            Same        = 0,
            Opposite    = 1,
            Ignore      = 2
        }
    }
}
