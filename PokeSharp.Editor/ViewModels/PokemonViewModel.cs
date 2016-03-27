using PokeSharp.Pokemon;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace PokeSharp.Editor.ViewModels
{
    public class PokemonViewModel : PokeSharpViewModel
    {
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

        public BasePokemon SelectedPokemon
        {
            get { return _selectedpokemon; }
            set
            {
                _selectedpokemon = value;
                OnPropertyChanged(nameof(SelectedPokemon));
                RemovePokemon.OnCanExecuteChanged();
            }
        }
        BasePokemon _selectedpokemon;

        public DelegateCommand AddPokemon { get; set; }
        public DelegateCommand RemovePokemon { get; set; }
        public DelegateCommand SelectionChanged { get; set; }

        public PokemonViewModel(string name, PokeDex dex) 
            : base(name, dex)
        {
            AddPokemon = new DelegateCommand(AddPokemonExecute, o => true);
            RemovePokemon = new DelegateCommand(RemovePokemonExecute, RemovePokemonCanExecute);
            SelectionChanged = new DelegateCommand(SelectionChangedExecute, o => true);
        }

        private void SelectionChangedExecute(object obj)
        {
            SelectedPokemon = obj as BasePokemon;
        }

        private bool RemovePokemonCanExecute(object arg)
        {
            return SelectedPokemon != null;
        }

        private void RemovePokemonExecute(object obj)
        {
            ObservedPokemons.Remove(SelectedPokemon);
            SelectedPokemon = null;
        }

        private void AddPokemonExecute(object obj)
        {
            ObservedPokemons.Add(new BasePokemon());
        }

        public override void RefreshCollections()
        {
            ObservedPokemons = new SyncedObservableList<BasePokemon>(PokeDex.Pokemons);
        }
    }
}
