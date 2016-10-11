using PokeSharp.Pokemon.Enums;
using System;
using System.Linq;

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
        public Defense DefenseStat { get; set; }


        public void Apply(Move move, Pokemon user, params Pokemon[] targets)
        {
            /*
            var userstats = user.Stats;

            foreach (var target in targets)
            {
                var targetstats = target.Stats;
                Ability defense;

                // calculate stab
                var modifier = (user.PokemonId.Types.Contains(move.Type)) ? 1.5 : 1.0;

                // calulate type effectiveness
                modifier *= target.PokemonId.Types.Aggregate(1.0, (acc, type) => acc * type.Effectiveness[move.Type.Name]);


                switch (DefenseStat)
                {
                    case Defense.Same:
                        defense = targetstats[(Ability)(OffensiveStat == Category.Physical ? Stats.Defense : Stats.SpecialDefense)];
                        break;
                    case Defense.Opposite:
                        defense = targetstats[(Ability)(OffensiveStat == Category.Physical ? Stats.SpecialDefense : Stats.Defense)];
                        break;
                    default:
                        defense = 1;
                        break;
                }

                Func<Ability, double> func = x => (x <= 3) ? 0.5 * Math.Pow(x, 3) - 2.0 * Math.Pow(x, 2) - 5.5 * x + 23 : 1;
                modifier *= (Util.RandomDouble() < 1.0 / func(user.Bonuses[(Ability)Stats.Crit])) ? 1.5 : 1.0;

                modifier *= 1.0 + user.Bonuses[(Ability)Stats.DmgMul] / 100.0;
                
                modifier *= Util.RandomInt(85, 100) / (double)100;

                // Using damage fomular from bulbapedia: http://bulbapedia.bulbagarden.net/wiki/Damage
                target.Bonuses[0] -= (Ability)((((2 * user.Level + 10) / 250) * (attack / defends) * Power + 2) * modifier);
            }
            */
        }

        public enum Category
        {
            Physical = Stats.Attack,
            Special  = Stats.SpecialAttack,
        }

        public enum Defense
        {
            Same        = 0,
            Opposite    = 1,
            Ignore      = 2
        }
    }
}
