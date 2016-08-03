namespace SA41Team10b_Form
{
    partial class BookingSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingSearchForm));
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblFacName = new System.Windows.Forms.Label();
            this.cmbFacilites = new System.Windows.Forms.ComboBox();
            this.cmbCustName = new System.Windows.Forms.ComboBox();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.btnCancelSearch = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(30, 59);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(131, 20);
            this.lblCustName.TabIndex = 33;
            this.lblCustName.Text = "Customer Name";
            // 
            // lblFacName
            // 
            this.lblFacName.AutoSize = true;
            this.lblFacName.Location = new System.Drawing.Point(50, 111);
            this.lblFacName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFacName.Name = "lblFacName";
            this.lblFacName.Size = new System.Drawing.Size(111, 20);
            this.lblFacName.TabIndex = 35;
            this.lblFacName.Text = "Facility Name";
            // 
            // cmbFacilites
            // 
            this.cmbFacilites.FormattingEnabled = true;
            this.cmbFacilites.Location = new System.Drawing.Point(194, 111);
            this.cmbFacilites.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbFacilites.Name = "cmbFacilites";
            this.cmbFacilites.Size = new System.Drawing.Size(388, 28);
            this.cmbFacilites.TabIndex = 36;
            // 
            // cmbCustName
            // 
            this.cmbCustName.FormattingEnabled = true;
            this.cmbCustName.Location = new System.Drawing.Point(194, 51);
            this.cmbCustName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbCustName.Name = "cmbCustName";
            this.cmbCustName.Size = new System.Drawing.Size(388, 28);
            this.cmbCustName.TabIndex = 37;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Location = new System.Drawing.Point(194, 169);
            this.dtpIssueDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(388, 27);
            this.dtpIssueDate.TabIndex = 39;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(64, 169);
            this.lblIssueDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(90, 20);
            this.lblIssueDate.TabIndex = 38;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnCancelSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelSearch.Image")));
            this.btnCancelSearch.Location = new System.Drawing.Point(409, 235);
            this.btnCancelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(169, 41);
            this.btnCancelSearch.TabIndex = 48;
            this.btnCancelSearch.Text = "&Cancel Search";
            this.btnCancelSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelSearch.UseVisualStyleBackColor = true;
            // 
            // btnListAll
            // 
            this.btnListAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAll.Image = ((System.Drawing.Image)(resources.GetObject("btnListAll.Image")));
            this.btnListAll.Location = new System.Drawing.Point(241, 233);
            this.btnListAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(160, 43);
            this.btnListAll.TabIndex = 47;
            this.btnListAll.Text = "&List All";
            this.btnListAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListAll.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(75, 233);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(158, 45);
            this.BtnSearch.TabIndex = 45;
            this.BtnSearch.Text = " &Search";
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BookingSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 314);
            this.Controls.Add(this.btnCancelSearch);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.cmbCustName);
            this.Controls.Add(this.lblFacName);
            this.Controls.Add(this.cmbFacilites);
            this.Controls.Add(this.lblCustName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "BookingSearchForm";
            this.Text = "BookingSearchForm";
            this.Load += new System.EventHandler(this.BookingSearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblFacName;
        private System.Windows.Forms.ComboBox cmbFacilites;
        private System.Windows.Forms.ComboBox cmbCustName;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Button btnCancelSearch;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button BtnSearch;
    }
}