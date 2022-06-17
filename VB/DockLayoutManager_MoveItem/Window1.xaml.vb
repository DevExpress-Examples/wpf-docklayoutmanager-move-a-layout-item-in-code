Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Layout.Core

Namespace DockLayoutManager_MoveItem

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub buttonMove_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
'#Region "#1"
            Me.dockLayoutManager1.LayoutController.Move(Me.layoutItemEditor1, Me.layoutItemButton1, MoveType.Left)
'#End Region  ' #1
        End Sub
    End Class
End Namespace
