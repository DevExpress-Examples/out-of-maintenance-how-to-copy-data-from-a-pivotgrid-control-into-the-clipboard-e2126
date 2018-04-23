using System.Windows;
using System.Windows.Controls;
using HowToBindToMDB.NwindDataSetTableAdapters;

namespace HowToBindToMDB {
    public partial class MainWindow : Window {
        NwindDataSet.SalesPersonDataTable salesPersonDataTable = 
            new NwindDataSet.SalesPersonDataTable();
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();
        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = salesPersonDataTable;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            salesPersonDataAdapter.Fill(salesPersonDataTable);
        }
        private void CopyToClipboard_Click(object sender, RoutedEventArgs e) {
            pivotGridControl1.CopySelectionToClipboard();
        }
        private void pivotGridControl1_ContextMenuOpening(object sender, ContextMenuEventArgs e) {
            if(pivotGridControl1.Selection.IsEmpty) 
                e.Handled = true;
        }
    }
}
