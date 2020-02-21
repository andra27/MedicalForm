using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPaw
{


    public partial class Form1 : Form
    {
        List<Doctor> doctors;
        
        List<Patient> listPatients;

        private string ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =\"DatabasePaw.mdb\";Persist Security Info=True";

        public Form1()
        {
            InitializeComponent();
            doctors = new List<Doctor>();
            

        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {

        }


        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                e.Cancel = true;
                epId.SetError(tbId, "Intoduce some text!");
            }

        }

        private void tbId_Validated(object sender, EventArgs e)
        {
            epId.Clear();
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstName.Text))
            {
                e.Cancel = true;
                epFirstName.SetError(tbFirstName, "Introduce some text!");

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
                epLastName.SetError(tbLastName, "Introduce some text!");
            }


        }

        private void tbLastName_Validated(object sender, EventArgs e)
        {
            epLastName.Clear();
        }

        //private void cbYearsExperience_Validating(object sender, CancelEventArgs e)
        //{
        //    if (cbYearsExperience.SelectedItem == null)
        //    {
        //        e.Cancel = true;
        //        epYearsExperience.SetError(cbYearsExperience, "You must select a category");
        //    }
        //}
        private void tbPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int phone = Convert.ToInt32(tbPhoneNumber.Text);
                if (phone <= 0)
                {
                    e.Cancel = true;
                    epPhoneNumber.SetError(tbPhoneNumber, "intoduce a number!");
                }
            }
            catch
            {
                e.Cancel = true;
                epPhoneNumber.SetError(tbPhoneNumber, "inncorect");
            }

           


        }

        private void tbPhoneNumber_Validated(object sender, EventArgs e)
        {
            epPhoneNumber.Clear();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var Id = Convert.ToInt32(tbId.Text);
            var FirstName = tbFirstName.Text.Trim();
            var LastName = tbLastName.Text.Trim();
            var Phone = Convert.ToInt32(tbPhoneNumber.Text);
            bool valid = true;
            if (Id < 0)
            {
                valid = false;
                epId.SetError(tbId, "Incorrect id");
            }

            if (string.IsNullOrEmpty(FirstName))
            {
                valid = false;
                epFirstName.SetError(tbFirstName, "is empty!");

            }

            if (string.IsNullOrEmpty(LastName))
            {
                valid = false;
                epLastName.SetError(tbLastName, "is empty!");
            }
            if (Phone <= 0)
            {
                valid = false;
                epPhoneNumber.SetError(tbPhoneNumber, "is empty!");
            }

            if (!valid)
            {
                MessageBox.Show(
                    "The form cotains errors!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {

                Doctor doctor;
                doctor = new Doctor(Id, FirstName, LastName, Phone);
                try
                {
                    AddDoctor(doctor);
                    DisplayDoctors();

                    tbId.Clear();
                    tbFirstName.Clear();
                    tbLastName.Clear();
                    tbPhoneNumber.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }



        }

        void DisplayDoctors()
        {
            lvDoctors.Items.Clear();
            foreach (var doc in doctors)
            {
                string variablia = Convert.ToString(doc.Id);
                var lv = new ListViewItem(variablia);
                lv.SubItems.Add(doc.FirstName);
                lv.SubItems.Add(doc.LastName);
                lv.SubItems.Add(doc.PhoneNumber.ToString());
                //if (doc.YearsExper != null)
                //    lv.SubItems.Add(doc.YearsExper.Status);

                lv.Tag = doc;

                lvDoctors.Items.Add(lv);



            }

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (lvDoctors.SelectedItems.Count != 1)
            {
                MessageBox.Show("Choose a doctor, please!");
            }
            else
            {
                var lv = lvDoctors.SelectedItems[0];
                Doctor doc = (Doctor)lv.Tag;

                var editForm = new EditForm(doc);

                if (editForm.ShowDialog() == DialogResult.OK)
                    DisplayDoctors();
            }


        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lvDoctors.SelectedItems.Count != 1)
            {
                MessageBox.Show("Choose a doctor,please!");
            }
            else
            {
                if (MessageBox.Show("Are you sure?", "Delete doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        var lv = lvDoctors.SelectedItems[0];
                        Doctor doc = (Doctor)lv.Tag;
                        DeleteDoctor(doc);
                        DisplayDoctors();
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        

        private void btPatients_Click(object sender, EventArgs e)
        {
            if (lvDoctors.SelectedItems.Count == 0)
                MessageBox.Show("Select a doctor!");
            else
            {
                var lv = lvDoctors.SelectedItems[0];
                Doctor doc = (Doctor)lv.Tag;
                var formPatient = new FormPacients(doc);

                if (formPatient.ShowDialog() == DialogResult.OK)
                    DisplayDoctors();                  //???
            }
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream s = File.Create("serialized.bin"))
            {
                formatter.Serialize(s, doctors);
            }
        }

        private void deserialize_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream s = File.OpenRead("serialized.bin"))
            {
                doctors=(List<Doctor>)formatter.Deserialize(s);
                DisplayDoctors();
            }
        }

       

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog(); 
            saveFile.Filter = "Text File | *.txt";
            saveFile.Title = "Save as text file ";

            if (saveFile.ShowDialog() == DialogResult.OK) {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    sw.WriteLine("Id,FirstName,LastName,PhoneNumber,YearsExperince");
                    foreach (var doc in doctors)
                    {
                        sw.WriteLine("{0},{1},{2},{3}", doc.Id, doc.FirstName, doc.LastName, doc.PhoneNumber.ToString());
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ControlExtension.Draggable(lbId, true);
            //ControlExtension.Draggable(lbFirstName, true);
            //ControlExtension.Draggable(lbLastName, true);
            //ControlExtension.Draggable(lbYearsExperience, true);
            //ControlExtension.Draggable(lbPhoneNumber, true);
            //ControlExtension.Draggable(tbId, true);
            //ControlExtension.Draggable(tbFirstName, true);
            //ControlExtension.Draggable(tbLastName, true);
            //ControlExtension.Draggable(tbPhoneNumber, true);
            //ControlExtension.Draggable(btAddNewDoctor, true);
            //ControlExtension.Draggable(btDelete, true);
            //ControlExtension.Draggable(btPatients, true);
            //ControlExtension.Draggable(btPrescription, true);
            //ControlExtension.Draggable(btEdit, true);
            //ControlExtension.Draggable(btYearsExperience, true);
            //ControlExtension.Draggable(lvDoctors, true);
            //ControlExtension.Draggable(menuStrip1, true);
            try {
                LoadDoctors();
                DisplayDoctors();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }


        public void AddDoctor(Doctor doctor)
        {
            var queryString = "INSERT INTO DOCTORS(id,FirstName,LastName,PhoneNumber)" + "VALUES(@Id,@firstname,@lastName,@phoneNumber)";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                var insertCommand = new OleDbCommand(queryString, connection);

                var id = new OleDbParameter("@Id",doctor.Id);   //inca nu sunt legate de qs
                var fname = new OleDbParameter("@firstname", doctor.FirstName);
                var flast = new OleDbParameter("@lastName", doctor.LastName);
                var phone = new OleDbParameter("@phoneNumber", doctor.PhoneNumber);

                insertCommand.Parameters.Add(id);    //aici fac legatura
                insertCommand.Parameters.Add(fname);
                insertCommand.Parameters.Add(flast);
                insertCommand.Parameters.Add(phone);

                insertCommand.ExecuteNonQuery();

            //  acces imi creste sngur id ul si mi l creste singur 

             //   var getId = new OleDbCommand("SELECT @@Identity;",connection);   //iau din baza de date-rezultatul ultimului query al bazei de date
              //  doctor.Id = (int)getId.ExecuteScalar();
                doctors.Add(doctor);


                // We also then issue the ExecuteNonQuery method which is used to execute the insert statement against our database.


            }

        }



        public void LoadDoctors()
        {

            const string queryString = "SELECT * FROM DOCTORS"; 
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                OleDbCommand sqlCommand = new OleDbCommand(queryString, connection);
                OleDbDataReader sqlReader = sqlCommand.ExecuteReader();
                try
                {
                    while (sqlReader.Read())
                    {
                        var doct = new Doctor((int)sqlReader["Id"],
                                             (string)sqlReader["LastName"],
                                             (string)sqlReader["FirstName"],
                                             (int)sqlReader["PhoneNumber"]);
                        doctors.Add(doct);
                    }
                }
                finally
                {
                    sqlReader.Close();
                }

            }

        }


        public void DeleteDoctor(Doctor doctor)
        {
            const string queryString = "DELETE FROM DOCTORS WHERE Id=@id";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                OleDbCommand sqlCommand = new OleDbCommand(queryString, connection);
                //OleDbParameter command-Represents an SQL statement or stored procedure to execute against a data source.
                var idParameter = new OleDbParameter("@id", doctor.Id);
                sqlCommand.Parameters.Add(idParameter); //Returns:
                                                        //     The parameters of the SQL statement 

                sqlCommand.ExecuteNonQuery();
                doctors.Remove(doctor);

            }
        }

        private void btChart_Click(object sender, EventArgs e)
        {
            var formSample = new SampleForChart();
            if (formSample.ShowDialog() == DialogResult.OK)
            { DisplayDoctors(); }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var formBinding = new DataBindingSample();
            if (formBinding.ShowDialog() == DialogResult.OK)
                DisplayDoctors();

        }
    }
}

