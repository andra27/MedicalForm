using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//fiecare patient are propria lui prescriptie. edci atunci cand sunt in formul de client, ar trebui sa mai adaug un buton care sa adauge o prescriptie, la patient-ul respectiv



namespace proiectPaw
{
    [Serializable]
    public  class Prescription        
    {

        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Description { get; set; }
        public String DoctorName { get; set; }
        public DateTime Date { get; set; }

        public Prescription(int id,string description, string doctorname, int patientid, DateTime date) {
            this.Id = id;
            this.PatientId = patientid;
            this.Description = description;
            this.DoctorName = doctorname;
            this.Date = date;

        }
    }
}
