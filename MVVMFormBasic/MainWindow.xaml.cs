using Microsoft.VisualBasic;
using MVVMFormBasic.Common_Interface;
using MVVMFormBasic.Dialogs;
using MVVMFormBasic.Misc_Controls;
using MVVMFormBasic.RichTextControls;
using MVVMFormBasic.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Runtime.ExceptionServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMFormBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /*    As you can see, the MainWindow class is definied as partial, because it's being combined
     *    with your XAML file in runtime to give you the full window.
    */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*The Code-behind for this example only adds one line of interesting code: After the standard
        InitalizeComponent() call, we assign the "this" reference to the DataContext, which basically
        just tells the Window that we want itself to be the data context.*/


            /* SUMMARY: Using the DataContext property is like setting the basis of all bindings down through 
             * the hierarchy of controls.This saves you the hassle of manually defining a source for
             * each binding, and once you really start using data bindings, you will definitely 
             * appreciate the time and typing saved.

             However, this doesn't mean that you have to use the same DataContext for all controls
            within a Window. Since each control has its own DataContext property, you can easily 
            break the chain of inheritance and override the DataContext with a new value. 
            This allows you to do stuff like having a global DataContext on the window and then
            a more local and specific DataContext on e.g. a panel holding a separate form or 
            something along those lines
       */
            this.DataContext = this;
            

           /* BINDING FROM CODE BEHIND
            * 
            * It works by creating a Binding instance.We specify the path we want directly in 
            * the constructor, in this case "Text", since we want to bind to the Text property.
            * We then specify a Source, which for this example should be the TextBox control.
            * Now WPF knows that it should use the TextBox as the source control, and that we're
            * specifically looking for the value contained in its Text property.

    In the last line, we use the SetBinding method to combine our newly created Binding object with 
           the destination / target control, in this case the TextBlock (lblValue).The SetBinding() 
           method takes two parameters, one that tells which dependency property that we want to 
           bind to, and one that holds the binding object that we wish to use.
      //*///      Binding binding = new Binding("Text");
          //      binding.Source = txtValue;
          //      lblValue.SetBinding(TextBlock.TextProperty, binding);

            //this.DataContext = new StudentViewModel();
            /* String[] args = App.Args;
             try
             { // Open the text file using a stream reader.  
                 using (StreamReader sr = new StreamReader(args[0]))
                 {
                     // Read the stream to a string, and write  
                     // the string to the text box  
                     String line = sr.ReadToEnd();
                     textBox.AppendText(line.ToString());
                     textBox.AppendText("\n");
                 }
             }
             catch (Exception e)
             {
                 textBox.AppendText("The file could not be read:");
                 textBox.AppendText("\n");
                 textBox.AppendText(e.Message);
             }*/

        }

        private void MenuWithCommandsSampleClick(object sender, RoutedEventArgs e)
        {
            ContextMenuWithCommandsSample cm = new ContextMenuWithCommandsSample();
            cm.Show();
        }

        private void ContextMenuManuallyInvokedSample(object sender, RoutedEventArgs e)
        {
            ContextMenuManuallyInvokedSample cm = new ContextMenuManuallyInvokedSample();
            cm.Show();
        }

        private void FlowDocumentScrollViewerZoomSample_Click(object sender, RoutedEventArgs e)
        {
            FlowDocumentScrollViewerZoomSample wd = new FlowDocumentScrollViewerZoomSample();
            wd.Show();
        }

        private void FlowDocumentPageViewerZoomSample_Click(object sender, RoutedEventArgs e)
        {
            FlowDocumentPageViewerSample wd = new FlowDocumentPageViewerSample();
            wd.Show();
        }

        private void FlowDocumentSearchSample_Click(object sender, RoutedEventArgs e)
        {
            FlowDocumentSearchSample wd = new FlowDocumentSearchSample();
            wd.Show();
        }

        private void FlowDocumentReaderSample_Click(object sender, RoutedEventArgs e)
        {
            FlowDocumentReaderSample wd = new FlowDocumentReaderSample();
            wd.Show();
        }

        private void ExtendedFlowDocumentSample_Click(object sender, RoutedEventArgs e)
        {
            ExtendedFlowDocumentSample wd = new ExtendedFlowDocumentSample();
            wd.Show();
        }

        private void Button_ProgressBar_Click(object sender, RoutedEventArgs e)
        {
            ProgressBarTaskOnUiThread wd  = new ProgressBarTaskOnUiThread();
            wd.ShowDialog();
        }

        private void Button_Open_Browser_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserControlSample wd = new WebBrowserControlSample();
            wd.Show();
        }

        /*  private void btnEnterName_Click(object sender, RoutedEventArgs e)
          {
              InputDialogSample inputDialog = new InputDialogSample("Please enter your name:", "John Doe");
              if (inputDialog.ShowDialog() == true)
                  lblName.Text = inputDialog.Answer;
          }

          private void btnMenu_Click(object sender, RoutedEventArgs e)
          {
              MenuCtrl menuSample = new MenuCtrl();
              menuSample.Show();
          }*/
        /*        if a resource is not found, the search progresses up the hierarchy, so in principal, we could have used the FindResource()
*        method on the panel in all three cases, since it would have continued up to the window and later on up to the application level, if not found.
*/       /* private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            //lbResult.Items.Add(pnlMain.FindResource("ComboBoxTitle").ToString());
            lbResult.Items.Add(this.FindResource("WindowComboBoxTitle").ToString());
            lbResult.Items.Add(Application.Current.FindResource("AppComboBoxTitle").ToString());

           lbResult.Items.Add(pnlMain.FindResource("WindowComboBoxTitle").ToString());

            lbResult.Items.Add(pnlMain.FindResource("AppComboBoxTitle").ToString());
        }*/

        /*  EXCEPTION HALNDLER EXAMPLE*/
        /*        private void Button_Click(object sender, RoutedEventArgs e)
                {
                    string s = null;
                    try
                    {
                        s.Trim();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    s.Trim();
                }
        */



        //private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        //{
        //    MVVMFormBasic.ViewModel.StudentViewModel studentViewModelObject =
        //       new MVVMFormBasic.ViewModel.StudentViewModel();
        //   /// studentViewModelObject.LoadStudents();

        //    StudentViewControl.DataContext = studentViewModelObject;
        //}
    }
}