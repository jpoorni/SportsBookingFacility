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
    public partial class TrendByFacilityForm1 : Form
    {
        public TrendByFacilityForm1()
        {
            InitializeComponent();
        }

        private void TrendByFacilityForm1_Load(object sender, EventArgs e)
        {
            
                ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("TrendByFacilityReport.rpt");
            TrendByFacilityForm1CrystalReportViewer.ReportSource = cryRpt;
            TrendByFacilityForm1CrystalReportViewer.Refresh();
        }

        private void TrendByFacilityForm1CrystalReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
