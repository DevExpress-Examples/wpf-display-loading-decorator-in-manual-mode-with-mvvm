Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace DXSample.ViewModel
    Public Class MainViewModel
        Inherits ViewModelBase

        Private ReadOnly Property Service() As INavigationService
            Get
                Return Me.GetService(Of INavigationService)()
            End Get
        End Property
        Public Property TileCollection() As ObservableCollection(Of TileViewModel)

        ''' <summary>
        ''' Initializes a new instance of the MainViewModel class.
        ''' </summary>
        Public Sub New()
            TileCollection = New ObservableCollection(Of TileViewModel)()
            TileCollection.Add(New TileViewModel() With {.Caption = "Home View", .NavigateCommand = New DelegateCommand(Sub()
                Service.Navigate("HomeView", Nothing, Me)
            End Sub), .GlyphUri = "Home_32x32.png", .Group = "TileBar control"})
            TileCollection.Add(New TileViewModel() With {.Caption = "CategoryView", .Children = New ObservableCollection(Of TileViewModel)() From {New TileViewModel() With {.Caption = "Category I", .NavigateCommand = New DelegateCommand(Sub()
                Service.Navigate("SubCategory1View", Nothing, Me)
            End Sub)}, New TileViewModel() With {.Caption = "Category II", .NavigateCommand = New DelegateCommand(Function()
       Service.Navigate("SubCategory2View", Nothing, Me)
            End Function)}, New TileViewModel() With {.Caption = "Category III", .NavigateCommand = New DelegateCommand(Function()
       Service.Navigate("SubCategory3View", Nothing, Me)
            End Function)}, }, .NavigateCommand = New DelegateCommand(Sub()
    Service.Navigate("CategoryView", Nothing, Me)
            End Sub)})
        End Sub
    End Class

End Namespace
