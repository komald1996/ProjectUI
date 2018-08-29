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

namespace App1
{
    /// <summary>
    /// Interaction logic for AdminDashboard.xaml
    /// </summary>
    public partial class AdminDashboard : Page
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void atbook_Click(object sender, RoutedEventArgs e)
        {
            NewFrame.Navigate(new System.Uri("AdminTradeBook.xaml", UriKind.RelativeOrAbsolute));

        }

        private void aoptions_Click(object sender, RoutedEventArgs e)
        {
            NewFrame.Navigate(new System.Uri("AdminOptions.xaml", UriKind.RelativeOrAbsolute));

        }

        private void aobook_Click(object sender, RoutedEventArgs e)
        {
            NewFrame.Navigate(new System.Uri("AdminOrderBook.xaml", UriKind.RelativeOrAbsolute));

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Login lo = new Login();
            this.NavigationService.Navigate(lo);
        }

        private void NewFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
