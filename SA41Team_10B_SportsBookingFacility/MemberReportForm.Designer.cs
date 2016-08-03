namespace SA41Team_10B_SportsBookingFacility
{
    partial class MemberReportForm
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
            this.memberCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // memberCrystalReportViewer
            // 
            this.memberCrystalReportViewer.ActiveViewIndex = -1;
            this.memberCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memberCrystalReportViewer.CachedPageNumberPerDoc = 10;
            this.memberCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.memberCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.memberCrystalReportViewer.Name = "memberCrystalReportViewer";
            this.memberCrystalReportViewer.Size = new System.Drawing.Size(1168, 522);
            this.memberCrystalReportViewer.TabIndex = 0;
            this.memberCrystalReportViewer.Load += new System.EventHandler(this.memberCrystalReportViewer_Load);
            // 
            // MemberReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 522);
            this.Controls.Add(this.memberCrystalReportViewer);
            this.Name = "MemberReportForm";
            this.Text = "MemberReportForm";
            this.Load += new System.EventHandler(this.MemberReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer memberCrystalReportViewer;

    }
}