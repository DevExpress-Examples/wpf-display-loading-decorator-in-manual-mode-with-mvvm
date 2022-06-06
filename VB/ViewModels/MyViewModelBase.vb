Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace DXSample.ViewModels

    Public Class MyViewModelBase
        Inherits ViewModelBase

        Public Property Caption As String
            Get
                Return GetProperty(Function() Me.Caption)
            End Get

            Set(ByVal value As String)
                SetProperty(Function() Caption, value)
            End Set
        End Property

        <Command>
        Public Sub ChangeText()
            TryCast(CType(Me, ISupportParentViewModel).ParentViewModel, MainViewModel).SplashScreenViewModel.Caption = Caption
        End Sub
    End Class
End Namespace
