using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFormBasic.Model
{
    public class StudentModel {}

    public class Student: INotifyPropertyChanged
    {
        private string? firstName;
        private string? lastName;


         

        public string FirstName {
            get => firstName;
            set  {
                if (firstName != value) {
                    firstName = value;
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        
    

        public string LastName
        {
            get => lastName;
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    RaisePropertyChanged("LastName");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string FullName {
            get {
                return firstName + " " + lastName; }
        }



        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            };
        }

        
    }

}
