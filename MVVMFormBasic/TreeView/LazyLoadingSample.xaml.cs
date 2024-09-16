using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
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

namespace MVVMFormBasic.TreeView
{
    /// <summary>
    /// Interaction logic for LazyLoadingSample.xaml
    /// </summary>
    public partial class LazyLoadingSample : UserControl
    {
        public LazyLoadingSample()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in drives)
                trvStructure.Items.Add(CreateTreeItem(driveInfo));
        }

        //this event is raised each time a TreeView item is expanded.
        //By subscribing to the Expanded event, we can easily create a lazy-loaded TreeView
        public void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = e.Source as TreeViewItem;

            //check whether this item has already been loaded, by checking if the child items currently
            //consists of only one item, which is a string - if so, we have found the "Loading..."
            //child item, which means that we should now load the actual contents and replace the
            //placeholder item with it.

            if ((item.Items.Count == 1) && (item.Items[0] is string))
            {
                item.Items.Clear();

                DirectoryInfo expandedDir = null;
                //use the items Tag property to get a reference to the DriveInfo or DirectoryInfo instance
                //that the current item represents
                if (item.Tag is DriveInfo)
                    expandedDir = (item.Tag as DriveInfo).RootDirectory;
                if (item.Tag is DirectoryInfo)
                    expandedDir = (item.Tag as DirectoryInfo);
                try
                {
                    foreach (DirectoryInfo subDir in expandedDir.GetDirectories())
                        item.Items.Add(CreateTreeItem(subDir));
                }
                catch { }

  /*  *** Notice that the loop where we add each child folder is in a try..catch block - this is important,
    because some paths might not be accessible, usually for security reasons. */
            }
        }
        private TreeViewItem CreateTreeItem(object o)
        {
            TreeViewItem item = new TreeViewItem();

           // adding each drive found on the computer to the TreeView control.We assign the DriveInfo
           // instance to the Tag property, so that we can later retrieve it.
            item.Header = o.ToString();
            item.Tag = o;
            item.Items.Add("Loading...");
            return item;
        }
    }
}
