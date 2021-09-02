Imports System.Windows
Imports System.Windows.Controls
Imports HowToBindToMDB.NwindDataSetTableAdapters

Namespace HowToBindToMDB
	Partial Public Class MainWindow
		Inherits Window

'INSTANT VB NOTE: The variable salesPersonDataTable was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Private salesPersonDataTable_Conflict As New NwindDataSet.SalesPersonDataTable()
		Private salesPersonDataAdapter As New SalesPersonTableAdapter()
		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = salesPersonDataTable_Conflict
		End Sub
		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			salesPersonDataAdapter.Fill(salesPersonDataTable_Conflict)
		End Sub
		Private Sub CopyToClipboard_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			pivotGridControl1.CopySelectionToClipboard()
		End Sub
		Private Sub pivotGridControl1_ContextMenuOpening(ByVal sender As Object, ByVal e As ContextMenuEventArgs)
			If pivotGridControl1.Selection.IsEmpty Then
				e.Handled = True
			End If
		End Sub
	End Class
End Namespace
