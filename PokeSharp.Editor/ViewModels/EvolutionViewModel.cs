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
                Requirements.NotifyBigChange();
                OnPropertyChanged(nameof(Evolution));
            }
        }
        Evolution _evolution;

        public IRequirement SelectedRequirement
        {
            get { return _selectedrequirement; }
            set
            {
                _selectedrequirement = value;
                OnPropertyChanged(nameof(SelectedRequirement));
            }
        }
        IRequirement _selectedrequirement;

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
        public DelegateCommand RequirementTypeChanged { get; set; }
        public DelegateCommand SelectedRequirementChanged { get; set; }

        public EvolutionViewModel(PokeDex dex)
            : base("", dex)
        {
            AddRequirement = new DelegateCommand(AddRequirementExecute, AddRequirementCanExecute);
            RemoveRequirement = new DelegateCommand(RemoveRequirementExecute, RemoveRequirementCanExecute);
            RequirementTypeChanged = new DelegateCommand(RequirementTypeChangedExecute, (o) => true);
            SelectedRequirementChanged = new DelegateCommand(SelectedRequirementChangedExecute, (o) => true);
            Requirements = new SyncedObservableList<IRequirement>(() => Evolution.Requirements);
            RequirementCreation = new ObservableCollection<Tuple<string, Func<IRequirement>>>()
            {
                new Tuple<string, Func<IRequirement>>("Level", () => new LevelRepuirement())
            };
        }

        private void SelectedRequirementChangedExecute(object obj)
        {
            SelectedRequirement = obj as IRequirement;
            RemoveRequirement.OnCanExecuteChanged();
        }

        private void RequirementTypeChangedExecute(object obj)
        {
            AddRequirement.OnCanExecuteChanged();
        }

        private bool RemoveRequirementCanExecute(object arg)
        {
            return arg != null;
        }

        private void RemoveRequirementExecute(object obj)
        {
            Requirements.Remove(obj as IRequirement);
        }

        private bool AddRequirementCanExecute(object arg)
        {
            return arg != null;
        }

        private void AddRequirementExecute(object obj)
        {
            Requirements.Add((obj as Func<IRequirement>)());
        }
    }
}
