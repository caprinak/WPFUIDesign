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

namespace MVVMFormBasic.Misc_Controls
{
    /// <summary>
    /// Interaction logic for DatePickerSample.xaml
    /// </summary>
    public partial class DatePickerSample : UserControl
    {
        public DatePickerSample()
        {
            InitializeComponent();
            //With that in place, all past dates, as well as the next week, will be unavailable for selection.
            datePicker.BlackoutDates.Add(new CalendarDateRange( DateTime.Today, DateTime.Today.AddDays(7)));
        }
    }
}
