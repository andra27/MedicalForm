using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//am un form principal unde introduc un doctor. apoi am mai multe butoane unde pot sa introduc pacienti(sa mi se deschisa un alt form , unde am mai multi pacienti ,in froma principala sa se scrie doar numele )
//la prescriptie sa fie doar un buton caer sa aduge in listview 

namespace proiectPaw
{
    [Serializable]
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
       // public YearsExperienceClass YearsExper { get; set; }  

        public Doctor(int Id, string firstname, string lastname, int phonenumber)
        {
            this.Id = Id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.PhoneNumber = phonenumber;
        }
        


         

    }
}
