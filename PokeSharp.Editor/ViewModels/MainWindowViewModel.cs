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
            ViewModels.Add(new PokemonListViewModel("Pokemons", PokeDex));
            ViewModels.Add(new TypeViewModel("Types", PokeDex));
        }

        public override void NewPokeDex(PokeDex dex)
        {
            base.NewPokeDex(dex);

            foreach (var item in ViewModels)
            {
                item.NewPokeDex(dex);
            }
        }
    }
}
