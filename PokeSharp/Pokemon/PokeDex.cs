using PokeSharp.Pokemon.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility;

namespace PokeSharp.Pokemon
{
    /// <summary>
    /// A data type reprecenting a pokedex. The pokedex contains all infomation about the pokemon world.
    /// </summary>
    public class PokeDex
    {
        /// <summary>
        /// All types in the pokedex.
        /// </summary>
        public List<PokemonType> Types
        {
            get { return _types; }
            set { _types = value; }
        }
        private List<PokemonType> _types = new List<PokemonType>();
        
        /// <summary>
        /// All moves in the pokedex.
        /// </summary>
        public List<Move> Moves
        {
            get { return _moves; }
            set { _moves = value; }
        }
        private List<Move> _moves = new List<Move>();

        /// <summary>
        /// All natures in the pokedex.
        /// </summary>
        public List<Nature> Natures
        {
            get { return _natures; }
            set { _natures = value; }
        }
        private List<Nature> _natures = new List<Nature>();

        /// <summary>
        /// All the abilities in the pokedex.
        /// </summary>
        public List<Ability> Abilities
        {
            get { return _abilities; }
            set { _abilities = value; }
        }
        private List<Ability> _abilities = new List<Ability>();

        /// <summary>
        /// All pokemons in the pokedex.
        /// </summary>
        public List<BasePokemon> Pokemons
        {
            get { return _pokemons; }
            set { _pokemons = value; }
        }
        private List<BasePokemon> _pokemons = new List<BasePokemon>();

        public Pokemon MakePokemonInstance(BasePokemon @base, int level = 1, int[] ivs = null, int[] evs = null, Move[] moves = null, Ability ability = null, Nature nature = null)
        {
            var pokemon = new Pokemon(@base);

            pokemon.Level = level;

            if (ivs == null)
            {
                for (int i = 0; i < pokemon.IVs.Length; i++)
                {
                    pokemon.IVs[i] = Util.RandomInt(0, Pokemon.MaxIv);
                }
            }
            else
            {
                pokemon.IVs = ivs;
            }

            if (evs == null)
            {
                int rest = Pokemon.MaxTotalEv;

                for (int i = 0; i < pokemon.IVs.Length; i++)
                {
                    int ev = Util.RandomInt(0, Util.CapAbove(Pokemon.MaxEv, rest));
                    rest -= ev;
                    pokemon.EVs[i] = ev;
                }
            }
            else
            {
                pokemon.EVs = evs;
            }

            // Chose random ability if null, or the pokemon can't have such an ability.
            if (ability == null || !@base.PotentialAbilities.Contains(ability))
            {
                int count = @base.PotentialAbilities.Count;
                pokemon.Ability = @base.PotentialAbilities[Util.RandomInt(0, count - 1)];
            }
            else
            {
                pokemon.Ability = ability;
            }

            if (nature == null)
            {
                int count = @base.PotentialAbilities.Count;
                pokemon.Nature = Natures[Util.RandomInt(0, count - 1)];
            }
            else
            {
                pokemon.Nature = nature;
            }

            if (moves == null)
            {
                var selected = @base.LearnableMoves.TakeWhile(learn => learn.CanLearn(pokemon))
                                                   .Select(learn => learn.Move)
                                                   .Take(4);

                int i = 0;
                foreach (var move in selected)
                {
                    pokemon.Moves[i++] = move;
                }
            }
            else
            {
                var selected = @base.LearnableMoves.TakeWhile(learn => moves.Contains(learn.Move) && learn.CanLearn(pokemon))
                                                   .Select(learn => learn.Move)
                                                   .Take(4);

                int i = 0;
                foreach (var move in selected)
                {
                    pokemon.Moves[i++] = move;
                }
            }

            return pokemon;
        }


        private static readonly int immuneChance = 10;
        private static readonly int resistChance = 25;
        private static readonly int weakChance = 25;
        private static readonly int normalChance = 40;
        public static PokeDex GenerateRandom()
        {
            var dex = new PokeDex();

            for (int i = 0; i < 12; i++)
            {
                dex.Types.Add(new PokemonType() { Name = "Type" + i });
            }

            foreach (var currentType in dex.Types)
            {
                foreach (var effectiveType in dex.Types)
                {
                    switch (Util.RandomChoice(immuneChance, resistChance, weakChance, normalChance))
                    {
                        case 0:
                            currentType.Effectiveness.Add(effectiveType.Name, 0.0);
                            break;
                        case 1:
                            currentType.Effectiveness.Add(effectiveType.Name, 0.5);
                            break;
                        case 2:
                            currentType.Effectiveness.Add(effectiveType.Name, 2.0);
                            break;
                        case 3:
                            currentType.Effectiveness.Add(effectiveType.Name, 1.0);
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }



            int moveCount = Util.RandomInt(50, 150);

            for (int i = 0; i < moveCount; i++)
            {
                var move = new Move(dex.Types[Util.RandomInt(0, dex.Types.Count - 1)])
                {
                    Name = "Move" + i,
                    Accuracy = Util.RandomInt(30, 101)
                };

                move.Effects.Add(new DoDamage()
                {
                    Power = Util.RandomInt(0, 250),
                    DefendsStat = (DoDamage.Defends)Util.RandomInt(0, Enum.GetValues(typeof(DoDamage.Defends)).Length - 1),
                    OffensiveStat = (DoDamage.Category)Util.RandomInt(0, Enum.GetValues(typeof(DoDamage.Category)).Length - 1)
                });

                dex.Moves.Add(move);
            }



            int natureCount = Util.RandomInt(8, 16);

            for (int i = 0; i < natureCount; i++)
            {
                var mod1 = Util.RandomInt(1, 5);
                var mod2 = Util.RandomInt(1, 5);
                var nature = new Nature();
                
                if (mod1 != mod2)
                {
                    nature.Modifiers[mod1] = 0.9;
                    nature.Modifiers[mod2] = 1.1;
                }

                dex.Natures.Add(nature);
            }

            return dex;
        }
    }
}
