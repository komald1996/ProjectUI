using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void txtbOrder_Click(object sender, RoutedEventArgs e)
        {
            NewFrame.Navigate(new System.Uri("Form.xaml", UriKind.RelativeOrAbsolute));
        }

        private void txtHoldings_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void txtbPositions_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void txtbOrderbook_Click(object sender, RoutedEventArgs e)
        {
            
            
        }



        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Login lo = new Login();
            this.NavigationService.Navigate(lo);
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
