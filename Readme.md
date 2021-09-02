<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578466/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2126)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/HowToCopyClipboard/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/HowToCopyClipboard/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/HowToCopyClipboard/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/HowToCopyClipboard/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Copy Data from a PivotGrid Control into the Clipboard


<p>The following example demonstrates how to copy data from the <strong>PivotGridControl</strong> into the system clipboard.</p>


<h3>Description</h3>

<p>First, it is necessary to add the <strong>ContextMenu</strong> with a single &quot;Copy to Clipboard&quot; menu item to a <strong>PivotGridControl</strong>&#39;s <strong>ContextMenu</strong> property. This context menu is invoked when an end-user right-clicks within the Data Area. Then this menu&#39;s <strong>Click</strong> event can be handled to copy data to the clipboard. To copy the selected cells to the clipboard, the <strong>PivotGridControl.CopySelectionToClipboard</strong> method is used.</p><p>To determine whether the selection is not empty, and so whether it is necessary to invoke the context menu, the <strong>PivotGridControl.ContextMenuOpening</strong> event should be handled.</p>

<br/>


