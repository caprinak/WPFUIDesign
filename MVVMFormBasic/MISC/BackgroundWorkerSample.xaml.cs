using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MVVMFormBasic.MISC
{
    /// <summary>
    /// Interaction logic for BackgroundWorkerSample.xaml
    /// </summary>
    public partial class BackgroundWorkerSample : UserControl
    {
        public BackgroundWorkerSample()
        {
            InitializeComponent();
        }

        private void btnDoSynchronousCalculation_Click(object sender, RoutedEventArgs e)
        {
            int max = 10;
            pbCalculationProgress.Value = 0;
            lbResults.Items.Clear();

            int result = 0;
            for (int i = 0; i < max; i++)
            {
                if (i % 5 == 0)
                {
                    lbResults.Items.Add(i);
                    result++;
                }
                System.Threading.Thread.Sleep(1);
                pbCalculationProgress.Value = Convert.ToInt32(((double)i / max) * 100);
            }
            MessageBox.Show("Numbers between 0 and 10000 divisible by 7: " + result);
        }

        private void btnDoAsynchronousCalculation_Click(object sender, RoutedEventArgs e)
        {
            pbCalculationProgress.Value = 0;
            lbResults.Items.Clear();

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            //All the hard work is now placed in the DoWork event, which the worker calls after you run the RunWorkerAsync() method. 
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            //This method takes input from your application which can be used by the worker
            worker.RunWorkerAsync(9);
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int max = (int)e.Argument;
            int result = 0;
            for (int i = 0; i < max; i++)
            {   
                int progressPercentage = Convert.ToInt32(((double)i / max) * 100);
                if (i % 2 == 0)
                {
                    result++;
                    //we're not allowed to update the UI from the DoWork event. Instead, we call the ReportProgress
                    //method on the worker

                    //Its secondary argument is called userState and is an object type, meaning that you can pass
                    //whatever you want to the ProgressChanged method.
                    (sender as BackgroundWorker).ReportProgress(progressPercentage, i);
                }
                else
                    (sender as BackgroundWorker).ReportProgress(progressPercentage);
                System.Threading.Thread.Sleep(1000);

            }
            //Once all the numbers have been tested, we assign the result to the e.Result property.
            //This will then be carried to the RunWorkerCompleted event, where we show it to the user
            e.Result = result;
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbCalculationProgress.Value = e.ProgressPercentage;
            if (e.UserState != null)
                lbResults.Items.Add(e.UserState);
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Numbers between 0 and 10000 divisible by 7: " + e.Result);
        }
/*        Notice that both the input, in form of the argument passed to the RunWorkerAsync() method,as well as 
 *        the output, in form of the value assigned to the e.Result property of the DoWork event, are of the 
 *        object type.This means that you can assign any kind of value to them
*/    }
}
