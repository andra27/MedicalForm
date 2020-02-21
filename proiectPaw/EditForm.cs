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
    public partial class EditForm : Form
    {
        Doctor doctor;
        public EditForm(Doctor doctor)
        {
            this.doctor = doctor;
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            doctor.Id = Convert.ToInt32( tbId.Text);
            doctor.FirstName = tbFirstName.Text;
            doctor.LastName = tbLastName.Text;
            doctor.PhoneNumber = Convert.ToInt32(tbPhoneNumber.Text);

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tbId.Text =Convert.ToString( doctor.Id);
            tbFirstName.Text = doctor.FirstName;
            tbLastName.Text = doctor.LastName;
            tbPhoneNumber.Text =Convert.ToString( doctor.PhoneNumber);
        }
    }
}
