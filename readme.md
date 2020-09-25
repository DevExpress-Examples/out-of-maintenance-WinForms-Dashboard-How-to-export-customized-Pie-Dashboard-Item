
_files to look at:_

* [Form1.cs](./CS/piesCustomExport/Form1.cs)

# WinForms Dashboard - How to export customized Pie Dashboard Item

The following example shows how to export a Pie dashboard item with customised totals when you handle the [DashboardDesigner.CustomExport](http://docs.devexpress.devx/Dashboard/DevExpress.DashboardWin.DashboardDesigner.CustomExport?v=20.2) event. The [CustomExportEventArgs.GetPrintableControls](http://docs.devexpress.devx/Dashboard/DevExpress.DashboardCommon.CustomExportEventArgs.GetPrintableControls?v=20.2) method is used to obtain the printable control. The [DashboardDesigner.DashboardItemControlUpdated](http://docs.devexpress.devx/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemControlUpdated?v=20.2) event is raised to obtain and customize the underlying Pie control.

![pies-custom-export](/images/pies-custom-export.png)
