using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMFormBasic.Views
{
    /// <summary>
    /// Interaction logic for ImagesControl.xaml
    /// </summary>
    public partial class ImagesControl : UserControl
    {
        public ImagesControl()
        {
            InitializeComponent();
        }
        private void BtnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
/*                Bitmap effects enable designers and developers to apply visual effects to rendered 
 *                Windows Presentation Foundation(WPF) content.For example, bitmap effects allow you to easily
 *                apply a DropShadowBitmapEffect effect or a blur effect to an image or a button.
*/                imgDynamic.Source = new BitmapImage(fileUri);
            }
        }
        private void BtnLoadFromResource_Click(object sender, RoutedEventArgs e)
        {
/*            just be sure to pass in the UriKind.Relative value when you create the Uri instance,
 *            so it knows that the path supplied is not an absolute path.
*/
    Uri resourceUri = new Uri("/Images/cancel.png", UriKind.Relative);
            imgDynamic.Source = new BitmapImage(resourceUri);
        }
    }
}
