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
    /// Interaction logic for SliderValueChangedSample.xaml
    /// </summary>
    public partial class SliderValueChangedSample : UserControl
    {
        public SliderValueChangedSample()
        {
            InitializeComponent();
        }
        /*        Each slider subscribes to the same ValueChanged event, in which we create a new Color instance,
         *        based on the currently selected values and then uses this color to create a new SolidColorBrush for the Background property of the Window.
        */

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
             Color color =  Color.FromRgb((byte)slColorR.Value, (byte)slColorG.Value, (byte)slColorB.Value);
            this.Background = new SolidColorBrush(color);
        }
    }
}
