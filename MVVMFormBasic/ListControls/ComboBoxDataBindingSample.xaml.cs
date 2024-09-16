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

namespace MVVMFormBasic.ListControls
{
    /// <summary>
    /// Interaction logic for ComboBoxDataBindingSample.xaml
    /// </summary>
    public partial class ComboBoxDataBindingSample : UserControl
    {
        public ComboBoxDataBindingSample()
        {
            InitializeComponent();
           //obtain a list of all the colors using a Reflection based approach with the Colors class.
           //Assign it to the ItemsSource property of the ComboBox
            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }
    }
}
