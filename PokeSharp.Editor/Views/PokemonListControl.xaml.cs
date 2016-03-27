using PokeSharp.Editor.ViewModels;
using PokeSharp.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokeSharp.Editor.Views
{
    /// <summary>
    /// Interaction logic for PokemonControl.xaml
    /// </summary>
    public partial class PokemonListControl : UserControl
    {
        public PokemonListControl()
        {
            InitializeComponent();
        }

        private void PokemonList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (DataContext as PokemonListViewModel).PokemonViewModel.Pokemon = (sender as ListView).SelectedItem as BasePokemon;
            (DataContext as PokemonListViewModel).RemovePokemon.OnCanExecuteChanged();
        }
    }
}
