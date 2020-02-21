using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace proiectPaw.ViewModel
{
    class MainFormViewModel
    {
        private int _id;
        public int Id {
            get { return _id; }
            set {
                if (_id == value)
                    return;
                else
                    _id = value;
                OnPropertyChanged();

            }
        }

        private string _firstname;
        public string FirstName
        {
            get { return _firstname; }
            set {
                if (_firstname == value)
                    return;
                _firstname = value;
                OnPropertyChanged();
            }
        }

        private string _lastname;
        public string LastName
        {
            get { return _lastname; }
            set
            {
                if (_lastname == value)
                    return;
                _lastname = value;
                OnPropertyChanged();
            }
        }

        private int _phonenumber;
        public int PhoneNumber
        {
            get { return _phonenumber; }
            set
            {
                if (_phonenumber == value)
                    return;
                else
                    _phonenumber = value;
                OnPropertyChanged();

            }
        }

        public BindingList<Doctor> Doctors { get; set; }

        public MainFormViewModel()
        {
            Doctors = new BindingList<Doctor>();

        }

        public void AddDoctor() {
            Doctors.Add(new Doctor(Id, FirstName, LastName, PhoneNumber));
            FirstName = LastName = String.Empty;
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void DeleteDoctor(Doctor doctor)
        {
            Doctors.Remove(doctor);
        }
    }
}
