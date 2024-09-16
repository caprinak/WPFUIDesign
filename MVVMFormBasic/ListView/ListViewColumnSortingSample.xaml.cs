using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
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
    /// Interaction logic for ListViewColumnSortingSample.xaml
    /// </summary>
    public partial class ListViewColumnSortingSample : UserControl
    {
        //listViewSortCol keeps track of which column we're currently sorting by.
        private GridViewColumnHeader listViewSortCol = null;

        //listViewSortAdorner keeps track of the adorner we placed to indicate it.
        private SortAdorner listViewSortAdorner = null;

        public ListViewColumnSortingSample()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", Age = 42, Sex = SexType.Male });
            items.Add(new User() { Name = "Jane Doe", Age = 39, Sex = SexType.Female });
            items.Add(new User() { Name = "Sammy Doe", Age = 13, Sex = SexType.Male });
            items.Add(new User() { Name = "Donna Doe", Age = 13, Sex = SexType.Female });
            lvUsers.ItemsSource = items;
        }
        private void lvUsersColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();
            if (listViewSortCol != null)
            {
                AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortAdorner);
                lvUsers.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
                newDir = ListSortDirection.Descending;

            listViewSortCol = column;
            listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
            // add this newly created SortAdorner to the AdornerLayer of the column header
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
            //we add a SortDescription to the ListView, to let it know which property to sort by and in which
            //direction.
            lvUsers.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }

        //SortAdorner. All this little class does is to draw a triangle, either pointing up or down,
        //depending on the sort direction. WPF uses the concept of adorners to allow you to paint stuff
        //over other controls, and this is exactly what we want here: The ability to draw a sorting
        //triangle on top of our ListView column header.
        public class SortAdorner : Adorner
        {
            //SortAdorner works by defining two Geometry objects, which are basically used to describe 2D shapes
            //- in this case a triangle with the tip pointing up and one with the tip pointing down. The Geometry.
            //Parse() method uses the list of points to draw the triangles
            private static Geometry ascGeometry =
                Geometry.Parse("M 0 4 L 3.5 0 L 7 4 Z");

            private static Geometry descGeometry =
                Geometry.Parse("M 0 0 L 3.5 4 L 7 0 Z");

            //SortAdorner is aware of the sort direction, because it needs to draw the proper triangle, but is
            //not aware of the field that we order by - this is handled in the UI layer.
            public ListSortDirection Direction { get; private set; }

            public SortAdorner(UIElement element, ListSortDirection dir)
                : base(element)
            {
                this.Direction = dir;
            }

            protected override void OnRender(DrawingContext drawingContext)
            {
                base.OnRender(drawingContext);

                if (AdornedElement.RenderSize.Width < 20)
                    return;

                TranslateTransform transform = new TranslateTransform
                    (
                        AdornedElement.RenderSize.Width - 15,
                        (AdornedElement.RenderSize.Height - 5) / 2
                    );
                drawingContext.PushTransform(transform);

                Geometry geometry = ascGeometry;
                if (this.Direction == ListSortDirection.Descending)
                    geometry = descGeometry;
                drawingContext.DrawGeometry(Brushes.Black, null, geometry);

                drawingContext.Pop();
            }
        }

    }
}
