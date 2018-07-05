using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace DXSample.ViewModels {
    public class MyViewModelBase : ViewModelBase {
        public string Caption {
            get { return GetProperty(() => Caption); }
            set { SetProperty(() => Caption, value); }
        }
        [Command]
        public void ChangeText() {
            (((ISupportParentViewModel)this).ParentViewModel as MainViewModel).SplashScreenViewModel.Caption = this.Caption;
        }
    }
}
