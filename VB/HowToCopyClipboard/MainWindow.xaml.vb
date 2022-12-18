Imports System.Windows
Imports System.Windows.Controls
Imports HowToBindToMDB.NwindDataSetTableAdapters

Namespace HowToBindToMDB

    Public Partial Class MainWindow
        Inherits Window

        Private salesPersonDataTable As NwindDataSet.SalesPersonDataTable = New NwindDataSet.SalesPersonDataTable()

        Private salesPersonDataAdapter As SalesPersonTableAdapter = New SalesPersonTableAdapter()

        Public Sub New()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource = salesPersonDataTable
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            salesPersonDataAdapter.Fill(salesPersonDataTable)
        End Sub

        Private Sub CopyToClipboard_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.pivotGridControl1.CopySelectionToClipboard()
        End Sub

        Private Sub pivotGridControl1_ContextMenuOpening(ByVal sender As Object, ByVal e As ContextMenuEventArgs)
            If Me.pivotGridControl1.Selection.IsEmpty Then e.Handled = True
        End Sub
    End Class
End Namespace
