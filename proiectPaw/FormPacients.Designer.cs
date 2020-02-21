namespace proiectPaw
{
    partial class FormPacients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacients));
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.epIdPatient = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCnp = new System.Windows.Forms.ErrorProvider(this.components);
            this.epHospitalized = new System.Windows.Forms.ErrorProvider(this.components);
            this.lvPatient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbDoctor = new System.Windows.Forms.GroupBox();
            this.btPrescription = new System.Windows.Forms.Button();
            this.tbIdDoctor = new System.Windows.Forms.TextBox();
            this.lbIdDoctor = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btPrinting = new System.Windows.Forms.ToolStripButton();
            this.btnPageSetup = new System.Windows.Forms.ToolStripButton();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.btReturn = new System.Windows.Forms.Button();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIdPatient = new System.Windows.Forms.Label();
            this.cbIsHospitalized = new System.Windows.Forms.CheckBox();
            this.tbCnp = new System.Windows.Forms.TextBox();
            this.lbCnp = new System.Windows.Forms.Label();
            this.btAddNewPatient = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbIdPatient = new System.Windows.Forms.TextBox();
            this.lbYearsExperience = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbIdPatients = new System.Windows.Forms.Label();
            this.epIdDoctor = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.epIdPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCnp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHospitalized)).BeginInit();
            this.gbDoctor.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epIdDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(458, 415);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 16;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(568, 415);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 17;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // epIdPatient
            // 
            this.epIdPatient.ContainerControl = this;
            // 
            // epFirstName
            // 
            this.epFirstName.ContainerControl = this;
            // 
            // epLastName
            // 
            this.epLastName.ContainerControl = this;
            // 
            // epCnp
            // 
            this.epCnp.ContainerControl = this;
            // 
            // epHospitalized
            // 
            this.epHospitalized.ContainerControl = this;
            // 
            // lvPatient
            // 
            this.lvPatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvPatient.FullRowSelect = true;
            this.lvPatient.GridLines = true;
            this.lvPatient.Location = new System.Drawing.Point(10, 233);
            this.lvPatient.Name = "lvPatient";
            this.lvPatient.Size = new System.Drawing.Size(653, 176);
            this.lvPatient.TabIndex = 18;
            this.lvPatient.UseCompatibleStateImageBehavior = false;
            this.lvPatient.View = System.Windows.Forms.View.Details;
            this.lvPatient.SelectedIndexChanged += new System.EventHandler(this.lvPatient_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Patient";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CNP";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Is Hospitalized";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id Doctor";
            this.columnHeader6.Width = 80;
            // 
            // gbDoctor
            // 
            this.gbDoctor.Controls.Add(this.btPrescription);
            this.gbDoctor.Controls.Add(this.tbIdDoctor);
            this.gbDoctor.Controls.Add(this.lbIdDoctor);
            this.gbDoctor.Controls.Add(this.toolStrip1);
            this.gbDoctor.Controls.Add(this.btReturn);
            this.gbDoctor.Controls.Add(this.lbPhoneNumber);
            this.gbDoctor.Controls.Add(this.label1);
            this.gbDoctor.Controls.Add(this.label2);
            this.gbDoctor.Controls.Add(this.lbIdPatient);
            this.gbDoctor.Controls.Add(this.cbIsHospitalized);
            this.gbDoctor.Controls.Add(this.tbCnp);
            this.gbDoctor.Controls.Add(this.lbCnp);
            this.gbDoctor.Controls.Add(this.btAddNewPatient);
            this.gbDoctor.Controls.Add(this.tbLastName);
            this.gbDoctor.Controls.Add(this.tbFirstName);
            this.gbDoctor.Controls.Add(this.tbIdPatient);
            this.gbDoctor.Controls.Add(this.lbYearsExperience);
            this.gbDoctor.Controls.Add(this.lbLastName);
            this.gbDoctor.Controls.Add(this.lbFirstName);
            this.gbDoctor.Controls.Add(this.lbIdPatients);
            this.gbDoctor.Location = new System.Drawing.Point(13, 27);
            this.gbDoctor.Name = "gbDoctor";
            this.gbDoctor.Size = new System.Drawing.Size(650, 192);
            this.gbDoctor.TabIndex = 2;
            this.gbDoctor.TabStop = false;
            this.gbDoctor.Text = "NewPatient";
            this.gbDoctor.Enter += new System.EventHandler(this.gbDoctor_Enter);
            // 
            // btPrescription
            // 
            this.btPrescription.Location = new System.Drawing.Point(332, 117);
            this.btPrescription.Name = "btPrescription";
            this.btPrescription.Size = new System.Drawing.Size(126, 23);
            this.btPrescription.TabIndex = 23;
            this.btPrescription.Text = "Managing Prescription";
            this.btPrescription.UseVisualStyleBackColor = true;
            this.btPrescription.Click += new System.EventHandler(this.btPrescription_Click);
            // 
            // tbIdDoctor
            // 
            this.tbIdDoctor.Location = new System.Drawing.Point(139, 158);
            this.tbIdDoctor.Name = "tbIdDoctor";
            this.tbIdDoctor.Size = new System.Drawing.Size(121, 20);
            this.tbIdDoctor.TabIndex = 22;
            this.tbIdDoctor.Validating += new System.ComponentModel.CancelEventHandler(this.tbIdDoctor_Validating);
            this.tbIdDoctor.Validated += new System.EventHandler(this.tbIdDoctor_Validated);
            // 
            // lbIdDoctor
            // 
            this.lbIdDoctor.AutoSize = true;
            this.lbIdDoctor.Location = new System.Drawing.Point(48, 160);
            this.lbIdDoctor.Name = "lbIdDoctor";
            this.lbIdDoctor.Size = new System.Drawing.Size(51, 13);
            this.lbIdDoctor.TabIndex = 21;
            this.lbIdDoctor.Text = "Id Doctor";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.btPrinting,
            this.btnPageSetup,
            this.btnPrintPreview});
            this.toolStrip1.Location = new System.Drawing.Point(550, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(97, 173);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(94, 20);
            this.saveToolStripButton.Text = "&Save ";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // btPrinting
            // 
            this.btPrinting.Image = ((System.Drawing.Image)(resources.GetObject("btPrinting.Image")));
            this.btPrinting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPrinting.Name = "btPrinting";
            this.btPrinting.Size = new System.Drawing.Size(94, 20);
            this.btPrinting.Text = "Printing";
            this.btPrinting.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.Image = ((System.Drawing.Image)(resources.GetObject("btnPageSetup.Image")));
            this.btnPageSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(94, 20);
            this.btnPageSetup.Text = "Page Setup";
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPreview.Image")));
            this.btnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(94, 20);
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btReturn
            // 
            this.btReturn.CausesValidation = false;
            this.btReturn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btReturn.Location = new System.Drawing.Point(330, 155);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(128, 23);
            this.btReturn.TabIndex = 20;
            this.btReturn.Text = "Return To Doctors";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(48, 127);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(29, 13);
            this.lbPhoneNumber.TabIndex = 19;
            this.lbPhoneNumber.Text = "CNP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "FirstName";
            // 
            // lbIdPatient
            // 
            this.lbIdPatient.AutoSize = true;
            this.lbIdPatient.Location = new System.Drawing.Point(48, 31);
            this.lbIdPatient.Name = "lbIdPatient";
            this.lbIdPatient.Size = new System.Drawing.Size(52, 13);
            this.lbIdPatient.TabIndex = 16;
            this.lbIdPatient.Text = "Id Patient";
            // 
            // cbIsHospitalized
            // 
            this.cbIsHospitalized.AutoSize = true;
            this.cbIsHospitalized.Location = new System.Drawing.Point(330, 32);
            this.cbIsHospitalized.Name = "cbIsHospitalized";
            this.cbIsHospitalized.Size = new System.Drawing.Size(100, 17);
            this.cbIsHospitalized.TabIndex = 15;
            this.cbIsHospitalized.Text = "Is Hospitalized?";
            this.cbIsHospitalized.UseVisualStyleBackColor = true;
            this.cbIsHospitalized.Validating += new System.ComponentModel.CancelEventHandler(this.cbIsHospitalized_Validating);
            this.cbIsHospitalized.Validated += new System.EventHandler(this.cbIsHospitalized_Validated);
            // 
            // tbCnp
            // 
            this.tbCnp.Location = new System.Drawing.Point(139, 126);
            this.tbCnp.Name = "tbCnp";
            this.tbCnp.Size = new System.Drawing.Size(121, 20);
            this.tbCnp.TabIndex = 13;
            this.tbCnp.TextChanged += new System.EventHandler(this.tbCnp_TextChanged);
            this.tbCnp.Validating += new System.ComponentModel.CancelEventHandler(this.tbCnp_Validating);
            this.tbCnp.Validated += new System.EventHandler(this.tbCnp_Validated);
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
            this.btAddNewPatient.Location = new System.Drawing.Point(332, 83);
            this.btAddNewPatient.Name = "btAddNewPatient";
            this.btAddNewPatient.Size = new System.Drawing.Size(126, 23);
            this.btAddNewPatient.TabIndex = 8;
            this.btAddNewPatient.Text = "Add A New Patient";
            this.btAddNewPatient.UseVisualStyleBackColor = true;
            this.btAddNewPatient.Click += new System.EventHandler(this.btAddNewPatient_Click);
            this.btAddNewPatient.Validating += new System.ComponentModel.CancelEventHandler(this.btAddNewPatient_Validating);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(139, 95);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(121, 20);
            this.tbLastName.TabIndex = 7;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            this.tbLastName.Validated += new System.EventHandler(this.tbLastName_Validated);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(139, 60);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(121, 20);
            this.tbFirstName.TabIndex = 6;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            this.tbFirstName.Validated += new System.EventHandler(this.tbFirstName_Validated);
            // 
            // tbIdPatient
            // 
            this.tbIdPatient.Location = new System.Drawing.Point(139, 29);
            this.tbIdPatient.Name = "tbIdPatient";
            this.tbIdPatient.Size = new System.Drawing.Size(121, 20);
            this.tbIdPatient.TabIndex = 5;
            this.tbIdPatient.Validating += new System.ComponentModel.CancelEventHandler(this.tbIdPatient_Validating);
            this.tbIdPatient.Validated += new System.EventHandler(this.tbIdPatient_Validated);
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
            // epIdDoctor
            // 
            this.epIdDoctor.ContainerControl = this;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // FormPacients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proiectPaw.Properties.Resources.Chrysanthemum;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.lvPatient);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.gbDoctor);
            this.Controls.Add(this.btEdit);
            this.Name = "FormPacients";
            this.Text = "FormPacients";
            this.Load += new System.EventHandler(this.FormPacients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epIdPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCnp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHospitalized)).EndInit();
            this.gbDoctor.ResumeLayout(false);
            this.gbDoctor.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epIdDoctor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDoctor;
        private System.Windows.Forms.TextBox tbCnp;
        private System.Windows.Forms.Label lbCnp;
        private System.Windows.Forms.Button btAddNewPatient;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbIdPatient;
        private System.Windows.Forms.Label lbYearsExperience;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbIdPatients;
        private System.Windows.Forms.CheckBox cbIsHospitalized;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ErrorProvider epIdPatient;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epCnp;
        private System.Windows.Forms.ErrorProvider epHospitalized;
        private System.Windows.Forms.ListView lvPatient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIdPatient;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.TextBox tbIdDoctor;
        private System.Windows.Forms.Label lbIdDoctor;
        private System.Windows.Forms.ErrorProvider epIdDoctor;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btPrescription;
        private System.Windows.Forms.ToolStripButton btPrinting;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripButton btnPageSetup;
        private System.Windows.Forms.ToolStripButton btnPrintPreview;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}