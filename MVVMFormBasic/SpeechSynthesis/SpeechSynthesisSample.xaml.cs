using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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
 



namespace MVVMFormBasic.SpeechSynthesis
{
    /// <summary>
    /// Interaction logic for SpeechSynthesisSample.xaml
    /// </summary>
    public partial class SpeechSynthesisSample : UserControl
    {
        public SpeechSynthesisSample()
        {
            InitializeComponent();
        }
        private void btnSayHello_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak("Hello, world!");
        }
    }
}
