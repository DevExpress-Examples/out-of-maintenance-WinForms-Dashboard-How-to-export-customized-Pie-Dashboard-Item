Imports Microsoft.VisualBasic
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.XtraCharts
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace piesCustomExport
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			dashboardDesigner1.CreateRibbon()
			dashboardDesigner1.LoadDashboard("nwind.xml")
		End Sub

		Private Sub dashboardDesigner1_DashboardItemControlUpdated(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardItemControlEventArgs) Handles dashboardDesigner1.DashboardItemControlUpdated
			If e.ChartControl IsNot Nothing Then
				Dim pieItem As PieDashboardItem = TryCast(dashboardDesigner1.Dashboard.Items(e.DashboardItemName), PieDashboardItem)
				If pieItem Is Nothing Then
					Return
				End If
				For Each series As Series In e.ChartControl.Series
					TryCast(series.View, PieSeriesView).TotalLabel.Visible = True
					TryCast(series.View, PieSeriesView).TotalLabel.TextPattern = "Total {TV:c0}"
				Next series
			End If
		End Sub

		Private Sub dashboardDesigner1_CustomExport(ByVal sender As Object, ByVal e As CustomExportEventArgs) Handles dashboardDesigner1.CustomExport
			For Each printControl In e.GetPrintableControls()
				If TypeOf printControl.Value Is XRChart Then
					Dim pieItemName = printControl.Key
					Dim dashboardControl As IDashboardControl = CType(sender, IDashboardControl)
					Dim pieDashboardItem As PieDashboardItem = TryCast(dashboardControl.Dashboard.Items(pieItemName), PieDashboardItem)
					If pieDashboardItem Is Nothing Then
						Return
					End If
					Dim pieChart As XRChart = TryCast(printControl.Value, XRChart)
					For Each series As Series In pieChart.Series
						TryCast(series.View, PieSeriesView).TotalLabel.Visible = True
						TryCast(series.View, PieSeriesView).TotalLabel.TextPattern = "Total {TV:c0}"
					Next series
				End If
			Next printControl
		End Sub
	End Class
End Namespace
