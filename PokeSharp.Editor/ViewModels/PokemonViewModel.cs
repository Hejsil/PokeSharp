using PokeSharp.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSharp.Editor.ViewModels
{
    public class PokemonViewModel : PokeSharpViewModel
    {
        BasePokemon _default = new BasePokemon();

        public BasePokemon Pokemon
        {
            get { return (_selectedpokemon != null) ? _selectedpokemon : _default; }
            set
            {
                _selectedpokemon = value;
                OnPropertyChanged(nameof(Pokemon));
            }
        }
        BasePokemon _selectedpokemon;

        public SyncedObservableList<Evolution> Evolutions
        {
            get { return _evolutions; }
            set
            {
                _evolutions = value;
                OnPropertyChanged(nameof(Evolutions));
            }
        }
        SyncedObservableList<Evolution> _evolutions;

        public SyncedObservableList<LearnMove> Moves
        {
            get { return _moves; }
            set
            {
                _moves = value;
                OnPropertyChanged(nameof(Moves));
            }
        }
        SyncedObservableList<LearnMove> _moves;

        public EvolutionViewModel EvolutionViewModel
        {
            get { return _evolutionviewmodel; }
            set
            {
                _evolutionviewmodel = value;
                OnPropertyChanged(nameof(EvolutionViewModel));
            }
        }
        EvolutionViewModel _evolutionviewmodel;

        public DelegateCommand AddEvolution { get; set; }
        public DelegateCommand RemoveEvolution { get; set; }
        public DelegateCommand EditEvolution { get; set; }

        public PokemonViewModel(PokeDex dex)
            : base("", dex)
        {
            AddEvolution = new DelegateCommand(AddEvolutionExecute, AddEvolutionCanExecute);
            RemoveEvolution = new DelegateCommand(RemoveEvolutionExecute, RemoveEvolutionCanExecute);
            EditEvolution = new DelegateCommand(EditEvolutionExecute, EditEvolutionCanExecute);
            Evolutions = new SyncedObservableList<Evolution>(() => Pokemon.Evolutions);
            Moves = new SyncedObservableList<LearnMove>(() => Pokemon.LearnableMoves);
            EvolutionViewModel = new EvolutionViewModel(PokeDex);
        }

        private bool EditEvolutionCanExecute(object arg)
        {
            return arg != null;
        }

        private void EditEvolutionExecute(object obj)
        {
            EvolutionViewModel.Evolution = obj as Evolution;
        }

        private bool RemoveEvolutionCanExecute(object arg)
        {
            return arg != null;
        }

        private void RemoveEvolutionExecute(object obj)
        {
            Evolutions.Remove(obj as Evolution);
            RemoveEvolution.OnCanExecuteChanged();
            EditEvolution.OnCanExecuteChanged();
        }

        private bool AddEvolutionCanExecute(object arg)
        {
            return PokeDex.Pokemons.Count != 0;
        }

        private void AddEvolutionExecute(object obj)
        {
            Evolutions.Add(new Evolution(PokeDex.Pokemons.First()));
        }
    }
}
