using System;
using DevExpress.Mvvm;

namespace DXSample.ViewModels {
    public class MainViewModel : MyViewModelBase {
        public MainViewModel() {
            Caption = "MainViewModel";
            RightViewModel = new RightViewModel() {  Caption = "RightViewModel" };
            ((ISupportParentViewModel)RightViewModel).ParentViewModel = this;
            LeftViewModel = new LeftViewModel() { Caption = "LeftViewModel" };
            ((ISupportParentViewModel)LeftViewModel).ParentViewModel = this;
            SplashScreenViewModel = new SplashScreenViewModel() { Caption = "SplashScreenViewModel" };
            ((ISupportParentViewModel)SplashScreenViewModel).ParentViewModel = this;
        }
        public LeftViewModel LeftViewModel {
            get { return GetProperty(() => LeftViewModel); }
            set { SetProperty(() => LeftViewModel, value); }
        }
        public RightViewModel RightViewModel {
            get { return GetProperty(() => RightViewModel); }
            set { SetProperty(() => RightViewModel, value); }
        }
        public SplashScreenViewModel SplashScreenViewModel {
            get { return GetProperty(() => SplashScreenViewModel); }
            set { SetProperty(() => SplashScreenViewModel, value); }
        }
    }
}