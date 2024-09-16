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

namespace MVVMFormBasic.Views.Commands
{
    /// <summary>
    /// Interaction logic for CutPasteCommand.xaml
    /// </summary>
    public partial class CutPasteCommand : UserControl
    {
        public CutPasteCommand()
        {
            InitializeComponent();
        }

/*        the toggling of buttons for using the Windows Clipboard, where you want the Cut and Copy buttons to be enabled
 *        only when text is selected, and the Paste button to only be enabled when text is present in the clipboard.
*/        private void CutCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtEditor != null) && (txtEditor.SelectionLength > 0);
        }

        private void CutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        { //cut and put content into Clipboard
            txtEditor.Cut();
        }

        private void PasteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }

        private void PasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {   //paste content from clipboard to txtEditor box
            txtEditor.Paste();
        }
    }
}
