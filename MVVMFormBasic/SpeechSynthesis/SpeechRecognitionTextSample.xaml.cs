using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
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
    /// Interaction logic for SpeechRecognitionTextSample.xaml
    /// </summary>
    public partial class SpeechRecognitionTextSample : UserControl
    {
        public SpeechRecognitionTextSample()
        {
            InitializeComponent();
            SpeechRecognizer speechRecognizer = new SpeechRecognizer();
        }
    }
}
