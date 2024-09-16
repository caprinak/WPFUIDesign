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

namespace MVVMFormBasic.Dialogs
{
    /// <summary>
    /// Interaction logic for CustomInputDialog.xaml
    /// </summary>
    public partial class CustomInputDialog : UserControl
    {
        public CustomInputDialog()
        {
            InitializeComponent();
            lblQuestion.Content = "play aoe?";
            txtAnswer.Text = "yes";
        }
        
        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = (MainWindow)this.Parent;
            mw.DialogResult = true;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtAnswer.SelectAll();
            txtAnswer.Focus();
        }

        public string Answer
        {
            get { return txtAnswer.Text; }
        }

        
    }
}
