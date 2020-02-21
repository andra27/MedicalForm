using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPaw
{
    public class Patient
    {
        
        public int IdPatient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String CNP { get; set; }
        public Boolean Hospitalized { get; set; }   //check box
        public int doctorId { get; set; }  

        public Patient(int id, string firstname, string lastname, String cnp, Boolean hosp) {
            this.IdPatient = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.CNP = cnp;
            this.Hospitalized = hosp;

        }
        public Patient(int id, string firstname, string lastname, String cnp, Boolean hosp, int doctorId)
        {
            this.IdPatient = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.CNP = cnp;
            this.Hospitalized = hosp;
            this.doctorId = doctorId;

        }



    }
}
