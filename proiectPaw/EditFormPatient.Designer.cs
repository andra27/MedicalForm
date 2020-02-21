namespace proiectPaw
{
    partial class EditFormPatient
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
            this.tbIdPatient = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.cbIsHospitalized = new System.Windows.Forms.CheckBox();
            this.tbCnp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbIdPatient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbIdPatient
            // 
            this.tbIdPatient.Location = new System.Drawing.Point(105, 28);
            this.tbIdPatient.Name = "tbIdPatient";
            this.tbIdPatient.Size = new System.Drawing.Size(121, 20);
            this.tbIdPatient.TabIndex = 20;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(105, 60);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(121, 20);
            this.tbFirstName.TabIndex = 21;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(105, 91);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(121, 20);
            this.tbLastName.TabIndex = 22;
            // 
            // cbIsHospitalized
            // 
            this.cbIsHospitalized.AutoSize = true;
            this.cbIsHospitalized.Location = new System.Drawing.Point(25, 171);
            this.cbIsHospitalized.Name = "cbIsHospitalized";
            this.cbIsHospitalized.Size = new System.Drawing.Size(100, 17);
            this.cbIsHospitalized.TabIndex = 25;
            this.cbIsHospitalized.Text = "Is Hospitalized?";
            this.cbIsHospitalized.UseVisualStyleBackColor = true;
            this.cbIsHospitalized.CheckedChanged += new System.EventHandler(this.cbIsHospitalized_CheckedChanged);
            // 
            // tbCnp
            // 
            this.tbCnp.Location = new System.Drawing.Point(105, 124);
            this.tbCnp.Name = "tbCnp";
            this.tbCnp.Size = new System.Drawing.Size(121, 20);
            this.tbCnp.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "FirstName";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(22, 131);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(29, 13);
            this.lbPhoneNumber.TabIndex = 29;
            this.lbPhoneNumber.Text = "CNP";
            // 
            // lbIdPatient
            // 
            this.lbIdPatient.AutoSize = true;
            this.lbIdPatient.Location = new System.Drawing.Point(20, 35);
            this.lbIdPatient.Name = "lbIdPatient";
            this.lbIdPatient.Size = new System.Drawing.Size(52, 13);
            this.lbIdPatient.TabIndex = 26;
            this.lbIdPatient.Text = "Id Patient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "LastName";
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(23, 224);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 30;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(185, 224);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 31;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // EditFormPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proiectPaw.Properties.Resources.Chrysanthemum;
            this.ClientSize = new System.Drawing.Size(302, 259);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbIdPatient);
            this.Controls.Add(this.cbIsHospitalized);
            this.Controls.Add(this.tbCnp);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbIdPatient);
            this.Name = "EditFormPatient";
            this.Text = "EditFormPatient";
            this.Load += new System.EventHandler(this.EditFormPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdPatient;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.CheckBox cbIsHospitalized;
        private System.Windows.Forms.TextBox tbCnp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbIdPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}