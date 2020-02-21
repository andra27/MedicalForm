using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPaw
{
    public partial class FormPrescription : Form
    {
       private const string ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =\"DatabasePaw.mdb\";Persist Security Info=True";

        List<Prescription> listPrescriptions;
        Patient patient;
        public FormPrescription(Patient pat)
        {
            InitializeComponent();
            listPrescriptions = new List<Prescription>();
            this.patient = pat;

        }

        private void gbDoctor_Enter(object sender, EventArgs e)
        {

        }

        private void tbIdPrescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbIdPrescription.Text)) {
                e.Cancel = true;
                epId.SetError(tbIdPrescription, "write something!");
            }

        }

        private void tbIdPrescription_Validated(object sender, EventArgs e)
        {
            epId.Clear();
        }

        private void tbDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDescription.Text))
            {
                e.Cancel = true;
                epDescription.SetError(tbDescription, "write something!");
            }
        }

        private void tbDescription_Validated(object sender, EventArgs e)
        {
            epDescription.Clear();
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDoctorName.Text))
            {
                e.Cancel = true;
                epDoctorName.SetError(tbDoctorName, "Write something!");
            }
        }

        private void tbLastName_Validated(object sender, EventArgs e)
        {
            epDoctorName.Clear();
        }

        private void tbCnp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPatientId.Text))
            {
                e.Cancel = true;
                epPatientId.SetError(tbPatientId, "Write something!");


            }
        }

        private void tbCnp_Validated(object sender, EventArgs e)
        {
            epPatientId.Clear();

        }

        private void btAddNewPatient_Click(object sender, EventArgs e)
        {
            Boolean vari=true;
            int id = Convert.ToInt32(tbIdPrescription.Text);
            int idPatient = Convert.ToInt32(tbPatientId.Text);

            if (id<0)
            {
                vari = false;
                epId.SetError(tbIdPrescription, "write something!");
            }
            if (idPatient < 0)
            {
                vari = false;
                epPatientId.SetError(tbPatientId, "write something!");
            }

            if (string.IsNullOrEmpty(tbDescription.Text))
            {
                vari = false;
                epDescription.SetError(tbDescription, "write something!");
            }

            if (string.IsNullOrEmpty(tbDoctorName.Text))
            {
                vari = false;
                epDoctorName.SetError(tbDoctorName, "Write something!");
            }
            if (vari == false)
                MessageBox.Show("Write in all textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Prescription prescription = new Prescription(id,tbDescription.Text,tbDoctorName.Text, idPatient, dtpPrescription.Value);

                AddPrescription(prescription);
                DisplayPrescriptions();
            }
        }

        private void DisplayPrescriptions()
        {
            lvPrescription.Items.Clear();

            foreach (var presc in listPrescriptions)
            {
                var lv = new ListViewItem(presc.Id.ToString());
                lv.SubItems.Add(presc.Description);
                lv.SubItems.Add(presc.DoctorName);
                lv.SubItems.Add(presc.PatientId.ToString());
                lv.SubItems.Add( presc.Date.ToShortDateString());
                lv.Tag = presc;
                lvPrescription.Items.Add(lv);
            }
            
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (lvPrescription.SelectedItems.Count == 0)
                MessageBox.Show("select a prescription");
            else
            {
                var lv = lvPrescription.SelectedItems[0];
                Prescription p =(Prescription) lv.Tag;
                EditFormPrescriptions editPrescription = new EditFormPrescriptions(p);
                if (editPrescription.ShowDialog() == DialogResult.OK)
                    DisplayPrescriptions();

            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lvPrescription.SelectedItems.Count == 0)
                MessageBox.Show("Select a prescription !");
            else
            {
                if (MessageBox.Show("Are you sure?", "Delete prescription", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var lv = lvPrescription.SelectedItems[0];
                    Prescription p = (Prescription)lv.Tag;
                    DeletePrescription(p);
                    DisplayPrescriptions();
                }
            }
        }


        public void AddPrescription(Prescription prescription)
        {
            var queryString = "INSERT INTO Prescriptions(ID,Description,DoctorName,PatientId,PrescriptionDate)" + "VALUES(@id,@description,@doctorname,@patientid,@prescriptiondate);";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                var sqlcommand = new OleDbCommand(queryString, connection);
                var id = new OleDbParameter("@id", prescription.Id);
                var description = new OleDbParameter("@description", prescription.Description);
                var docname = new OleDbParameter("@doctorname", prescription.DoctorName);
                var parientid = new OleDbParameter("@patientid", prescription.PatientId);
                var datetime = new OleDbParameter("@prescriptiondate",prescription.Date);
                sqlcommand.Parameters.Add(id);
                sqlcommand.Parameters.Add(description);
                sqlcommand.Parameters.Add(docname);
                sqlcommand.Parameters.Add(parientid);
                sqlcommand.Parameters.Add(datetime);

                sqlcommand.ExecuteNonQuery();

                listPrescriptions.Add(prescription);



            }
        }

        public void LoadPrescription()
        {
            string querySring = "SELECT * FROM Prescriptions WHERE PatientId=@ID;";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                var sqlcommand = new OleDbCommand(querySring, connection);
                
                var id = new OleDbParameter("@ID", patient.IdPatient);
                sqlcommand.Parameters.Add(id);

                OleDbDataReader sqlreader = sqlcommand.ExecuteReader();
                try
                {
                    while (sqlreader.Read())
                    {
                        var p = new Prescription(         (int)sqlreader["ID"],
                                                          (string)sqlreader["Description"],
                                                          (string)sqlreader["DoctorName"],
                                                          (int)sqlreader["PatientId"],
                                                          (DateTime)sqlreader["PrescriptionDate"]  );
                        listPrescriptions.Add(p);
                    }
                }
                finally {
                    sqlreader.Close();
                }
            }
        }

        public void FormPrescription_Load(object sender, EventArgs e)
        {
            try {
                LoadPrescription();
                DisplayPrescriptions();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }



        public void DeletePrescription(Prescription p)
        {
            const string queryString = "DELETE  FROM Prescriptions WHERE ID=@id";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                var sqlcommand = new OleDbCommand(queryString, connection);
                var sqlparam = new OleDbParameter("@id", p.Id);
                sqlcommand.Parameters.Add(sqlparam);
                sqlcommand.ExecuteNonQuery();
                listPrescriptions.Remove(p);



            }
        }

    }
}
