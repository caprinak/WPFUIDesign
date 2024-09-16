using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMFormBasic.CsharpBasics
{
    /// <summary>
    /// Interaction logic for PropertyInfoTest.xaml
    /// </summary>
    public partial class PropertyInfoTest : UserControl
    {
        public PropertyInfoTest()
        {
            InitializeComponent();
        }
        public static void TestPropertyInfo()
        {
            var type = typeof(University.Student);

            var propertyInfos = type.GetProperties();
            

            foreach (var propertyInfo in propertyInfos)
            {
                Console.Write(propertyInfo.Name + " { ");
                var accessors = propertyInfo.GetAccessors();
                foreach (var accessor in accessors)
                {
                    Console.Write(accessor.Name + "; ");
                }
                Console.WriteLine("}");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi");
            var type = typeof(University.Student);

            var propertyInfos = type.GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                Console.Write(propertyInfo.Name + " { ");
                var accessors = propertyInfo.GetAccessors();
                foreach (var accessor in accessors)
                {
                    Console.Write(accessor.Name + "; ");
                }
                Console.WriteLine("}");
            }
        }
    }





    namespace University
    {

        public class Student
        {
            public string FullName { get; set; }

            public int Class { get; set; }

            public DateTime DateOfBirth { get { return _dateOfBirth; } }

            private DateTime _dateOfBirth = DateTime.MinValue;

            public string GetCharacteristics()
            {
                return "";
            }
        }
    }
    namespace Department
    {

        public class Professor
        {

            public string FullName { get; set; }

        }
    }
}

