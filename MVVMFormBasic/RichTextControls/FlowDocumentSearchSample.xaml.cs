using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVVMFormBasic.RichTextControls
{
    /// <summary>
    /// Interaction logic for FlowDocumentSearchSample.xaml
    /// </summary>
    public partial class FlowDocumentSearchSample : Window
    {
        public FlowDocumentSearchSample()
        {
            InitializeComponent();
        }

/*        All three viewers support the Ctrl+F keyboard shortcut for initiating a search, but if you want 
 *        this to be accessible from e.g.a button as well, you just have to call the Find() method.
*/        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            fdViewer.Find();
        }
    }
}
