Imports System
Imports System.Windows.Input
Imports System.Collections.ObjectModel

Namespace DXSample.ViewModel
    Public Class TileViewModel

        Public Property Caption() As String
        Public Property Children() As ObservableCollection(Of TileViewModel)
        Public Property NavigateCommand() As ICommand
        Public ReadOnly Property IsHasChildren() As Boolean
            Get
                Return Children.Count <> 0
            End Get
        End Property
        Public Property GlyphUri() As String
        Public Property Group() As String
        ''' <summary>
        ''' Initializes a new instance of the TileObject class.
        ''' </summary>
        Public Sub New()
            Caption = String.Empty
            Children = New ObservableCollection(Of TileViewModel)()
            NavigateCommand = Nothing
            GlyphUri = String.Empty
            Group = String.Empty
        End Sub
    End Class
End Namespace
