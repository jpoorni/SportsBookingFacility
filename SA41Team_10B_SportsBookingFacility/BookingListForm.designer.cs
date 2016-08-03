namespace SA41Team10b_Form
{
    partial class BookingListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingListForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.BtnNewBooking = new System.Windows.Forms.Button();
            this.BtnPrintBookingReceipt = new System.Windows.Forms.Button();
            this.dgvBookingList = new System.Windows.Forms.DataGridView();
            this.btnListAll = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblFacName = new System.Windows.Forms.Label();
            this.cmbFacilites = new System.Windows.Forms.ComboBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelBooking);
            this.groupBox1.Controls.Add(this.BtnNewBooking);
            this.groupBox1.Controls.Add(this.BtnPrintBookingReceipt);
            this.groupBox1.Controls.Add(this.dgvBookingList);
            this.groupBox1.Location = new System.Drawing.Point(14, 255);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(750, 539);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking List";
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnCancelBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelBooking.Image")));
            this.btnCancelBooking.Location = new System.Drawing.Point(260, 468);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(182, 41);
            this.btnCancelBooking.TabIndex = 44;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            // 
            // BtnNewBooking
            // 
            this.BtnNewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewBooking.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewBooking.Image")));
            this.BtnNewBooking.Location = new System.Drawing.Point(72, 466);
            this.BtnNewBooking.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewBooking.Name = "BtnNewBooking";
            this.BtnNewBooking.Size = new System.Drawing.Size(165, 43);
            this.BtnNewBooking.TabIndex = 41;
            this.BtnNewBooking.Text = "&New Booking";
            this.BtnNewBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNewBooking.UseVisualStyleBackColor = true;
            this.BtnNewBooking.Click += new System.EventHandler(this.BtnNewBooking_Click);
            // 
            // BtnPrintBookingReceipt
            // 
            this.BtnPrintBookingReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BtnPrintBookingReceipt.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrintBookingReceipt.Image")));
            this.BtnPrintBookingReceipt.Location = new System.Drawing.Point(463, 468);
            this.BtnPrintBookingReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrintBookingReceipt.Name = "BtnPrintBookingReceipt";
            this.BtnPrintBookingReceipt.Size = new System.Drawing.Size(168, 41);
            this.BtnPrintBookingReceipt.TabIndex = 40;
            this.BtnPrintBookingReceipt.Text = "Print Receipt";
            this.BtnPrintBookingReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrintBookingReceipt.UseVisualStyleBackColor = true;
            // 
            // dgvBookingList
            // 
            this.dgvBookingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingList.Location = new System.Drawing.Point(20, 44);
            this.dgvBookingList.Margin = new System.Windows.Forms.Padding(5);
            this.dgvBookingList.Name = "dgvBookingList";
            this.dgvBookingList.ReadOnly = true;
            this.dgvBookingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookingList.Size = new System.Drawing.Size(703, 409);
            this.dgvBookingList.TabIndex = 3;
            // 
            // btnListAll
            // 
            this.btnListAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAll.Image = ((System.Drawing.Image)(resources.GetObject("btnListAll.Image")));
            this.btnListAll.Location = new System.Drawing.Point(287, 169);
            this.btnListAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(160, 43);
            this.btnListAll.TabIndex = 56;
            this.btnListAll.Text = "&List All";
            this.btnListAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(102, 167);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(158, 45);
            this.BtnSearch.TabIndex = 55;
            this.BtnSearch.Text = " &Search";
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Location = new System.Drawing.Point(158, 113);
            this.dtpIssueDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(388, 27);
            this.dtpIssueDate.TabIndex = 54;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(58, 118);
            this.lblIssueDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(90, 20);
            this.lblIssueDate.TabIndex = 53;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // lblFacName
            // 
            this.lblFacName.AutoSize = true;
            this.lblFacName.Location = new System.Drawing.Point(37, 66);
            this.lblFacName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFacName.Name = "lblFacName";
            this.lblFacName.Size = new System.Drawing.Size(111, 20);
            this.lblFacName.TabIndex = 50;
            this.lblFacName.Text = "Facility Name";
            // 
            // cmbFacilites
            // 
            this.cmbFacilites.FormattingEnabled = true;
            this.cmbFacilites.Location = new System.Drawing.Point(158, 66);
            this.cmbFacilites.Margin = new System.Windows.Forms.Padding(5);
            this.cmbFacilites.Name = "cmbFacilites";
            this.cmbFacilites.Size = new System.Drawing.Size(388, 28);
            this.cmbFacilites.TabIndex = 51;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(17, 23);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(131, 20);
            this.lblCustName.TabIndex = 49;
            this.lblCustName.Text = "Customer Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.lblCustName);
            this.groupBox2.Controls.Add(this.btnListAll);
            this.groupBox2.Controls.Add(this.BtnSearch);
            this.groupBox2.Controls.Add(this.lblFacName);
            this.groupBox2.Controls.Add(this.dtpIssueDate);
            this.groupBox2.Controls.Add(this.cmbFacilites);
            this.groupBox2.Controls.Add(this.lblIssueDate);
            this.groupBox2.Location = new System.Drawing.Point(24, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 221);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(388, 28);
            this.comboBox1.TabIndex = 57;
            // 
            // BookingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 777);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BookingListForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.BookingListForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBookingList;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Button BtnNewBooking;
        private System.Windows.Forms.Button BtnPrintBookingReceipt;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblFacName;
        private System.Windows.Forms.ComboBox cmbFacilites;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}