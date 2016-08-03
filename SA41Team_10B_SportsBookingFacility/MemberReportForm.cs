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
    public partial class MemberReportForm : Form
    {
        public MemberReportForm()
        {
            InitializeComponent();
        }

        private void MemberReportForm_Load(object sender, EventArgs e)
        {

            //this.memberReportViewer.RefreshReport();
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("MemberReport.rpt");
            memberCrystalReportViewer.ReportSource = cryRpt;
            memberCrystalReportViewer.Refresh();
        }

        private void memberCrystalReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
