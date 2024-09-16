using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Windows.Shapes;

namespace MVVMFormBasic.Misc_Controls
{
    /// <summary>
    /// Interaction logic for WebBrowserControlSample.xaml
    /// </summary>
    public partial class WebBrowserControlSample : Window
    {
        public WebBrowserControlSample()
        {
            InitializeComponent();
            wbSample.Navigate("http://www.wpf-tutorial.com");
        }
/*        txtUrl_KeyUp event, in which we check to see if the user has hit Enter inside of the address
 *        bar - if so, we start navigating to the entered URL.
*/        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                wbSample.Navigate(txtUrl.Text);
        }
/*        wbSample_Navigating event makes sure that the address bar is updated each time a new 
 *        navigation starts.This is important because we want it to show the current URL no matter
 *        if the user initiated the navigation by entering a new URL or by clicking a link on 
 *        the webpage.
*/        private void wbSample_Navigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            txtUrl.Text = e.Uri.OriginalString;
        }

        private void BrowseBack_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ((wbSample != null) && (wbSample.CanGoBack));
        }

        private void BrowseBack_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            wbSample.GoBack();
        }

        private void BrowseForward_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ((wbSample != null) && (wbSample.CanGoForward));
        }

        private void BrowseForward_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            wbSample.GoForward();
        }

        private void GoToPage_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void GoToPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            wbSample.Navigate(txtUrl.Text);
        }

    }
}
