Imports DevExpress.Mvvm

Namespace DXSample.ViewModels

    Public Class MainViewModel
        Inherits MyViewModelBase

        Public Sub New()
            Caption = "MainViewModel"
            RightViewModel = New RightViewModel() With {.Caption = "RightViewModel"}
            CType(RightViewModel, ISupportParentViewModel).ParentViewModel = Me
            LeftViewModel = New LeftViewModel() With {.Caption = "LeftViewModel"}
            CType(LeftViewModel, ISupportParentViewModel).ParentViewModel = Me
            SplashScreenViewModel = New SplashScreenViewModel() With {.Caption = "SplashScreenViewModel"}
            CType(SplashScreenViewModel, ISupportParentViewModel).ParentViewModel = Me
        End Sub

        Public Property LeftViewModel As LeftViewModel
            Get
                Return GetProperty(Function() Me.LeftViewModel)
            End Get

            Set(ByVal value As LeftViewModel)
                SetProperty(Function() LeftViewModel, value)
            End Set
        End Property

        Public Property RightViewModel As RightViewModel
            Get
                Return GetProperty(Function() Me.RightViewModel)
            End Get

            Set(ByVal value As RightViewModel)
                SetProperty(Function() RightViewModel, value)
            End Set
        End Property

        Public Property SplashScreenViewModel As SplashScreenViewModel
            Get
                Return GetProperty(Function() Me.SplashScreenViewModel)
            End Get

            Set(ByVal value As SplashScreenViewModel)
                SetProperty(Function() SplashScreenViewModel, value)
            End Set
        End Property
    End Class
End Namespace
