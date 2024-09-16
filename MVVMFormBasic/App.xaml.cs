using System.Configuration;
using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Windows;
using System.Windows.Documents;

namespace MVVMFormBasic
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// You will see how this class extends the Application class, allowing us to do stuff on the application level.
    /// For instance, you can subscribe to the Startup event, where you can manually create your starting window.


    public partial class App : Application
    {
        /*       private void Application_Startup(object sender, StartupEventArgs e)
       *//*            The cool thing in this example, compared to just using the StartupUri property, is that we get to manipulate
        *            the startup window before showing it.In this, we change the title of it, which is not terribly useful, 
        *            but you could also subscribe to events or perhaps show a splash screen.
       *//*        {
                   // Create the startup window
                   MainWindow wnd = new MainWindow();
                   // Do stuff here, e.g. to the window
                   wnd.Title = "I can customize it here";
                   // Show the window
                   wnd.Show();
               }*/



        /*        The StartupEventArgs is what we use here.It's passed into the Application Startup event, with the name e. 
         *        It has the property Args, which is an array of strings
         *        
         *         To run, From the Project menu select "[Project name] properties" and then go to the Debug tab, where 
         *         you can define  a command-line parameter
         *         
         *         HINT: In a real world example, you might collect several arguments and even use them for options, e.g.toggling a certain
         *         feature on or off.You would do that by looping through the entire list of arguments passed while collecting the information you need to proceed,

         *        
        */



        public static string[] Args;
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            if (e.Args.Length > 0)
            {
                Args = e.Args;
                MessageBox.Show(Args[0]);
            }
        }
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception just occurred: " + e.Exception.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }
    }

}
