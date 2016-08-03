using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace SA41Team_10B_SportsBookingFacility
{
    public partial class TrendByWeekDayForm : Form
    {
        public TrendByWeekDayForm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void TrendByWeekDayForm_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("TrendByWeekDayReport1.rpt");
            TrendByWeekDayCrystalReportViewer.ReportSource = cryRpt;
            TrendByWeekDayCrystalReportViewer.Refresh();
            
        }

        private void TrendByWeekDayCrystalReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
