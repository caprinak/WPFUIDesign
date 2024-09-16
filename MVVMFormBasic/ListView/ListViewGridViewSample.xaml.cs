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
using static MVVMFormBasic.ListView.ListViewItemTemplateSample;

namespace MVVMFormBasic.ListView
{
    /// <summary>
    /// Interaction logic for ListViewGridViewSample.xaml
    /// </summary>
    public partial class ListViewGridViewSample : UserControl
    {
        public ListViewGridViewSample()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items.Add(new User() { Name = "Aloe vera", Age = 39, Mail = "a@vvvera-aasd.com" });
            items.Add(new User() { Name = "Edible Chaya", Age = 13, Mail = "e.cha@gmail.com" });
            lvUsers.ItemsSource = items;
        }
    }
}
