using MVVMFormBasic.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFormBasic.ViewModel
{
    class StudentDataTemplateViewModel
    {
        public ObservableCollection<Student> Students { get; set; }

        public StudentDataTemplateViewModel() => LoadStudents();

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(new Student { FirstName = "Kyle", LastName = "Finken" });
            students.Add(new Student { FirstName = "Allen", LastName = "Brown" });
            students.Add(new Student { FirstName = "Linda", LastName = "Hamerski" });

            Students = students;
        }
    }
}
