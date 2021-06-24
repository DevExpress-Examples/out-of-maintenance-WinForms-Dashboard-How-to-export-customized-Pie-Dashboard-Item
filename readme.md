
_files to look at:_

* [Form1.cs](./CS/piesCustomExport/Form1.cs) (VB: [Form1.vb](./VB/piesCustomExport/Form1.vb))

# Dashboard for WinForms - How to Export Customized Pie Dashboard Item

The following example shows how to export a Pie dashboard item with customized totals: 

![pies-custom-export](/images/pies-custom-export.png)

The [CustomExportEventArgs.GetPrintableControls](http://docs.devexpress.devx/Dashboard/DevExpress.DashboardCommon.CustomExportEventArgs.GetPrintableControls?v=20.2) method obtains the printable control when you handle the [DashboardDesigner.CustomExport](http://docs.devexpress.devx/Dashboard/DevExpress.DashboardWin.DashboardDesigner.CustomExport?v=20.2) event. The [DashboardDesigner.DashboardItemControlUpdated](http://docs.devexpress.devx/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemControlUpdated?v=20.2) event is raised to obtain and customize the underlying Pie control.

## Documentation

* [Printing and Exporting](https://docs.devexpress.com/Dashboard/15181)
* [Custom Export](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.CustomExport)

## More Examples
* [Dashboard for WinForms - How to add custom information to the exported dashboard](https://supportcenter.devexpress.com/ticket/details/t466558)
