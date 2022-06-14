Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.PivotGrid
Imports HowToBindToMDB.NwindDataSetTableAdapters

Namespace HowToBindToMDB
	Partial Public Class MainWindow
		Inherits Window
		Private salesPersonDataTable As New NwindDataSet.SalesPersonDataTable()
		Private salesPersonDataAdapter As New SalesPersonTableAdapter()

		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = salesPersonDataTable
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			salesPersonDataAdapter.Fill(salesPersonDataTable)
		End Sub

		Private Sub CopyToClipboard_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			pivotGridControl1.CopySelectionToClipboard()
		End Sub

        Private Sub pivotGridControl1_ContextMenuOpening(ByVal sender As Object, _
                                                         ByVal e As ContextMenuEventArgs)
            If pivotGridControl1.Selection.IsEmpty Then
                e.Handled = True
            End If
        End Sub
	End Class
End Namespace
