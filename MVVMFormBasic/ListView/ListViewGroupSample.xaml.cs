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
    /// Interaction logic for ListViewGroupSample.xaml
    /// </summary>
    public partial class ListViewGroupSample : UserControl
    {
        public ListViewGroupSample()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", Age = 42, Sex = SexType.Male });
            items.Add(new User() { Name = "Aduka Soamoa", Age = 12, Sex = SexType.Female });
            items.Add(new User() { Name = "Aztec", Age = 33, Sex = SexType.Male });
            items.Add(new User() { Name = "Balaaa", Age = 11, Sex = SexType.NA });
            lvUsers.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
            view.GroupDescriptions.Add(groupDescription);
        }
        public enum SexType { Male, Female, NA };

        public class User
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string Mail { get; set; }

            public SexType Sex { get; set; }
        }
    }
}
