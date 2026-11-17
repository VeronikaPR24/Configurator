using configurator_pc.Models;
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

namespace configurator_pc.Pages
{
    /// <summary>
    /// Логика взаимодействия для BuilderPage.xaml
    /// </summary>
    public partial class BuilderPage : Page
    {
        private User _user;

        public BuilderPage(User user)
        {
            InitializeComponent();
            _user = user;
            if(_user.Role == "Admin")
            {
                // btnAdminPanel.Visibility = Visibility.Visible; 
            }
        }
    }
}
