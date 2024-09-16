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
using System.Windows.Shapes;

namespace MVVMFormBasic.Dialogs
{
    /// <summary>
    /// Interaction logic for InputDialogSample.xaml
    /// </summary>
    public partial class InputDialogSample : Window
    {
        public InputDialogSample(string question, string defaultAnswer = "")
        {
            InitializeComponent();
            lblQuestion.Content = question;
            txtAnswer.Text = defaultAnswer;
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
/*        To give focus to the TextBox upon showing the dialog, I've subscribed to the ContentRendered event,
 *        where I select all the text in the control and then give focus
*/        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtAnswer.SelectAll();
            txtAnswer.Focus();
        }
        //gives access to the entered value of the TextBox control,
        public string Answer
        {
            get { return txtAnswer.Text; }
        }

    }
}
