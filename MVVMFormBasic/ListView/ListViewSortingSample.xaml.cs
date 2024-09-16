using MVVMFormBasic.Model;
using System;
using System.Collections;
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

namespace MVVMFormBasic.ListView
{
    /// <summary>
    /// Interaction logic for ListViewSortingSample.xaml
    /// </summary>
    public partial class ListViewSortingSample : UserControl
    {
        public ListViewSortingSample()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "Babie", Age = 42 });
            items.Add(new User() { Name = "levy", Age = 39 });
            items.Add(new User() { Name = "Jack", Age = 13 });
            items.Add(new User() { Name = "Donna", Age = 13 });
            lvUsers.ItemsSource = items;

       //use the ItemsSource property to get the CollectionView instance that the ListView automatically
       //creates for us and which we can use to manipulate how the ListView shows our objects.
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
        /*    With the view object in our hand, we add a new SortDescription to it, specifying that we want 
                our list sorted by the Age property, in ascending order.*/
            //view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));


        /*            Multiple sort criteria Sample            */

            view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
            view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }
    }
}
