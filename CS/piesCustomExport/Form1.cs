using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piesCustomExport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dashboardDesigner1.CreateRibbon();
            dashboardDesigner1.LoadDashboard(@"..\..\data\nwind.xml");
        }

        private void dashboardDesigner1_DashboardItemControlUpdated(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e)
        {
            if (e.ChartControl != null)
            {
                PieDashboardItem pieItem = dashboardDesigner1.Dashboard.Items[e.DashboardItemName] as PieDashboardItem;
                if (pieItem == null) return;
                foreach (Series series in e.ChartControl.Series)
                {
                    (series.View as PieSeriesView).TotalLabel.Visible = true;
                    (series.View as PieSeriesView).TotalLabel.TextPattern = "Total {TV:c0}";
                }
            }
        }

        private void dashboardDesigner1_CustomExport(object sender, CustomExportEventArgs e)
        {
            foreach (var printControl in e.GetPrintableControls())
            {
                if (printControl.Value is XRChart)
                {
                    var pieItemName = printControl.Key;
                    IDashboardControl dashboardControl = (IDashboardControl)sender;
                    PieDashboardItem pieDashboardItem = dashboardControl.Dashboard.Items[pieItemName] as PieDashboardItem;
                    if (pieDashboardItem == null) return;
                    XRChart pieChart = printControl.Value as XRChart;
                    foreach (Series series in pieChart.Series)
                    {
                        (series.View as PieSeriesView).TotalLabel.Visible = true;
                        (series.View as PieSeriesView).TotalLabel.TextPattern = "Total {TV:c0}";
                    }
                }
            }
        }
    }
}
