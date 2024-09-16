using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVVMFormBasic.SpeechSynthesis
{
    /// <summary>
    /// Interaction logic for SpeechSynthesisPromptBuilderSample.xaml
    /// </summary>
    public partial class SpeechSynthesisPromptBuilderSample : UserControl
    {
        public SpeechSynthesisPromptBuilderSample()
        {
            InitializeComponent();
        }
        private void btnSayHello_Click(object sender, RoutedEventArgs e)
        {
            PromptBuilder promptBuilder = new PromptBuilder();
            promptBuilder.AppendText("Hello world");

            //in a lower volume and a slower rate, as if it was whispered.
            PromptStyle promptStyle = new PromptStyle();
            promptStyle.Volume = PromptVolume.Soft;
            promptStyle.Rate = PromptRate.Slow;
            promptBuilder.StartStyle(promptStyle);
            promptBuilder.AppendText("and hello to the universe too.");
            promptBuilder.EndStyle();

            promptBuilder.AppendText("On this day, ");
            //special SayAs enumeration to specify that the date should be read out as an actual date and not just a set of numbers, spaces and special characters.
            promptBuilder.AppendTextWithHint(DateTime.Now.ToShortDateString(), SayAs.Date);

            promptBuilder.AppendText(", we're gathered here to learn");
            //the word "all" is spoken with a stronger emphasis, to make the sentence more dynamic,
           promptBuilder.AppendText("all", PromptEmphasis.Strong);
            promptBuilder.AppendText("about");
            //word "WPF" is spelled out (W - P - F) instead of being pronounced as an actual word.
            promptBuilder.AppendTextWithHint("WPF", SayAs.SpellOut);

            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak(promptBuilder);

/*     By supplying the SpeechSynthesizer with something more than just a text string, we can get a lot of control 
 *     of how the various parts of the sentence are spoken.
*/        }
    }
}
