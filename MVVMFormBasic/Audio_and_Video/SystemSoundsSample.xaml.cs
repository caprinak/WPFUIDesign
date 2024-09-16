using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace MVVMFormBasic.Audio_and_Video
{
    /// <summary>
    /// Interaction logic for SystemSoundsSample.xaml
    /// </summary>
    public partial class SystemSoundsSample : UserControl
    {
        public SystemSoundsSample()
        {
            InitializeComponent();
        }

/*        several limitations to using this approach.First of all, you only get access to these five sounds, and second of all, 
 *        the user may have disabled them in Windows, in which case the expected sound will be replaced with silence. 
*/        private void btnAsterisk_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Asterisk.Play();
        }

        private void btnBeep_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void btnExclamation_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void btnHand_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Hand.Play();
        }

        private void btnQuestion_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Question.Play();
        }
    }
}
