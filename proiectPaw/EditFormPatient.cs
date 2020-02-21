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
    public partial class EditFormPatient : Form
    {
        Patient patient;
        public EditFormPatient(Patient pat)
        {
            this.patient = pat;
            InitializeComponent();
        }


        private void EditFormPatient_Load(object sender, EventArgs e)
        {
            tbIdPatient.Text =Convert.ToString( patient.IdPatient);
            tbFirstName.Text = patient.FirstName;
            tbLastName.Text = patient.LastName;
            tbCnp.Text = patient.CNP;

            if (patient.Hospitalized == true)    //?
                cbIsHospitalized.Checked = true ;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            patient.IdPatient =Convert.ToInt32( tbIdPatient.Text);
            patient.FirstName = tbFirstName.Text;
            patient.LastName = tbLastName.Text;
            patient.CNP = tbCnp.Text;
            Boolean vari;
            if (cbIsHospitalized.Checked == true) vari = true;
            else vari = false;
            patient.Hospitalized =vari;

        }

        private void cbIsHospitalized_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
