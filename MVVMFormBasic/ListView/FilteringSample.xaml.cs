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
using static MVVMFormBasic.ListView.ListViewGroupSample;

namespace MVVMFormBasic.ListView
{
    /// <summary>
    /// Interaction logic for FilteringSample.xaml
    /// </summary>
    public partial class FilteringSample : UserControl
    {
        public FilteringSample()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "Austin Doe", Age = 42 });
            items.Add(new User() { Name = "Sascha Doe", Age = 39 });
            items.Add(new User() { Name = "Michael Doe", Age = 13 });
            items.Add(new User() { Name = "Oliver Doe", Age = 13 });
            lvUsers.ItemsSource = items;
            // obtain a reference to the CollectionView instance for the ListView
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            //assign a delegate to the Filter property
            view.Filter = UserFilter;
        }
        private bool UserFilter(object item)
        {
            //takes each item as the first (and only) parameter and then returns a boolean value that indicates
            //whether or not the given item should be visible on the list.
            if (String.IsNullOrEmpty(txtFilter.Text))
                return true;
            else
                //check whether or not the name of the User (which is the property we have decided to filter on)
                //contains the entered string, and then return true or false depending on that
                return ((item as User).Name.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    ((item as User).Age.ToString().IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }
        private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
/*            get a reference to the View object of the ListView and then call the Refresh() method on it.
 *            This ensures that the Filter delegate is called each time the user changes the value of the search 
 *            / filter string text box.
*/            CollectionViewSource.GetDefaultView(lvUsers.ItemsSource).Refresh();
        }
    }
}
