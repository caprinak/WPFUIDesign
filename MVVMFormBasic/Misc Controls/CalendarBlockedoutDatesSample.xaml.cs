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
    /// Interaction logic for CalendarBlockedoutDatesSample.xaml
    /// </summary
    public partial class CalendarBlockedoutDatesSample : UserControl
    {
        public CalendarBlockedoutDatesSample()
        {
            InitializeComponent();
            cldSample.BlackoutDates.Add(new CalendarDateRange(DateTime.Today.AddMonths(2), DateTime.Today.AddMonths(2).AddDays(2)));
        }
    }
}
