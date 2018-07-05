Imports System
Imports DevExpress.Mvvm

Namespace DXSample.ViewModels
    Public Class MainViewModel
        Inherits MyViewModelBase

        Public Sub New()
            Caption = "MainViewModel"
            RightViewModel = New RightViewModel() With {.Caption = "RightViewModel"}
            DirectCast(RightViewModel, ISupportParentViewModel).ParentViewModel = Me
            LeftViewModel = New LeftViewModel() With {.Caption = "LeftViewModel"}
            DirectCast(LeftViewModel, ISupportParentViewModel).ParentViewModel = Me
            SplashScreenViewModel = New SplashScreenViewModel() With {.Caption = "SplashScreenViewModel"}
            DirectCast(SplashScreenViewModel, ISupportParentViewModel).ParentViewModel = Me
        End Sub
        Public Property LeftViewModel() As LeftViewModel
            Get
                Return GetProperty(Function() LeftViewModel)
            End Get
            Set(ByVal value As LeftViewModel)
                SetProperty(Function() LeftViewModel, value)
            End Set
        End Property
        Public Property RightViewModel() As RightViewModel
            Get
                Return GetProperty(Function() RightViewModel)
            End Get
            Set(ByVal value As RightViewModel)
                SetProperty(Function() RightViewModel, value)
            End Set
        End Property
        Public Property SplashScreenViewModel() As SplashScreenViewModel
            Get
                Return GetProperty(Function() SplashScreenViewModel)
            End Get
            Set(ByVal value As SplashScreenViewModel)
                SetProperty(Function() SplashScreenViewModel, value)
            End Set
        End Property
    End Class
End Namespace