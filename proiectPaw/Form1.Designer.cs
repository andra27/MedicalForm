namespace proiectPaw
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.binarySerializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialize = new System.Windows.Forms.ToolStripMenuItem();
            this.deserialize = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.export = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDoctor = new System.Windows.Forms.GroupBox();
            this.btChart = new System.Windows.Forms.Button();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.btPatients = new System.Windows.Forms.Button();
            this.btAddNewDoctor = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbYearsExperience = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.epId = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.lvDoctors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarySerializationToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // binarySerializationToolStripMenuItem
            // 
            this.binarySerializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialize,
            this.deserialize});
            this.binarySerializationToolStripMenuItem.Name = "binarySerializationToolStripMenuItem";
            this.binarySerializationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.binarySerializationToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.binarySerializationToolStripMenuItem.Text = "Binary Serialization";
            // 
            // serialize
            // 
            this.serialize.Name = "serialize";
            this.serialize.Size = new System.Drawing.Size(129, 22);
            this.serialize.Text = "Serialize ";
            this.serialize.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserialize
            // 
            this.deserialize.Name = "deserialize";
            this.deserialize.Size = new System.Drawing.Size(129, 22);
            this.deserialize.Text = "Deserialize";
            this.deserialize.Click += new System.EventHandler(this.deserialize_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.export});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.exportToolStripMenuItem.Text = "Text File";
            // 
            // export
            // 
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(107, 22);
            this.export.Text = "Export";
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // gbDoctor
            // 
            this.gbDoctor.Controls.Add(this.button1);
            this.gbDoctor.Controls.Add(this.btChart);
            this.gbDoctor.Controls.Add(this.tbPhoneNumber);
            this.gbDoctor.Controls.Add(this.lbPhoneNumber);
            this.gbDoctor.Controls.Add(this.btPatients);
            this.gbDoctor.Controls.Add(this.btAddNewDoctor);
            this.gbDoctor.Controls.Add(this.tbLastName);
            this.gbDoctor.Controls.Add(this.tbFirstName);
            this.gbDoctor.Controls.Add(this.tbId);
            this.gbDoctor.Controls.Add(this.lbYearsExperience);
            this.gbDoctor.Controls.Add(this.lbLastName);
            this.gbDoctor.Controls.Add(this.lbFirstName);
            this.gbDoctor.Controls.Add(this.lbId);
            this.gbDoctor.Location = new System.Drawing.Point(13, 43);
            this.gbDoctor.Name = "gbDoctor";
            this.gbDoctor.Size = new System.Drawing.Size(775, 164);
            this.gbDoctor.TabIndex = 1;
            this.gbDoctor.TabStop = false;
            this.gbDoctor.Text = "NewDoctor";
            // 
            // btChart
            // 
            this.btChart.Location = new System.Drawing.Point(611, 122);
            this.btChart.Name = "btChart";
            this.btChart.Size = new System.Drawing.Size(126, 23);
            this.btChart.TabIndex = 5;
            this.btChart.Text = "Show me the chart";
            this.btChart.UseVisualStyleBackColor = true;
            this.btChart.Click += new System.EventHandler(this.btChart_Click);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(139, 126);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(121, 20);
            this.tbPhoneNumber.TabIndex = 13;
            this.tbPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhoneNumber_Validating);
            this.tbPhoneNumber.Validated += new System.EventHandler(this.tbPhoneNumber_Validated);
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
            // btPatients
            // 
            this.btPatients.Location = new System.Drawing.Point(611, 88);
            this.btPatients.Name = "btPatients";
            this.btPatients.Size = new System.Drawing.Size(126, 23);
            this.btPatients.TabIndex = 9;
            this.btPatients.Text = "Managing Patients";
            this.btPatients.UseVisualStyleBackColor = true;
            this.btPatients.Click += new System.EventHandler(this.btPatients_Click);
            // 
            // btAddNewDoctor
            // 
            this.btAddNewDoctor.Location = new System.Drawing.Point(611, 53);
            this.btAddNewDoctor.Name = "btAddNewDoctor";
            this.btAddNewDoctor.Size = new System.Drawing.Size(126, 23);
            this.btAddNewDoctor.TabIndex = 8;
            this.btAddNewDoctor.Text = "Add A New Doctor";
            this.btAddNewDoctor.UseVisualStyleBackColor = true;
            this.btAddNewDoctor.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(139, 95);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(121, 20);
            this.tbLastName.TabIndex = 7;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
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
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(139, 28);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(121, 20);
            this.tbId.TabIndex = 5;
            this.tbId.Validating += new System.ComponentModel.CancelEventHandler(this.tbId_Validating);
            this.tbId.Validated += new System.EventHandler(this.tbId_Validated);
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
            // epId
            // 
            this.epId.ContainerControl = this;
            // 
            // epFirstName
            // 
            this.epFirstName.ContainerControl = this;
            // 
            // epLastName
            // 
            this.epLastName.ContainerControl = this;
            // 
            // epPhoneNumber
            // 
            this.epPhoneNumber.ContainerControl = this;
            // 
            // lvDoctors
            // 
            this.lvDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDoctors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDoctors.FullRowSelect = true;
            this.lvDoctors.GridLines = true;
            this.lvDoctors.Location = new System.Drawing.Point(13, 239);
            this.lvDoctors.Name = "lvDoctors";
            this.lvDoctors.Size = new System.Drawing.Size(775, 153);
            this.lvDoctors.TabIndex = 2;
            this.lvDoctors.UseCompatibleStateImageBehavior = false;
            this.lvDoctors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 43;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone Number";
            this.columnHeader4.Width = 93;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(577, 398);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(95, 23);
            this.btEdit.TabIndex = 3;
            this.btEdit.Text = "Edit Doctor";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(690, 398);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(98, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete Doctor";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Open DataBindingEx";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::proiectPaw.Properties.Resources.Chrysanthemum;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.lvDoctors);
            this.Controls.Add(this.gbDoctor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbDoctor.ResumeLayout(false);
            this.gbDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhoneNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gbDoctor;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbYearsExperience;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.ErrorProvider epId;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epPhoneNumber;
        private System.Windows.Forms.Button btPatients;
        private System.Windows.Forms.Button btAddNewDoctor;
        private System.Windows.Forms.ListView lvDoctors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.ToolStripMenuItem binarySerializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialize;
        private System.Windows.Forms.ToolStripMenuItem deserialize;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem export;
        private System.Windows.Forms.Button btChart;
        private System.Windows.Forms.Button button1;
    }
}

