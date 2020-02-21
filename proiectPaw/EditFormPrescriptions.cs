using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPaw
{
    public partial class EditFormPrescriptions : Form
    {
        Prescription prescription;
        public EditFormPrescriptions(Prescription pres)
        {
            InitializeComponent();
            this.prescription = pres;
        }

        private void gbPrescription_Enter(object sender, EventArgs e)
        {

        }

        private void bTOk_Click(object sender, EventArgs e)
        {
            prescription.Id = Convert.ToInt32(tbIdPrescription.Text);
            prescription.Description = tbDescription.Text;
            prescription.DoctorName = tbDoctorName.Text;
            prescription.PatientId = Convert.ToInt32(tbPatientId.Text);
            prescription.Date = dtpPrescription.Value;

        }

        private void EditFormPrescriptions_Load(object sender, EventArgs e)
        {
            tbIdPrescription.Text= prescription.Id.ToString();
            tbDescription.Text = prescription.Description;
            tbDoctorName.Text = prescription.DoctorName;
            tbPatientId.Text = prescription.PatientId.ToString();
            dtpPrescription.Value = prescription.Date;
            

        }

    }
}
