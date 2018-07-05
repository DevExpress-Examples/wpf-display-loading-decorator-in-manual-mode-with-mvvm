Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace DXSample.ViewModels
    Public Class MyViewModelBase
        Inherits ViewModelBase

        Public Property Caption() As String
            Get
                Return GetProperty(Function() Caption)
            End Get
            Set(ByVal value As String)
                SetProperty(Function() Caption, value)
            End Set
        End Property
        <Command> _
        Public Sub ChangeText()
            TryCast(DirectCast(Me, ISupportParentViewModel).ParentViewModel, MainViewModel).SplashScreenViewModel.Caption = Me.Caption
        End Sub
    End Class
End Namespace
