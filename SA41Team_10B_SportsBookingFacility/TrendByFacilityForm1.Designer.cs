namespace SA41Team_10B_SportsBookingFacility
{
    partial class TrendByFacilityForm1
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
            this.TrendByFacilityForm1CrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // TrendByFacilityForm1CrystalReportViewer
            // 
            this.TrendByFacilityForm1CrystalReportViewer.ActiveViewIndex = -1;
            this.TrendByFacilityForm1CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrendByFacilityForm1CrystalReportViewer.CachedPageNumberPerDoc = 10;
            this.TrendByFacilityForm1CrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TrendByFacilityForm1CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrendByFacilityForm1CrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.TrendByFacilityForm1CrystalReportViewer.Name = "TrendByFacilityForm1CrystalReportViewer";
            this.TrendByFacilityForm1CrystalReportViewer.Size = new System.Drawing.Size(719, 482);
            this.TrendByFacilityForm1CrystalReportViewer.TabIndex = 0;
            this.TrendByFacilityForm1CrystalReportViewer.Load += new System.EventHandler(this.TrendByFacilityForm1CrystalReportViewer_Load);
            // 
            // TrendByFacilityForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 482);
            this.Controls.Add(this.TrendByFacilityForm1CrystalReportViewer);
            this.Name = "TrendByFacilityForm1";
            this.Text = "TrendByFacilityForm";
            this.Load += new System.EventHandler(this.TrendByFacilityForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer TrendByFacilityForm1CrystalReportViewer;
    }
}