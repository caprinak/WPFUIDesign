using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVVMFormBasic.MISC
{
    /// <summary>
    /// Interaction logic for BackgroundWorkerCancellationSample.xaml
    /// </summary>
    public partial class BackgroundWorkerCancellationSample : UserControl
    {
        private BackgroundWorker worker = null;

        public BackgroundWorkerCancellationSample()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
/*            WorkerSupportsCancellation and WorkerReportsProgress properties which we set to true - without that,
 *            an exception will be thrown if we try to use these features.
*/            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            worker.RunWorkerAsync();
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
/*            CancelAsync() method - this will signal to the worker that the user would like to cancel the
 *            running process by setting the CancellationPending property to true
*/            worker.CancelAsync();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
/*                check the CancellationPending property on each iteration - if the worker is cancelled, this 
 *                property will be true and I will have the opportunity to jump out of the loop.
*/                if (worker.CancellationPending == true)
                {
/*                    set the Cancel property on the event arguments, to signal that the process was cancelled
 *                    - this value is used in the RunWorkerCompleted event to see if the worker actually completed 
 *                    or if it was cancelled.
*/                    e.Cancel = true;
                    return;
                }
                worker.ReportProgress(i);
                System.Threading.Thread.Sleep(250);
            }
            e.Result = "Age of Empires 2 loaded";
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = "Working... (" + e.ProgressPercentage + "%)";
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
            // check if the worker was cancelled or not and then update the status label accordingly.
        {
            if (e.Cancelled)
            {
                lblStatus.Foreground = Brushes.Red;
                lblStatus.Text = "Cancelled by user...";
            }
            else
            {
                lblStatus.Foreground = Brushes.Green;
                lblStatus.Text = "Done... Calc result: " + e.Result;
            }
        }
    }
}
