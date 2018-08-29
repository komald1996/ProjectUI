using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for Form.xaml
    /// </summary>
    public partial class Form : Page
    {
        public Form()
        {
            InitializeComponent();
            
        }
        //string userid = ConfigurationManager.AppSettings["user_id"];
        private void txtbQuantity_textchanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            int n;
            if (!int.TryParse(txtbQuantity.Text, out n))
            {
                lblerror.Visibility = Visibility.Visible;
                txtbQuantity.Focus();
                return;
            }
            MessageBox.Show(App.userId.ToString());

        }
        private void cbStockName_selectionchanged(object sender, SelectionChangedEventArgs e)
        {
            int index = cbStockName.SelectedIndex;
            if (index == 1)
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                    connection.Open();
                    string sql = "SELECT TOP 1 PRICE FROM EXECUTED_TABLE "; //CREATE A SQL COMMAND OBJECT
                    SqlCommand myCommand = new SqlCommand(sql, connection);
                    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                    {
                        while (myDataReader.Read())
                        {
                            //Console.WriteLine($"->Code:{myDataReader["user_id"]}," + $"Name: {myDataReader["vFirstname"]}.");
                            lblLtp.Content = myDataReader["price"].ToString();
                            btnRefresh.Visibility = Visibility.Visible;
                        }
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            int index = cbStockName.SelectedIndex;
            if (index == 1)
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                    connection.Open();
                    string sql = "SELECT TOP 1 PRICE FROM EXECUTED_TABLE "; //CREATE A SQL COMMAND OBJECT
                    SqlCommand myCommand = new SqlCommand(sql, connection);
                    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                    {
                        while (myDataReader.Read())
                        {
                            //Console.WriteLine($"->Code:{myDataReader["user_id"]}," + $"Name: {myDataReader["vFirstname"]}.");
                            lblLtp.Content = myDataReader["price"].ToString();
                            
                        }
                    }
                }
            }
        }
    }
}
