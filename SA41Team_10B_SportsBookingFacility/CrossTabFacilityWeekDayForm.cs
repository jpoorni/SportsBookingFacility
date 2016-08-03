﻿using System;
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
    public partial class CrossTabFacilityWeekDayForm : Form
    {
        public CrossTabFacilityWeekDayForm()
        {
            InitializeComponent();
        }

        private void CrossTabFacilityWeekDayForm_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("CrossTabFacilityWeekDayReport.rpt");
            CrossTabFacilityWeekDayCrystalReportViewer.ReportSource = cryRpt;
            CrossTabFacilityWeekDayCrystalReportViewer.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
