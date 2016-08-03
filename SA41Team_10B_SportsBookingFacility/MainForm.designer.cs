namespace SA41Team10b_Form
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportsFacilitiesInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingOfFacilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportListOfMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staMain = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.businessTransactionToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1852, 31);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberInformationToolStripMenuItem,
            this.sportsFacilitiesInformationToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(89, 27);
            this.fileToolStripMenuItem.Text = "Maintain";
            // 
            // memberInformationToolStripMenuItem
            // 
            this.memberInformationToolStripMenuItem.Name = "memberInformationToolStripMenuItem";
            this.memberInformationToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.memberInformationToolStripMenuItem.Text = "Customer ";
            this.memberInformationToolStripMenuItem.Click += new System.EventHandler(this.memberInformationToolStripMenuItem_Click);
            // 
            // sportsFacilitiesInformationToolStripMenuItem
            // 
            this.sportsFacilitiesInformationToolStripMenuItem.Name = "sportsFacilitiesInformationToolStripMenuItem";
            this.sportsFacilitiesInformationToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.sportsFacilitiesInformationToolStripMenuItem.Text = "Sports Facilities ";
            this.sportsFacilitiesInformationToolStripMenuItem.Click += new System.EventHandler(this.sportsFacilitiesInformationToolStripMenuItem_Click);
            // 
            // businessTransactionToolStripMenuItem
            // 
            this.businessTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingOfFacilityToolStripMenuItem});
            this.businessTransactionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessTransactionToolStripMenuItem.Name = "businessTransactionToolStripMenuItem";
            this.businessTransactionToolStripMenuItem.Size = new System.Drawing.Size(179, 27);
            this.businessTransactionToolStripMenuItem.Text = "Business Transaction";
            // 
            // bookingOfFacilityToolStripMenuItem
            // 
            this.bookingOfFacilityToolStripMenuItem.Name = "bookingOfFacilityToolStripMenuItem";
            this.bookingOfFacilityToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.bookingOfFacilityToolStripMenuItem.Text = "Place a Booking";
            this.bookingOfFacilityToolStripMenuItem.Click += new System.EventHandler(this.bookingOfFacilityToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportListOfMembersToolStripMenuItem,
            this.manageMentReportToolStripMenuItem,
            this.transactionOutputToolStripMenuItem,
            this.chartReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // reportListOfMembersToolStripMenuItem
            // 
            this.reportListOfMembersToolStripMenuItem.Name = "reportListOfMembersToolStripMenuItem";
            this.reportListOfMembersToolStripMenuItem.Size = new System.Drawing.Size(376, 28);
            this.reportListOfMembersToolStripMenuItem.Text = "Customer List";
            this.reportListOfMembersToolStripMenuItem.Click += new System.EventHandler(this.reportListOfMembersToolStripMenuItem_Click);
            // 
            // manageMentReportToolStripMenuItem
            // 
            this.manageMentReportToolStripMenuItem.Name = "manageMentReportToolStripMenuItem";
            this.manageMentReportToolStripMenuItem.Size = new System.Drawing.Size(376, 28);
            this.manageMentReportToolStripMenuItem.Text = "Booking Trend By Facility";
            this.manageMentReportToolStripMenuItem.Click += new System.EventHandler(this.manageMentReportToolStripMenuItem_Click);
            // 
            // transactionOutputToolStripMenuItem
            // 
            this.transactionOutputToolStripMenuItem.Name = "transactionOutputToolStripMenuItem";
            this.transactionOutputToolStripMenuItem.Size = new System.Drawing.Size(376, 28);
            this.transactionOutputToolStripMenuItem.Text = "Booking Trend By WeekDay";
            this.transactionOutputToolStripMenuItem.Click += new System.EventHandler(this.transactionOutputToolStripMenuItem_Click);
            // 
            // chartReportToolStripMenuItem
            // 
            this.chartReportToolStripMenuItem.Name = "chartReportToolStripMenuItem";
            this.chartReportToolStripMenuItem.Size = new System.Drawing.Size(376, 28);
            this.chartReportToolStripMenuItem.Text = "Booking Trend By Facility Per WeekDay";
            this.chartReportToolStripMenuItem.Click += new System.EventHandler(this.chartReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // staMain
            // 
            this.staMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staMain.Location = new System.Drawing.Point(0, 1025);
            this.staMain.Name = "staMain";
            this.staMain.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.staMain.Size = new System.Drawing.Size(1852, 22);
            this.staMain.TabIndex = 28;
            this.staMain.Text = "statusStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1852, 1047);
            this.Controls.Add(this.staMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Text = "SportsBooking Facility";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportsFacilitiesInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem businessTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingOfFacilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportListOfMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip staMain;
    }
}