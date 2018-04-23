Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Wpf.Layout.Core

Namespace DockLayoutManager_MoveItem
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub buttonMove_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
'			#Region "#1"
			dockLayoutManager1.LayoutController.Move(layoutItemEditor1, layoutItemButton1, MoveType.Left)
'			#End Region '#1
		End Sub


	End Class
End Namespace
