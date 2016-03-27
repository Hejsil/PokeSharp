using PokeSharp.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSharp.Editor.ViewModels
{
    /// <summary>
    /// The view model all view models in PokeSharp inharits from.
    /// </summary>
    public abstract class PokeSharpViewModel : ObservableObject
    {
        /// <summary>
        /// The name of the view model.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The pokedex, that all the view models should edit.
        /// </summary>
        public PokeDex PokeDex
        {
            get { return _dex; }
            set
            {
                _dex = value;
                OnPropertyChanged(nameof(PokeDex));
            }
        }
        PokeDex _dex;

        public PokeSharpViewModel(string name, PokeDex dex)
        {
            Name = name;
            PokeDex = dex;
        }

        /// <summary>
        /// A method that should refresh all obserable collections in the view model.
        /// </summary>
        public abstract void RefreshCollections();
    }
}
