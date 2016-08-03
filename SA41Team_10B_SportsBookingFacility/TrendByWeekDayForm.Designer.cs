namespace SA41Team_10B_SportsBookingFacility
{
    partial class TrendByWeekDayForm
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
            this.TrendByWeekDayCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // TrendByWeekDayCrystalReportViewer
            // 
            this.TrendByWeekDayCrystalReportViewer.ActiveViewIndex = -1;
            this.TrendByWeekDayCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrendByWeekDayCrystalReportViewer.CachedPageNumberPerDoc = 10;
            this.TrendByWeekDayCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TrendByWeekDayCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrendByWeekDayCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.TrendByWeekDayCrystalReportViewer.Name = "TrendByWeekDayCrystalReportViewer";
            this.TrendByWeekDayCrystalReportViewer.Size = new System.Drawing.Size(828, 518);
            this.TrendByWeekDayCrystalReportViewer.TabIndex = 0;
            this.TrendByWeekDayCrystalReportViewer.Load += new System.EventHandler(this.TrendByWeekDayCrystalReportViewer_Load);
            // 
            // TrendByWeekDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 518);
            this.Controls.Add(this.TrendByWeekDayCrystalReportViewer);
            this.Name = "TrendByWeekDayForm";
            this.Text = "TrendByWeekDayForm";
            this.Load += new System.EventHandler(this.TrendByWeekDayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer TrendByWeekDayCrystalReportViewer;

    }
}