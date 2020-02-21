namespace proiectPaw
{
    partial class DataBindingSample
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
            this.btDelete = new System.Windows.Forms.Button();
            this.gbDoctor = new System.Windows.Forms.GroupBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.btAddNewDoctor = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbYearsExperience = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gbDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(690, 415);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(98, 23);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Delete Doctor";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // gbDoctor
            // 
            this.gbDoctor.Controls.Add(this.button1);
            this.gbDoctor.Controls.Add(this.tbPhoneNumber);
            this.gbDoctor.Controls.Add(this.lbPhoneNumber);
            this.gbDoctor.Controls.Add(this.btAddNewDoctor);
            this.gbDoctor.Controls.Add(this.tbLastName);
            this.gbDoctor.Controls.Add(this.tbFirstName);
            this.gbDoctor.Controls.Add(this.tbId);
            this.gbDoctor.Controls.Add(this.lbYearsExperience);
            this.gbDoctor.Controls.Add(this.lbLastName);
            this.gbDoctor.Controls.Add(this.lbFirstName);
            this.gbDoctor.Controls.Add(this.lbId);
            this.gbDoctor.Location = new System.Drawing.Point(13, 36);
            this.gbDoctor.Name = "gbDoctor";
            this.gbDoctor.Size = new System.Drawing.Size(775, 164);
            this.gbDoctor.TabIndex = 5;
            this.gbDoctor.TabStop = false;
            this.gbDoctor.Text = "NewDoctor";
            this.gbDoctor.Enter += new System.EventHandler(this.gbDoctor_Enter);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(139, 126);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(121, 20);
            this.tbPhoneNumber.TabIndex = 13;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(18, 132);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lbPhoneNumber.TabIndex = 12;
            this.lbPhoneNumber.Text = "Phone Number";
            // 
            // btAddNewDoctor
            // 
            this.btAddNewDoctor.Location = new System.Drawing.Point(611, 53);
            this.btAddNewDoctor.Name = "btAddNewDoctor";
            this.btAddNewDoctor.Size = new System.Drawing.Size(126, 23);
            this.btAddNewDoctor.TabIndex = 8;
            this.btAddNewDoctor.Text = "Add A New Doctor";
            this.btAddNewDoctor.UseVisualStyleBackColor = true;
            this.btAddNewDoctor.Click += new System.EventHandler(this.btAddNewDoctor_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(139, 95);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(121, 20);
            this.tbLastName.TabIndex = 7;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(139, 60);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(121, 20);
            this.tbFirstName.TabIndex = 6;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(139, 28);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(121, 20);
            this.tbId.TabIndex = 5;
            // 
            // lbYearsExperience
            // 
            this.lbYearsExperience.AutoSize = true;
            this.lbYearsExperience.Location = new System.Drawing.Point(18, 134);
            this.lbYearsExperience.Name = "lbYearsExperience";
            this.lbYearsExperience.Size = new System.Drawing.Size(0, 13);
            this.lbYearsExperience.TabIndex = 3;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(18, 98);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(55, 13);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "LastName";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(18, 63);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(54, 13);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "FirstName";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(18, 32);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id";
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Location = new System.Drawing.Point(13, 226);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.Size = new System.Drawing.Size(775, 168);
            this.dgvDoctors.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(611, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Return To Doctors";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DataBindingSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDoctors);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.gbDoctor);
            this.Name = "DataBindingSample";
            this.Text = "DataBindingSample";
            this.Load += new System.EventHandler(this.DataBindingSample_Load);
            this.gbDoctor.ResumeLayout(false);
            this.gbDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.GroupBox gbDoctor;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Button btAddNewDoctor;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbYearsExperience;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.Button button1;
    }
}