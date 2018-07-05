using System;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace DXSample.ViewModel {
    public class TileViewModel {

        public string Caption { get; set; }
        public ObservableCollection<TileViewModel> Children { get; set; }
        public ICommand NavigateCommand { get; set; }
        public bool IsHasChildren { get { return Children.Count != 0; } }
        public String GlyphUri { get; set; }
        public String Group { get; set; }
        /// <summary>
        /// Initializes a new instance of the TileObject class.
        /// </summary>
        public TileViewModel() {
            Caption = String.Empty;
            Children = new ObservableCollection<TileViewModel>();
            NavigateCommand = null;
            GlyphUri = String.Empty;
            Group = String.Empty;
        }
    }
}
