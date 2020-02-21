namespace proiectPaw
{
    partial class EditFormPrescriptions
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
            this.gbPrescription = new System.Windows.Forms.GroupBox();
            this.dtpPrescription = new System.Windows.Forms.DateTimePicker();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbPatientId = new System.Windows.Forms.Label();
            this.lbDoctorName = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbIdPrescription = new System.Windows.Forms.Label();
            this.tbPatientId = new System.Windows.Forms.TextBox();
            this.lbCnp = new System.Windows.Forms.Label();
            this.bTOk = new System.Windows.Forms.Button();
            this.tbDoctorName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbIdPrescription = new System.Windows.Forms.TextBox();
            this.lbYearsExperience = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbIdPatients = new System.Windows.Forms.Label();
            this.gbPrescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrescription
            // 
            this.gbPrescription.Controls.Add(this.dtpPrescription);
            this.gbPrescription.Controls.Add(this.btCancel);
            this.gbPrescription.Controls.Add(this.lbPatientId);
            this.gbPrescription.Controls.Add(this.lbDoctorName);
            this.gbPrescription.Controls.Add(this.lbDescription);
            this.gbPrescription.Controls.Add(this.lbIdPrescription);
            this.gbPrescription.Controls.Add(this.tbPatientId);
            this.gbPrescription.Controls.Add(this.lbCnp);
            this.gbPrescription.Controls.Add(this.bTOk);
            this.gbPrescription.Controls.Add(this.tbDoctorName);
            this.gbPrescription.Controls.Add(this.tbDescription);
            this.gbPrescription.Controls.Add(this.tbIdPrescription);
            this.gbPrescription.Controls.Add(this.lbYearsExperience);
            this.gbPrescription.Controls.Add(this.lbLastName);
            this.gbPrescription.Controls.Add(this.lbFirstName);
            this.gbPrescription.Controls.Add(this.lbIdPatients);
            this.gbPrescription.Location = new System.Drawing.Point(23, 21);
            this.gbPrescription.Name = "gbPrescription";
            this.gbPrescription.Size = new System.Drawing.Size(520, 185);
            this.gbPrescription.TabIndex = 4;
            this.gbPrescription.TabStop = false;
            this.gbPrescription.Text = "Edit Prescription";
            this.gbPrescription.Enter += new System.EventHandler(this.gbPrescription_Enter);
            // 
            // dtpPrescription
            // 
            this.dtpPrescription.Location = new System.Drawing.Point(290, 29);
            this.dtpPrescription.Name = "dtpPrescription";
            this.dtpPrescription.Size = new System.Drawing.Size(200, 20);
            this.dtpPrescription.TabIndex = 21;
            // 
            // btCancel
            // 
            this.btCancel.CausesValidation = false;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(381, 124);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(67, 23);
            this.btCancel.TabIndex = 20;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // lbPatientId
            // 
            this.lbPatientId.AutoSize = true;
            this.lbPatientId.Location = new System.Drawing.Point(48, 127);
            this.lbPatientId.Name = "lbPatientId";
            this.lbPatientId.Size = new System.Drawing.Size(52, 13);
            this.lbPatientId.TabIndex = 19;
            this.lbPatientId.Text = "Patient Id";
            // 
            // lbDoctorName
            // 
            this.lbDoctorName.AutoSize = true;
            this.lbDoctorName.Location = new System.Drawing.Point(48, 93);
            this.lbDoctorName.Name = "lbDoctorName";
            this.lbDoctorName.Size = new System.Drawing.Size(70, 13);
            this.lbDoctorName.TabIndex = 18;
            this.lbDoctorName.Text = "Doctor Name";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(48, 58);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 17;
            this.lbDescription.Text = "Description";
            // 
            // lbIdPrescription
            // 
            this.lbIdPrescription.AutoSize = true;
            this.lbIdPrescription.Location = new System.Drawing.Point(48, 31);
            this.lbIdPrescription.Name = "lbIdPrescription";
            this.lbIdPrescription.Size = new System.Drawing.Size(18, 13);
            this.lbIdPrescription.TabIndex = 16;
            this.lbIdPrescription.Text = "ID";
            // 
            // tbPatientId
            // 
            this.tbPatientId.Location = new System.Drawing.Point(139, 126);
            this.tbPatientId.Name = "tbPatientId";
            this.tbPatientId.Size = new System.Drawing.Size(121, 20);
            this.tbPatientId.TabIndex = 13;
            // 
            // lbCnp
            // 
            this.lbCnp.AutoSize = true;
            this.lbCnp.Location = new System.Drawing.Point(18, 132);
            this.lbCnp.Name = "lbCnp";
            this.lbCnp.Size = new System.Drawing.Size(0, 13);
            this.lbCnp.TabIndex = 12;
            // 
            // bTOk
            // 
            this.bTOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bTOk.Location = new System.Drawing.Point(290, 124);
            this.bTOk.Name = "bTOk";
            this.bTOk.Size = new System.Drawing.Size(70, 23);
            this.bTOk.TabIndex = 8;
            this.bTOk.Text = "OK";
            this.bTOk.UseVisualStyleBackColor = true;
            this.bTOk.Click += new System.EventHandler(this.bTOk_Click);
            // 
            // tbDoctorName
            // 
            this.tbDoctorName.Location = new System.Drawing.Point(139, 95);
            this.tbDoctorName.Name = "tbDoctorName";
            this.tbDoctorName.Size = new System.Drawing.Size(121, 20);
            this.tbDoctorName.TabIndex = 7;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(139, 60);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(121, 20);
            this.tbDescription.TabIndex = 6;
            // 
            // tbIdPrescription
            // 
            this.tbIdPrescription.Location = new System.Drawing.Point(139, 29);
            this.tbIdPrescription.Name = "tbIdPrescription";
            this.tbIdPrescription.Size = new System.Drawing.Size(121, 20);
            this.tbIdPrescription.TabIndex = 5;
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
            this.lbLastName.Size = new System.Drawing.Size(0, 13);
            this.lbLastName.TabIndex = 2;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(18, 63);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(0, 13);
            this.lbFirstName.TabIndex = 1;
            // 
            // lbIdPatients
            // 
            this.lbIdPatients.AutoSize = true;
            this.lbIdPatients.Location = new System.Drawing.Point(18, 32);
            this.lbIdPatients.Name = "lbIdPatients";
            this.lbIdPatients.Size = new System.Drawing.Size(0, 13);
            this.lbIdPatients.TabIndex = 0;
            // 
            // EditFormPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proiectPaw.Properties.Resources.Chrysanthemum;
            this.ClientSize = new System.Drawing.Size(578, 235);
            this.Controls.Add(this.gbPrescription);
            this.Name = "EditFormPrescriptions";
            this.Text = "EditFormPrescriptions";
            this.Load += new System.EventHandler(this.EditFormPrescriptions_Load);
            this.gbPrescription.ResumeLayout(false);
            this.gbPrescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrescription;
        private System.Windows.Forms.DateTimePicker dtpPrescription;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbPatientId;
        private System.Windows.Forms.Label lbDoctorName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbIdPrescription;
        private System.Windows.Forms.TextBox tbPatientId;
        private System.Windows.Forms.Label lbCnp;
        private System.Windows.Forms.Button bTOk;
        private System.Windows.Forms.TextBox tbDoctorName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbIdPrescription;
        private System.Windows.Forms.Label lbYearsExperience;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbIdPatients;
    }
}