using PokeSharp.Pokemon;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace PokeSharp.Editor.ViewModels
{
    public class PokemonListViewModel : PokeSharpViewModel
    {
        static int _defaultNameIds = 0;

        public SyncedObservableList<BasePokemon> ObservedPokemons
        {
            get { return _observedpokemons; }
            set
            {
                _observedpokemons = value;
                OnPropertyChanged(nameof(ObservedPokemons));
            }
        }
        SyncedObservableList<BasePokemon> _observedpokemons;

        public PokemonViewModel PokemonViewModel
        {
            get { return _pokeviewmodel; }
            set
            {
                _pokeviewmodel = value;
                OnPropertyChanged(nameof(PokemonViewModel));
            }
        }
        PokemonViewModel _pokeviewmodel;

        public DelegateCommand AddPokemon { get; set; }
        public DelegateCommand RemovePokemon { get; set; }

        public PokemonListViewModel(string name, PokeDex dex) 
            : base(name, dex)
        {
            AddPokemon = new DelegateCommand(AddPokemonExecute, o => true);
            RemovePokemon = new DelegateCommand(RemovePokemonExecute, RemovePokemonCanExecute);
            ObservedPokemons = new SyncedObservableList<BasePokemon>(() => PokeDex.Pokemons);
            PokemonViewModel = new PokemonViewModel(PokeDex);
        }

        private bool RemovePokemonCanExecute(object arg)
        {
            return arg != null;
        }

        private void RemovePokemonExecute(object obj)
        {
            ObservedPokemons.Remove(obj as BasePokemon);
            PokemonViewModel.Pokemon = null;
            RemovePokemon.OnCanExecuteChanged();
        }

        private void AddPokemonExecute(object obj)
        {
            ObservedPokemons.Add(new BasePokemon() { Name = "Pokemon" + _defaultNameIds++ });
            PokemonViewModel.AddEvolution.OnCanExecuteChanged();
        }

        public override void NewPokeDex(PokeDex dex)
        {
            base.NewPokeDex(dex);

            PokemonViewModel.NewPokeDex(dex);
        }
    }
}
