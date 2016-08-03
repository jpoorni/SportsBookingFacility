namespace SA41Team10b_Form
{
    partial class FacilityDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacilityDetailForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFacilityID = new System.Windows.Forms.TextBox();
            this.lblFacilityID = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFacilityName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 27);
            this.txtName.TabIndex = 50;
            // 
            // txtFacilityID
            // 
            this.txtFacilityID.Enabled = false;
            this.txtFacilityID.Location = new System.Drawing.Point(173, 19);
            this.txtFacilityID.Name = "txtFacilityID";
            this.txtFacilityID.Size = new System.Drawing.Size(271, 27);
            this.txtFacilityID.TabIndex = 49;
            // 
            // lblFacilityID
            // 
            this.lblFacilityID.AutoSize = true;
            this.lblFacilityID.Enabled = false;
            this.lblFacilityID.Location = new System.Drawing.Point(47, 22);
            this.lblFacilityID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFacilityID.Name = "lblFacilityID";
            this.lblFacilityID.Size = new System.Drawing.Size(84, 20);
            this.lblFacilityID.TabIndex = 48;
            this.lblFacilityID.Text = "Facility ID";
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(173, 280);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(120, 45);
            this.BtnSave.TabIndex = 47;
            this.BtnSave.Text = "  &Save";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(173, 117);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(271, 121);
            this.txtRemarks.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Remarks";
            // 
            // lblFacilityName
            // 
            this.lblFacilityName.AutoSize = true;
            this.lblFacilityName.Location = new System.Drawing.Point(20, 68);
            this.lblFacilityName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFacilityName.Name = "lblFacilityName";
            this.lblFacilityName.Size = new System.Drawing.Size(111, 20);
            this.lblFacilityName.TabIndex = 44;
            this.lblFacilityName.Text = "Facility Name";
            // 
            // FacilityDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 344);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtFacilityID);
            this.Controls.Add(this.lblFacilityID);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFacilityName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FacilityDetailForm";
            this.Text = "FacilityDetailForm";
            this.Load += new System.EventHandler(this.FacilityDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFacilityID;
        private System.Windows.Forms.Label lblFacilityID;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFacilityName;

    }
}