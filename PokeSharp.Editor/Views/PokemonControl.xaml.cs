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
    public partial class PokemonControl : UserControl
    {
        public PokemonControl()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var viewmodel = (DataContext as PokemonViewModel).EvolutionViewModel; 
            var window = new EvolutionWindow();
            window.DataContext = viewmodel;
            viewmodel.Evolution = EvolutionList.SelectedItem as Evolution;
            window.ShowDialog();
        }
    }
}
