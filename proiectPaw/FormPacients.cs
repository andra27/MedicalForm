using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPaw
{
    public partial class FormPacients : Form
    {
        private const string ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =\"DatabasePaw.mdb\";Persist Security Info=True";

        List<Patient> patients;
        Doctor selectedDoctor;
        private int _currentPatientIndex;

        // public connectionString=

        public FormPacients(Doctor doctor)                                  // //where idpatient=selectedDoctor.id
        {
            InitializeComponent();
            patients = new List<Patient>();
            selectedDoctor = doctor;
        }

        private void tbIdPatient_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbIdPatient.Text);
                if (id < 0)
                {
                    e.Cancel = true;
                    epIdPatient.SetError(tbIdPatient, "Write something!");
                }

            }
            catch {
                e.Cancel = true;
                epIdPatient.SetError(tbIdPatient, "Write something!");
            }


            

        }

        private void tbIdPatient_Validated(object sender, EventArgs e)
        {
            epIdPatient.Clear();
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstName.Text))
            {
                e.Cancel = true;
                epFirstName.SetError(tbFirstName, "Write something!");
            }

        }

        private void tbFirstName_Validated(object sender, EventArgs e)
        {
            epFirstName.Clear();
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbLastName.Text))
            {
                e.Cancel = true;
                epLastName.SetError(tbLastName, "Write something!");
            }

        }

        private void tbLastName_Validated(object sender, EventArgs e)
        {
            epLastName.Clear();
        }

        private void tbCnp_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbCnp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCnp.Text))
            {
                e.Cancel = true;
                epCnp.SetError(tbCnp, "Write something!");
            }

        }

        private void tbCnp_Validated(object sender, EventArgs e)
        {
            epCnp.Clear();
        }

        private void cbIsHospitalized_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void cbIsHospitalized_Validated(object sender, EventArgs e)
        {

        }

        private void btAddNewPatient_Validating(object sender, CancelEventArgs e)
        {
            Boolean valid = true;

            if(string.IsNullOrEmpty(tbIdPatient.Text))
            {
                valid = false;
                epIdPatient.SetError(tbIdPatient, "Write something!");
            }

            if (string.IsNullOrEmpty(tbFirstName.Text))
            {
                valid = false;
                epFirstName.SetError(tbFirstName, "Write something!");
            }

            if (string.IsNullOrEmpty(tbLastName.Text))
            {
                valid = false;
                epLastName.SetError(tbLastName, "Write something!");
            }
            if (string.IsNullOrEmpty(tbCnp.Text))
            {
                valid = false;
                epCnp.SetError(tbCnp, "Write something!");
            }
            if (string.IsNullOrEmpty(tbIdDoctor.Text))
            {
                valid = false;
                epIdDoctor.SetError(tbIdDoctor, "write something!");
            }

            if (valid == false)
                MessageBox.Show("You have to fill all the fields with information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void DisplayPatients()
        {
            lvPatient.Items.Clear();

            foreach (var pat in patients)
            {
                var lv = new ListViewItem(pat.IdPatient.ToString());
                lv.SubItems.Add(pat.FirstName);
                lv.SubItems.Add(pat.LastName);
                lv.SubItems.Add(pat.CNP);

                string vari;
                if (pat.Hospitalized == true) vari =" true";
                else vari =" false";

                lv.SubItems.Add(vari);
                lv.SubItems.Add(pat.doctorId.ToString());

                lv.Tag = pat;

                lvPatient.Items.Add(lv);


            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (lvPatient.SelectedItems.Count == 0)
                MessageBox.Show("Choose a patient!");
            else
            {

               var lv = lvPatient.SelectedItems[0];
                Patient pat = (Patient)lv.Tag;

                EditFormPatient efPatient = new EditFormPatient(pat);
                if (efPatient.ShowDialog() == DialogResult.OK)
                    DisplayPatients();
            }


        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lvPatient.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a patient!");
            }
            else
            {
                if (MessageBox.Show("Are you sure?", "Delete patient", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){

                    var lv = lvPatient.SelectedItems[0];
                    Patient pat = (Patient)lv.Tag;

                    DeletePatient(pat);
                    DisplayPatients();
                }
            }
        }

        private void btAddNewPatient_Click(object sender, EventArgs e)
        {
             
           
                Patient patient;

                Boolean val;
                if (cbIsHospitalized.Checked == true) val = true;
                else val = false;

                int id = Convert.ToInt32(tbIdPatient.Text);
               int idDoctor = Convert.ToInt32(tbIdDoctor.Text);
            
                patient = new Patient(id, tbFirstName.Text, tbLastName.Text, tbCnp.Text, val,idDoctor);

            try
            {

                AddPatients(patient);
                DisplayPatients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                tbIdPatient.Clear();
                tbFirstName.Clear();
                tbLastName.Clear();
                tbCnp.Clear();
                cbIsHospitalized.Refresh();




            
        }

        




        private void btReturn_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV | *.csv";
            saveFile.Title = "Save as csv file ";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    sw.WriteLine("Id,FirstName,LastName,PhoneNumber,YearsExperince");
                    foreach (var p in patients)
                    {
                        sw.WriteLine("{0},{1},{2},{3},{4},{5}", p.IdPatient, p.FirstName, p.LastName, p.CNP, p.Hospitalized.ToString(),p.doctorId.ToString());
                    }
                }
            }
        }

        private void FormPacients_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPatients();
                DisplayPatients();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }


        public void LoadPatients()
        {
            const string queryString = "SELECT * FROM PATIENTS WHERE DoctorId=@idDoctor";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                OleDbCommand sqlCommand = new OleDbCommand(queryString, connection);
                var id = new OleDbParameter("@idDoctor", selectedDoctor.Id);
                sqlCommand.Parameters.Add(id);
                OleDbDataReader sqlReader = sqlCommand.ExecuteReader(); //creates an oldbdataraeder. trimite commanda lla connectiune si creaza un reader
                try
                {
                    while (sqlReader.Read())
                    {
                        var p = new Patient((int)sqlReader["IdPatient"],
                                           (string)sqlReader["FirstName"],
                                           (string)sqlReader["LastName"],
                                           (string)sqlReader["CNP"],
                                           (bool)sqlReader["Hospitalized"],
                                           (int)sqlReader["DoctorId"]);
                        patients.Add(p);
                    }


                }
                finally
                {
                    sqlReader.Close();
                }
            }
        }

        private void AddPatients(Patient p) {

            var queryString = "INSERT INTO PATIENTS(IdPatient,FirstName, LastName,CNP,Hospitalized,DoctorId)" + "values(@IdPatient,@firstname,@lastname,@cnp,@hospitalized,@doctorid);";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                var insertCommand = new OleDbCommand(queryString, connection);

                var id = new OleDbParameter("@IdPatient", p.IdPatient);
                var firstName = new OleDbParameter("@firstname", p.FirstName);
                var lastname = new OleDbParameter("@lastname", p.LastName);
                var cnp = new OleDbParameter("@cnp", p.CNP);
                
               
                var hosp = new OleDbParameter("@hospitalized", p.Hospitalized);
                var doctorid = new OleDbParameter("@doctorid", p.doctorId);
                insertCommand.Parameters.Add(id);
                insertCommand.Parameters.Add(firstName);
                insertCommand.Parameters.Add(lastname);
                insertCommand.Parameters.Add(cnp);
                insertCommand.Parameters.Add(hosp);
                insertCommand.Parameters.Add(doctorid);
                insertCommand.ExecuteNonQuery();
                patients.Add(p);

            }
        }




        public void DeletePatient(Patient p )
        {
            const string queryString = "DELETE FROM PATIENTS WHERE IdPatient=@id";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                OleDbCommand sqlCommand = new OleDbCommand(queryString, connection);

                var id = new OleDbParameter("@id", p.IdPatient);
                sqlCommand.Parameters.Add(id);
                sqlCommand.ExecuteNonQuery();
                patients.Remove(p);

            }

        }

        private void tbIdDoctor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbIdDoctor.Text))
            {
                e.Cancel = true;
                epIdDoctor.SetError(tbIdDoctor, "write something!");

            }

        }

        private void tbIdDoctor_Validated(object sender, EventArgs e)
        {
            epIdDoctor.Clear();
        }

        private void btPrescription_Click(object sender, EventArgs e)
        {
            if (lvPatient.SelectedItems.Count == 0)
                MessageBox.Show("Select a patient!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var lv = lvPatient.SelectedItems[0];
                Patient p = (Patient)lv.Tag;
                var formPrescription = new FormPrescription(p);
                if (formPrescription.ShowDialog() == DialogResult.OK)
                    DisplayPatients();

                
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 24);
            var pageSettings = printDocument.DefaultPageSettings;
            var intPrintAreaHeight = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            var intPrintAreaWidth = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;

            var marginLeft = pageSettings.Margins.Left;
            var marginTop = pageSettings.Margins.Top;

            if (printDocument.DefaultPageSettings.Landscape)
            {
                var intTemp = intPrintAreaHeight;
                intPrintAreaHeight = intPrintAreaWidth;
                intPrintAreaWidth = intTemp;
            }

            const int rowHeight = 40;
            var columnWidth = intPrintAreaWidth / 3;

            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            while (_currentPatientIndex < patients.Count)
            {
                var currentX = marginLeft;
                e.Graphics.DrawRectangle(Pens.Black,
                                         currentX,
                                         currentY,
                                         columnWidth,
                                         rowHeight);

                e.Graphics.DrawString(patients[_currentPatientIndex].IdPatient.ToString(),
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);

                currentX += columnWidth;

                e.Graphics.DrawRectangle(
              Pens.Black,
              currentX,
              currentY,
              columnWidth,
              rowHeight);

                e.Graphics.DrawString(
                    patients[_currentPatientIndex].FirstName,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);

                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    patients[_currentPatientIndex].LastName,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);

                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    patients[_currentPatientIndex].CNP,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    patients[_currentPatientIndex].Hospitalized.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    patients[_currentPatientIndex].doctorId.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);


                _currentPatientIndex++;
                currentY += rowHeight;

                if (currentY + rowHeight > intPrintAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }

            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();

        }

        private void btnPageSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
            }


        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _currentPatientIndex = 0; 
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            try {
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
            catch (Exception) {
                MessageBox.Show("an error occured while trying ti load the document for  print preview.A printer must be connected and accessible for Print Preview to work");
            }
        }

        private void lvPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbDoctor_Enter(object sender, EventArgs e)
        {

        }
    }

}
