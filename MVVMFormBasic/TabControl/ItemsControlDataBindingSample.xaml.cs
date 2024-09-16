using System;
using System.Collections;
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

namespace MVVMFormBasic.TabControl
{
    /// <summary>
    /// Interaction logic for ItemsControlDataBindingSample.xaml
    /// </summary>
    public partial class ItemsControlDataBindingSample : UserControl
    {
        public ItemsControlDataBindingSample()
        {
            InitializeComponent();
            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45 });
            items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
            items.Add(new TodoItem() { Title = "Wash the car", Completion = 0 });
/*            In the end, this list of Template Items is assigned to the ItemsSource property of our ItemsControl,
 *            which then does the rest of the job for us
*/            
                        icTodoList.ItemsSource = items;
        }
        public class TodoItem
        {
            public string Title { get; set; }
            public int Completion { get; set; }
        }
    }
}
