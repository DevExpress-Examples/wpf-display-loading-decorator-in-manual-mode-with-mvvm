using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace DXSample.ViewModel {
    public class MainViewModel : ViewModelBase {
        private INavigationService Service { get { return this.GetService<INavigationService>(); } }
        public ObservableCollection<TileViewModel> TileCollection {get; set;}

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel() {
            TileCollection = new ObservableCollection<TileViewModel>();
            TileCollection.Add(new TileViewModel() {
                Caption = "Home View",
                NavigateCommand = new DelegateCommand(() => { Service.Navigate("HomeView", null, this); }),
                GlyphUri = "Home_32x32.png",
                Group = "TileBar control"
            });
            TileCollection.Add(new TileViewModel() {
                Caption = "CategoryView",
                Children = new ObservableCollection<TileViewModel>() { 
                    new TileViewModel(){
                        Caption = "Category I",
                        NavigateCommand = new DelegateCommand(() => { Service.Navigate("SubCategory1View", null, this); })
                    },
                    new TileViewModel(){
                        Caption = "Category II",
                        NavigateCommand = new DelegateCommand(() => { Service.Navigate("SubCategory2View", null, this); })
                    },
                    new TileViewModel(){
                        Caption = "Category III",
                        NavigateCommand = new DelegateCommand(() => { Service.Navigate("SubCategory3View", null, this); })
                    },
                },
                NavigateCommand = new DelegateCommand(() => { Service.Navigate("CategoryView", null, this); })
            });
        }
    }

}
