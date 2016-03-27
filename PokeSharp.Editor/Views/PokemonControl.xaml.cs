using PokeSharp.Editor.ViewModels;
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
    public partial class PokemonControl : UserControl
    {
        public PokemonControl()
        {
            InitializeComponent();
        }

        private void EvolutionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (DataContext as PokemonViewModel).RemoveEvolution.OnCanExecuteChanged();
            (DataContext as PokemonViewModel).EditEvolution.OnCanExecuteChanged();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var window = new EvolutionWindow();
            window.DataContext = (DataContext as PokemonViewModel).EvolutionViewModel;
            window.ShowDialog();
            //(DataContext as PokemonViewModel).Evolutions.NotifyBigChange();
        }
    }
}
