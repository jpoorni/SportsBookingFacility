namespace SA41Team10b_Form
{
    partial class BookingDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingDetailsForm));
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.lblFacilityName = new System.Windows.Forms.Label();
            this.cmbCustName = new System.Windows.Forms.ComboBox();
            this.cmbFacilityName = new System.Windows.Forms.ComboBox();
            this.cmbTimeSlot = new System.Windows.Forms.ComboBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(40, 36);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(131, 20);
            this.lblCustName.TabIndex = 1;
            this.lblCustName.Text = "Customer Name";
            // 
            // lblTimeSlot
            // 
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Location = new System.Drawing.Point(91, 83);
            this.lblTimeSlot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Size = new System.Drawing.Size(80, 20);
            this.lblTimeSlot.TabIndex = 2;
            this.lblTimeSlot.Text = "Time Slot";
            // 
            // lblFacilityName
            // 
            this.lblFacilityName.AutoSize = true;
            this.lblFacilityName.Location = new System.Drawing.Point(60, 131);
            this.lblFacilityName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFacilityName.Name = "lblFacilityName";
            this.lblFacilityName.Size = new System.Drawing.Size(111, 20);
            this.lblFacilityName.TabIndex = 3;
            this.lblFacilityName.Text = "Facility Name";
            // 
            // cmbCustName
            // 
            this.cmbCustName.FormattingEnabled = true;
            this.cmbCustName.Location = new System.Drawing.Point(209, 36);
            this.cmbCustName.Margin = new System.Windows.Forms.Padding(5);
            this.cmbCustName.Name = "cmbCustName";
            this.cmbCustName.Size = new System.Drawing.Size(354, 28);
            this.cmbCustName.TabIndex = 6;
            // 
            // cmbFacilityName
            // 
            this.cmbFacilityName.FormattingEnabled = true;
            this.cmbFacilityName.Location = new System.Drawing.Point(209, 131);
            this.cmbFacilityName.Margin = new System.Windows.Forms.Padding(5);
            this.cmbFacilityName.Name = "cmbFacilityName";
            this.cmbFacilityName.Size = new System.Drawing.Size(354, 28);
            this.cmbFacilityName.TabIndex = 7;
            // 
            // cmbTimeSlot
            // 
            this.cmbTimeSlot.FormattingEnabled = true;
            this.cmbTimeSlot.Location = new System.Drawing.Point(209, 83);
            this.cmbTimeSlot.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTimeSlot.Name = "cmbTimeSlot";
            this.cmbTimeSlot.Size = new System.Drawing.Size(354, 28);
            this.cmbTimeSlot.TabIndex = 8;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(81, 180);
            this.lblIssueDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(90, 20);
            this.lblIssueDate.TabIndex = 9;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Location = new System.Drawing.Point(209, 180);
            this.dtpIssueDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(354, 27);
            this.dtpIssueDate.TabIndex = 10;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(258, 231);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(120, 45);
            this.BtnSave.TabIndex = 34;
            this.BtnSave.Text = "  &Save";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BookingDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 296);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.cmbTimeSlot);
            this.Controls.Add(this.cmbFacilityName);
            this.Controls.Add(this.cmbCustName);
            this.Controls.Add(this.lblFacilityName);
            this.Controls.Add(this.lblTimeSlot);
            this.Controls.Add(this.lblCustName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BookingDetailsForm";
            this.Text = "n";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.Label lblFacilityName;
        private System.Windows.Forms.ComboBox cmbCustName;
        private System.Windows.Forms.ComboBox cmbFacilityName;
        private System.Windows.Forms.ComboBox cmbTimeSlot;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Button BtnSave;
    }
}