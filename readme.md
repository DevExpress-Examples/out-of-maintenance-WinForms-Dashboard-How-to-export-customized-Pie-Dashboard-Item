<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/298352805/20.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T934652)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for WinForms - How to Export Customized Pie Dashboard Item

The following example shows how to export a Pie dashboard item with customized totals: 

![pies-custom-export](/images/pies-custom-export.png)

The [CustomExportEventArgs.GetPrintableControls](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomExportEventArgs.GetPrintableControls?v=20.2) method obtains the printable control when you handle the [DashboardDesigner.CustomExport](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.CustomExport?v=20.2) event. The [DashboardDesigner.DashboardItemControlUpdated](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemControlUpdated?v=20.2) event is raised to obtain and customize the underlying Pie control.

<!-- default file list -->
## Files to Look At

* [Form1.cs](./CS/piesCustomExport/Form1.cs) (VB: [Form1.vb](./VB/piesCustomExport/Form1.vb))
<!-- default file list end -->

## Documentation

* [Printing and Exporting](https://docs.devexpress.com/Dashboard/15181)
* [Custom Export](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.CustomExport)

## More Examples
* [Dashboard for WinForms - How to add custom information to the exported dashboard](https://supportcenter.devexpress.com/ticket/details/t466558)
