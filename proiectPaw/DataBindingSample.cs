using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proiectPaw.ViewModel;

namespace proiectPaw
{
    public partial class DataBindingSample : Form
    {
        private MainFormViewModel viewModel;

        public DataBindingSample()
        {
            InitializeComponent();
            viewModel = new MainFormViewModel();
        }

        private void gbDoctor_Enter(object sender, EventArgs e)
        {

        }

        private void DataBindingSample_Load(object sender, EventArgs e)
        {
            dgvDoctors.DataSource = viewModel.Doctors;
            tbId.DataBindings.Add("Text", viewModel, "Id");
            tbFirstName.DataBindings.Add("Text", viewModel, "FirstName");
            tbLastName.DataBindings.Add("Text", viewModel, "LastName");
            tbPhoneNumber.DataBindings.Add("Text", viewModel, "PhoneNumber");

        }

        private void btAddNewDoctor_Click(object sender, EventArgs e)
        {
            viewModel.AddDoctor();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvDoctors.SelectedRows;
            if (selectedRows.Count != 1)
                MessageBox.Show("select one row!");
            else
            {
                var row = selectedRows[0];
                var doctor = (Doctor)row.DataBoundItem;
                viewModel.DeleteDoctor(doctor);
            }
        }
    }
}
