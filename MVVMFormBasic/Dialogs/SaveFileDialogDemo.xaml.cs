using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for SaveFileDialogDemo.xaml
    /// </summary>
    public partial class SaveFileDialogDemo : UserControl
    {
        public SaveFileDialogDemo()
        {
            InitializeComponent();
        }
        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
            saveFileDialog.InitialDirectory = @"c:\temp\";
            saveFileDialog.Title = "Save Akte";
            saveFileDialog.FileName = "akteno(x)";
            //AddExtension , ValidateNames, OverwritePrompt properties
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
        }
    }
}
