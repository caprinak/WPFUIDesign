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

namespace MVVMFormBasic.DataGrid
{
    /// <summary>
    /// Interaction logic for DataGridDetailsAdvanced.xaml
    /// </summary>
    public partial class DataGridDetailsAdvanced : UserControl
    {
        public DataGridDetailsAdvanced()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl = "https://e7.pngegg.com/pngimages/35/387/png-clipart-squirrel-cartoon-funny-animal-play-mobile-phone-3d-squirrel-mammal-animals-thumbnail.png" });
            users.Add(new User() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17), ImageUrl = "/Images/USER.png" });
            users.Add(new User() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c2/Peter_Griffin.png/220px-Peter_Griffin.png" });

            dgUsers.ItemsSource = users;
        }
        public class User
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public DateTime Birthday { get; set; }

            public string ImageUrl { get; set; }
        }
    }
}
