using System.Collections.Specialized;
using System.ComponentModel;

namespace PokeSharp.Editor.ViewModels
{
    /// <summary>
    /// An object that can be observed by the view.
    /// </summary>
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler for property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The function to call when a property changes.
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}