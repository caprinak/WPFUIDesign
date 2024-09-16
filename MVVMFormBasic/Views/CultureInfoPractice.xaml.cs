using MVVMFormBasic.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
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
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace MVVMFormBasic.Views
{
    /// <summary>
    /// Interaction logic for CultureInfoPractice.xaml
    /// </summary>
    public partial class CultureInfoPractice : UserControl
    {
        public CultureInfoPractice()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sv-SE");
            InitializeComponent();
        }
       /* Applying another culture to your WPF application is quite easy.You will, potentially, be dealing with two attributes, found on the
        * CurrentThread property of the Thread class: CurrentCulture and CurrentUICulture.But what's the difference?

The CurrentCulture property is the one that controls how numbers and dates etc.are formatted.The default value comes from the operating system
       of the computer executing the application and can be changed independently of the language used by their operating system.It is, for 
       instance, very common for a person living in Germany to install Windows with English as their interface language, while still preferring
       German-notation for numbers and dates.For a situation like this, the CurrentCulture property would default to German.
        The CurrentUICulture property specifies the language that the interface should use.This is only relevant if your application supports
       multiple languages, e.g.through the use of language-resource files.Once again, this allows you to use one culture for the language (e.g.English),
       while using another (e.g.German) when dealing with input/output of numbers, dates etc.
*/
        private void CultureInfoSwitchButton_Click(object sender, RoutedEventArgs e)
    {
      Thread.CurrentThread.CurrentCulture = new CultureInfo((sender as Button).Tag.ToString());
        lblNumber.Content = (123456789.42d).ToString("N2");
        lblDate.Content = DateTime.Now.ToString();
    }


       /* If your application uses more than one thread, you should consider using the DefaultThreadCurrentCulture property.It can be found 
        * on the CultureInfo class (introduced in .NET framework version 4.5) and will ensure that not only the current thread, but also future 
        * threads will use the same culture.You can use it like this, e.g. in the Application_Startup event:

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("de-DE");
    So, will you have to set both the CurrentCulture AND the DefaultThreadCurrentCulture properties? Actually, no - if you have not already 
       changed the CurrentCulture property, setting the DefaultThreadCurrentCulture property will also be applied to the CurrentCulture property. 
       In other words, it makes sense to use the DefaultThreadCurrentCulture instead of CurrentCulture if you plan on using multiple threads in your
       application -it will take care of all scenarios.
*/    }
}
