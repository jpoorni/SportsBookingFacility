namespace SA41Team_10B_SportsBookingFacility
{
    partial class CrossTabFacilityWeekDayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CrossTabFacilityWeekDayCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrossTabFacilityWeekDayCrystalReportViewer
            // 
            this.CrossTabFacilityWeekDayCrystalReportViewer.ActiveViewIndex = -1;
            this.CrossTabFacilityWeekDayCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrossTabFacilityWeekDayCrystalReportViewer.CachedPageNumberPerDoc = 10;
            this.CrossTabFacilityWeekDayCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrossTabFacilityWeekDayCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrossTabFacilityWeekDayCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CrossTabFacilityWeekDayCrystalReportViewer.Name = "CrossTabFacilityWeekDayCrystalReportViewer";
            this.CrossTabFacilityWeekDayCrystalReportViewer.Size = new System.Drawing.Size(904, 507);
            this.CrossTabFacilityWeekDayCrystalReportViewer.TabIndex = 0;
            this.CrossTabFacilityWeekDayCrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // CrossTabFacilityWeekDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 507);
            this.Controls.Add(this.CrossTabFacilityWeekDayCrystalReportViewer);
            this.Name = "CrossTabFacilityWeekDayForm";
            this.Text = "CrossTabFacilityWeekDayForm";
            this.Load += new System.EventHandler(this.CrossTabFacilityWeekDayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrossTabFacilityWeekDayCrystalReportViewer;
    }
}