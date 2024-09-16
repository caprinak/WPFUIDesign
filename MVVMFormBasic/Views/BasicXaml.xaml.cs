using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
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

namespace MVVMFormBasic.Views
{
    /// <summary>
    /// Interaction logic for BasicXaml.xaml
    /// </summary>
    public partial class BasicXaml : UserControl
    {
        public BasicXaml()
        {
            InitializeComponent();
/*            The most common way to subscribe to events is explained above, but there may be times where you want to
 *            subscribe to the event directly from Code-behind instead.This is done using the += C# syntax, where you
 *            add an event handler to event directly on the object.
*/            pnlMainGrid.MouseMove += PnlMainGrid_MouseMove;
        }
/*        Simply press the[Tab] key twice to have Visual Studio generate the correct event handler for you, 
 *        right below the current method, ready for implementatio
*/        private void PnlMainGrid_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("I am at " + e.GetPosition(this).ToString());
        }


/*        Fortunately, Visual Studio can help us to generate a correct event handler for an event. The easiest way to
 *        do this is to simply write the name of the event in XAML and then let the IntelliSense of VS do the rest for you:
*/        private void pnlMainGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
        }
     
    }
}
