namespace SA41Team10b_Form
{
    partial class FacilityListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacilityListForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.lblFacilityName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.dgvFacilityList = new System.Windows.Forms.DataGridView();
            this.FacilityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilityList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSearch);
            this.groupBox2.Controls.Add(this.lblFacilityName);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(20, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(636, 114);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facility Search";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BtnSearch.Location = new System.Drawing.Point(483, 29);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(138, 41);
            this.BtnSearch.TabIndex = 36;
            this.BtnSearch.Text = " Search";
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblFacilityName
            // 
            this.lblFacilityName.AutoSize = true;
            this.lblFacilityName.Location = new System.Drawing.Point(23, 40);
            this.lblFacilityName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFacilityName.Name = "lblFacilityName";
            this.lblFacilityName.Size = new System.Drawing.Size(111, 20);
            this.lblFacilityName.TabIndex = 24;
            this.lblFacilityName.Text = "Facility Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(330, 28);
            this.comboBox1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnList);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.BtnPrint);
            this.groupBox1.Controls.Add(this.dgvFacilityList);
            this.groupBox1.Location = new System.Drawing.Point(7, 147);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(649, 439);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facility List";
            // 
            // BtnList
            // 
            this.BtnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BtnList.Image = ((System.Drawing.Image)(resources.GetObject("BtnList.Image")));
            this.BtnList.Location = new System.Drawing.Point(390, 362);
            this.BtnList.Margin = new System.Windows.Forms.Padding(4);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(114, 45);
            this.BtnList.TabIndex = 43;
            this.BtnList.Text = "  &List All";
            this.BtnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.Location = new System.Drawing.Point(65, 362);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(119, 45);
            this.BtnNew.TabIndex = 41;
            this.BtnNew.Text = "  &Add";
            this.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.Location = new System.Drawing.Point(232, 362);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(114, 45);
            this.BtnPrint.TabIndex = 40;
            this.BtnPrint.Text = "   &Print";
            this.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrint.UseVisualStyleBackColor = true;
            // 
            // dgvFacilityList
            // 
            this.dgvFacilityList.AllowUserToAddRows = false;
            this.dgvFacilityList.AllowUserToDeleteRows = false;
            this.dgvFacilityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacilityList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacilityID,
            this.Column2,
            this.Column1});
            this.dgvFacilityList.Location = new System.Drawing.Point(13, 26);
            this.dgvFacilityList.Margin = new System.Windows.Forms.Padding(5);
            this.dgvFacilityList.Name = "dgvFacilityList";
            this.dgvFacilityList.ReadOnly = true;
            this.dgvFacilityList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacilityList.Size = new System.Drawing.Size(621, 314);
            this.dgvFacilityList.TabIndex = 11;
            this.dgvFacilityList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacilityList_CellDoubleClick);
            // 
            // FacilityID
            // 
            this.FacilityID.DataPropertyName = "FacilityId";
            this.FacilityID.HeaderText = "FacilityId";
            this.FacilityID.Name = "FacilityID";
            this.FacilityID.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Facility Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Remarks";
            this.Column1.HeaderText = "Remark";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FacilityListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 597);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FacilityListForm";
            this.Text = "Facilities";
            this.Load += new System.EventHandler(this.FacilityListForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilityList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label lblFacilityName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridView dgvFacilityList;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

    }
}