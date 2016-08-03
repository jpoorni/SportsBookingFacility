namespace SA41Team10b_Form
{
    partial class PrintForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optInactive = new System.Windows.Forms.RadioButton();
            this.optActive = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.optFemale = new System.Windows.Forms.RadioButton();
            this.optMale = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 157);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Print All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 157);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Print ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optInactive);
            this.groupBox2.Controls.Add(this.optActive);
            this.groupBox2.Location = new System.Drawing.Point(27, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(394, 52);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // optInactive
            // 
            this.optInactive.AutoSize = true;
            this.optInactive.Location = new System.Drawing.Point(221, 18);
            this.optInactive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.optInactive.Name = "optInactive";
            this.optInactive.Size = new System.Drawing.Size(87, 24);
            this.optInactive.TabIndex = 1;
            this.optInactive.TabStop = true;
            this.optInactive.Text = "Inactive";
            this.optInactive.UseVisualStyleBackColor = true;
            // 
            // optActive
            // 
            this.optActive.AutoSize = true;
            this.optActive.Location = new System.Drawing.Point(31, 18);
            this.optActive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.optActive.Name = "optActive";
            this.optActive.Size = new System.Drawing.Size(76, 24);
            this.optActive.TabIndex = 0;
            this.optActive.TabStop = true;
            this.optActive.Text = "Active";
            this.optActive.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.optFemale);
            this.groupBox3.Controls.Add(this.optMale);
            this.groupBox3.Location = new System.Drawing.Point(27, 76);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox3.Size = new System.Drawing.Size(394, 52);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Location = new System.Drawing.Point(221, 18);
            this.optFemale.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(85, 24);
            this.optFemale.TabIndex = 1;
            this.optFemale.TabStop = true;
            this.optFemale.Text = "Female";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Location = new System.Drawing.Point(31, 18);
            this.optMale.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(66, 24);
            this.optMale.TabIndex = 0;
            this.optMale.TabStop = true;
            this.optMale.Text = "Male";
            this.optMale.UseVisualStyleBackColor = true;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 221);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optInactive;
        private System.Windows.Forms.RadioButton optActive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton optFemale;
        private System.Windows.Forms.RadioButton optMale;
    }
}