using PokeSharp.Pokemon;
using PokeSharp.Pokemon.Requirements;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSharp.Editor.ViewModels
{
    public class EvolutionViewModel : PokeSharpViewModel
    {
        Evolution _default = new Evolution(new BasePokemon());

        public Evolution Evolution
        {
            get { return (_evolution != null) ? _evolution : _default; }
            set
            {
                _evolution = value;
                OnPropertyChanged(nameof(Evolution));
            }
        }
        Evolution _evolution;

        public SyncedObservableList<IRequirement> Requirements
        {
            get { return _requirements; }
            set
            {
                _requirements = value;
                OnPropertyChanged(nameof(Requirements));
            }
        }
        SyncedObservableList<IRequirement> _requirements;

        public ObservableCollection<Tuple<string, Func<IRequirement>>> RequirementCreation
        {
            get { return _requirementcreation; }
            set
            {
                _requirementcreation = value;
                OnPropertyChanged(nameof(RequirementCreation));
            }
        }
        ObservableCollection<Tuple<string, Func<IRequirement>>> _requirementcreation;

        public DelegateCommand AddRequirement { get; set; }
        public DelegateCommand RemoveRequirement { get; set; }

        public EvolutionViewModel(PokeDex dex)
            : base("", dex)
        {
            Requirements = new SyncedObservableList<IRequirement>(() => Evolution.Requirements);
            RequirementCreation = new ObservableCollection<Tuple<string, Func<IRequirement>>>()
            {
                new Tuple<string, Func<IRequirement>>("Level", () => new LevelRepuirement())
            };
        }
    }
}
