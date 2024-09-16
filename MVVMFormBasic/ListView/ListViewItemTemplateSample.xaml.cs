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

namespace MVVMFormBasic.ListView
{
    /// <summary>
    /// Interaction logic for ListViewItemTemplateSample.xaml
    /// </summary>
    public partial class ListViewItemTemplateSample : UserControl
    {
        public ListViewItemTemplateSample()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items.Add(new User() { Name = "Aloe vera", Age = 39, Mail = "a@vvvera-aasd.com" });
            items.Add(new User() { Name = "Edible Chaya", Age = 13, Mail = "e.cha@gmail.com" });
            lvDataBinding.ItemsSource = items;
        }

        public class User
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string Mail { get; set; }
        }
    }
}
