using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Threading;

namespace MVVMFormBasic.MISC
{
    /// <summary>
    /// Interaction logic for DispatcherTimerSample.xaml
    /// </summary>
    public partial class DispatcherTimerSample : UserControl
    {
        private DispatcherTimer timer;
        public DispatcherTimerSample()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = DateTime.Now.ToString("HH:mm:ss.fff");
            //lblTime.Content = "Bây giờ là " + DateTime.Now.ToLongTimeString();
        }

        private void Button_Click_Stop(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void Button_Click_Start(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
        private void TurnonGermanTime(object sender, RoutedEventArgs e)
        {
            CultureInfo culture = new CultureInfo("de-DE");
            //lblTime.Content = DateTime.Now.ToString("HH:mm:ss.fff");
            lblTime.Content = String.Format("   UTC date and time: {0}, {1:G}\n",
                    DateTime.UtcNow.ToString(culture), DateTime.UtcNow.Kind);
        }
    }
}
