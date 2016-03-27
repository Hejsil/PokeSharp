using PokeSharp.Pokemon;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSharp.Editor.ViewModels
{
    public class MainWindowViewModel : PokeSharpViewModel
    {
        public ObservableCollection<PokeSharpViewModel> ViewModels
        {
            get { return _viewmodels; }
            set
            {
                _viewmodels = value;
                OnPropertyChanged(nameof(ViewModels));
            }
        }
        ObservableCollection<PokeSharpViewModel> _viewmodels;

        public MainWindowViewModel() 
            : base("", new PokeDex())
        {
            ViewModels = new ObservableCollection<PokeSharpViewModel>();
            ViewModels.Add(new PokemonViewModel("Pokemons", PokeDex));
            ViewModels.Add(new TypeViewModel("Types", PokeDex));

            RefreshCollections();
        }

        public override void RefreshCollections()
        {
            foreach (var viewmodel in ViewModels)
            {
                viewmodel.RefreshCollections();
            }
        }
    }
}
