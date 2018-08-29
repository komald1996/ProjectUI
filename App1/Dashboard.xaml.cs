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

            uId.Content = App.userId;

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                connection.Open();
                string sql = $"SELECT firstname, lastname  FROM USER_INFO WHERE user_id = {uId.Content.ToString()}"; //CREATE A SQL COMMAND OBJECT
                SqlCommand myCommand = new SqlCommand(sql, connection);
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        fname.Content = myDataReader["firstname"].ToString();
                        lname.Content = myDataReader["lastname"].ToString();

                    }
                }


            }

            
            

        }

        private void txtbOrder_Click(object sender, RoutedEventArgs e)
        {
            NewFrame.Navigate(new System.Uri("Form.xaml", UriKind.RelativeOrAbsolute));
        }

        private void txtHoldings_Click(object sender, RoutedEventArgs e)
        {
            NewFrame.Navigate(new System.Uri("Holdings.xaml", UriKind.RelativeOrAbsolute));
        }

        private void txtbPositions_Click(object sender, RoutedEventArgs e)
        {
            NewFrame.Navigate(new System.Uri("Positions.xaml", UriKind.RelativeOrAbsolute));
        }

        private void txtbOrderbook_Click(object sender, RoutedEventArgs e)
        {
            NewFrame.Navigate(new System.Uri("OrderBook.xaml", UriKind.RelativeOrAbsolute));
        }



        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Login lo = new Login();
            this.NavigationService.Navigate(lo);
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            NewFrame.Navigate(new System.Uri("Profile.xaml", UriKind.RelativeOrAbsolute));
        }

        private void NewFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
