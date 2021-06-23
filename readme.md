
_files to look at:_

* [Form1.cs](./CS/piesCustomExport/Form1.cs) (VB: [Form1.vb](./VB/piesCustomExport/Form1.vb))

# Dashboard for WinForms - How to Export Customized Pie Dashboard Item

The following example shows how to export a Pie dashboard item with customized totals: 

![pies-custom-export](/images/pies-custom-export.png)

The [CustomExportEventArgs.GetPrintableControls](http://docs.devexpress.devx/Dashboard/DevExpress.DashboardCommon.CustomExportEventArgs.GetPrintableControls?v=20.2) method obtains the printable control when you handle the [DashboardDesigner.CustomExport](http://docs.devexpress.devx/Dashboard/DevExpress.DashboardWin.DashboardDesigner.CustomExport?v=20.2) event. The [DashboardDesigner.DashboardItemControlUpdated](http://docs.devexpress.devx/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemControlUpdated?v=20.2) event is raised to obtain and customize the underlying Pie control.
