namespace proiectPaw
{
    partial class FormPrescription
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
            this.components = new System.ComponentModel.Container();
            this.gbPrescription = new System.Windows.Forms.GroupBox();
            this.dtpPrescription = new System.Windows.Forms.DateTimePicker();
            this.btReturn = new System.Windows.Forms.Button();
            this.lbPatientId = new System.Windows.Forms.Label();
            this.lbDoctorName = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbIdPrescription = new System.Windows.Forms.Label();
            this.tbPatientId = new System.Windows.Forms.TextBox();
            this.lbCnp = new System.Windows.Forms.Label();
            this.btAddNewPatient = new System.Windows.Forms.Button();
            this.tbDoctorName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbIdPrescription = new System.Windows.Forms.TextBox();
            this.lbYearsExperience = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbIdPatients = new System.Windows.Forms.Label();
            this.lvPrescription = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.epId = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDoctorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPatientId = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPrescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDoctorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPatientId)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPrescription
            // 
            this.gbPrescription.Controls.Add(this.dtpPrescription);
            this.gbPrescription.Controls.Add(this.btReturn);
            this.gbPrescription.Controls.Add(this.lbPatientId);
            this.gbPrescription.Controls.Add(this.lbDoctorName);
            this.gbPrescription.Controls.Add(this.lbDescription);
            this.gbPrescription.Controls.Add(this.lbIdPrescription);
            this.gbPrescription.Controls.Add(this.tbPatientId);
            this.gbPrescription.Controls.Add(this.lbCnp);
            this.gbPrescription.Controls.Add(this.btAddNewPatient);
            this.gbPrescription.Controls.Add(this.tbDoctorName);
            this.gbPrescription.Controls.Add(this.tbDescription);
            this.gbPrescription.Controls.Add(this.tbIdPrescription);
            this.gbPrescription.Controls.Add(this.lbYearsExperience);
            this.gbPrescription.Controls.Add(this.lbLastName);
            this.gbPrescription.Controls.Add(this.lbFirstName);
            this.gbPrescription.Controls.Add(this.lbIdPatients);
            this.gbPrescription.Location = new System.Drawing.Point(20, 26);
            this.gbPrescription.Name = "gbPrescription";
            this.gbPrescription.Size = new System.Drawing.Size(650, 185);
            this.gbPrescription.TabIndex = 3;
            this.gbPrescription.TabStop = false;
            this.gbPrescription.Text = "NewPrescription";
            this.gbPrescription.Enter += new System.EventHandler(this.gbDoctor_Enter);
            // 
            // dtpPrescription
            // 
            this.dtpPrescription.Location = new System.Drawing.Point(350, 29);
            this.dtpPrescription.Name = "dtpPrescription";
            this.dtpPrescription.Size = new System.Drawing.Size(200, 20);
            this.dtpPrescription.TabIndex = 21;
            // 
            // btReturn
            // 
            this.btReturn.CausesValidation = false;
            this.btReturn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btReturn.Location = new System.Drawing.Point(491, 124);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(138, 23);
            this.btReturn.TabIndex = 20;
            this.btReturn.Text = "Return To Patients";
            this.btReturn.UseVisualStyleBackColor = true;
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
            this.tbPatientId.Validating += new System.ComponentModel.CancelEventHandler(this.tbCnp_Validating);
            this.tbPatientId.Validated += new System.EventHandler(this.tbCnp_Validated);
            // 
            // lbCnp
            // 
            this.lbCnp.AutoSize = true;
            this.lbCnp.Location = new System.Drawing.Point(18, 132);
            this.lbCnp.Name = "lbCnp";
            this.lbCnp.Size = new System.Drawing.Size(0, 13);
            this.lbCnp.TabIndex = 12;
            // 
            // btAddNewPatient
            // 
            this.btAddNewPatient.Location = new System.Drawing.Point(332, 123);
            this.btAddNewPatient.Name = "btAddNewPatient";
            this.btAddNewPatient.Size = new System.Drawing.Size(135, 23);
            this.btAddNewPatient.TabIndex = 8;
            this.btAddNewPatient.Text = "Add A New Prescription";
            this.btAddNewPatient.UseVisualStyleBackColor = true;
            this.btAddNewPatient.Click += new System.EventHandler(this.btAddNewPatient_Click);
            // 
            // tbDoctorName
            // 
            this.tbDoctorName.Location = new System.Drawing.Point(139, 95);
            this.tbDoctorName.Name = "tbDoctorName";
            this.tbDoctorName.Size = new System.Drawing.Size(121, 20);
            this.tbDoctorName.TabIndex = 7;
            this.tbDoctorName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            this.tbDoctorName.Validated += new System.EventHandler(this.tbLastName_Validated);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(139, 60);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(121, 20);
            this.tbDescription.TabIndex = 6;
            this.tbDescription.Validating += new System.ComponentModel.CancelEventHandler(this.tbDescription_Validating);
            this.tbDescription.Validated += new System.EventHandler(this.tbDescription_Validated);
            // 
            // tbIdPrescription
            // 
            this.tbIdPrescription.Location = new System.Drawing.Point(139, 29);
            this.tbIdPrescription.Name = "tbIdPrescription";
            this.tbIdPrescription.Size = new System.Drawing.Size(121, 20);
            this.tbIdPrescription.TabIndex = 5;
            this.tbIdPrescription.Validating += new System.ComponentModel.CancelEventHandler(this.tbIdPrescription_Validating);
            this.tbIdPrescription.Validated += new System.EventHandler(this.tbIdPrescription_Validated);
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
            // lvPrescription
            // 
            this.lvPrescription.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvPrescription.FullRowSelect = true;
            this.lvPrescription.GridLines = true;
            this.lvPrescription.Location = new System.Drawing.Point(20, 231);
            this.lvPrescription.Name = "lvPrescription";
            this.lvPrescription.Size = new System.Drawing.Size(653, 176);
            this.lvPrescription.TabIndex = 19;
            this.lvPrescription.UseCompatibleStateImageBehavior = false;
            this.lvPrescription.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Doctor Name";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Patient Id";
            this.columnHeader4.Width = 74;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prescription Date";
            this.columnHeader5.Width = 94;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(453, 415);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(80, 23);
            this.btEdit.TabIndex = 20;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(564, 415);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // epId
            // 
            this.epId.ContainerControl = this;
            // 
            // epDescription
            // 
            this.epDescription.ContainerControl = this;
            // 
            // epDoctorName
            // 
            this.epDoctorName.ContainerControl = this;
            // 
            // epPatientId
            // 
            this.epPatientId.ContainerControl = this;
            // 
            // FormPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proiectPaw.Properties.Resources.Chrysanthemum;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.lvPrescription);
            this.Controls.Add(this.gbPrescription);
            this.Name = "FormPrescription";
            this.Text = "FormPrescription";
            this.Load += new System.EventHandler(this.FormPrescription_Load);
            this.gbPrescription.ResumeLayout(false);
            this.gbPrescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDoctorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPatientId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrescription;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label lbPatientId;
        private System.Windows.Forms.Label lbDoctorName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbIdPrescription;
        private System.Windows.Forms.TextBox tbPatientId;
        private System.Windows.Forms.Label lbCnp;
        private System.Windows.Forms.Button btAddNewPatient;
        private System.Windows.Forms.TextBox tbDoctorName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbIdPrescription;
        private System.Windows.Forms.Label lbYearsExperience;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbIdPatients;
        private System.Windows.Forms.DateTimePicker dtpPrescription;
        private System.Windows.Forms.ListView lvPrescription;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ErrorProvider epId;
        private System.Windows.Forms.ErrorProvider epDescription;
        private System.Windows.Forms.ErrorProvider epDoctorName;
        private System.Windows.Forms.ErrorProvider epPatientId;
    }
}