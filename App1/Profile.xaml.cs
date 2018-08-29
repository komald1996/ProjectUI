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
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace App1
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
        }
        long user_id=14;
        public void loader(Object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                connection.Open();
                string sql = $"SELECT FIRSTNAME, LASTNAME, EMAIL, MOBILE_NO, PASSWORD FROM USER_INFO WHERE USER_ID={user_id}"; //CREATE A SQL COMMAND OBJECT
                SqlCommand myCommand = new SqlCommand(sql, connection);
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        //Console.WriteLine($"->Code:{myDataReader["user_id"]}," + $"Name: {myDataReader["vFirstname"]}.");
                        lblFN.Content = myDataReader["FIRSTNAME"].ToString();
                        lblLN.Content = myDataReader["LASTNAME"].ToString();
                        lblmail.Content = myDataReader["EMAIL"].ToString();
                        lblPhNo.Content = myDataReader["MOBILE_NO"].ToString();
                        lblPwd.Content = myDataReader["PASSWORD"].ToString();
                    }
                }
            }
            lblUid.Content = user_id;
        }

        private void btnedit_Click(object sender, RoutedEventArgs e)
        {
            txtbFirstName.Text = lblFN.Content.ToString();
            txtbFirstName.Visibility = Visibility.Visible;
            txtbLastName.Text = lblLN.Content.ToString();
            txtbLastName.Visibility = Visibility.Visible;
            txtbmail.Visibility = Visibility.Visible;
            txtbmail.Text = lblmail.Content.ToString();
            txtbPhNo.Text = lblPhNo.Content.ToString();
            txtbPhNo.Visibility = Visibility.Visible;
            lblFN.Visibility = Visibility.Hidden;
            lblLN.Visibility = Visibility.Hidden;
            lblmail.Visibility = Visibility.Hidden;
            lblPhNo.Visibility = Visibility.Hidden;
            btnSubmit.Visibility = Visibility.Visible;

        }
        private void btnloginedit_Click(object sender, RoutedEventArgs e)
        {

            lblConfirmPassword.Visibility = Visibility.Visible;
            txtbConfirmPassword.Visibility = Visibility.Visible;
            txtbPassword.Visibility = Visibility.Visible;
            lblPwd.Visibility = Visibility.Hidden;
            btnSubmitPD.Visibility = Visibility.Visible;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                connection.Open();
                string sql = $"UPDATE USER_INFO SET FIRSTNAME='{txtbFirstName.Text.ToString()}', LASTNAME='{txtbLastName.Text.ToString()}', EMAIL='{txtbmail.Text.ToString()}', MOBILE_NO='{txtbPhNo.Text.ToString()}' WHERE USER_ID='{user_id}'"; //CREATE A SQL COMMAND OBJECT
                
                using (SqlCommand myCommand = new SqlCommand(sql, connection))
                {
                    myCommand.ExecuteNonQuery();
                }
            }
            lblFN.Content = txtbFirstName.Text.ToString();
            txtbFirstName.Visibility = Visibility.Hidden;
            lblFN.Visibility = Visibility.Visible;
            lblLN.Content = txtbLastName.Text.ToString();
            txtbLastName.Visibility = Visibility.Hidden;
            lblLN.Visibility = Visibility.Visible;
            lblmail.Content = txtbmail.Text.ToString();
            txtbmail.Visibility = Visibility.Hidden;
            lblmail.Visibility = Visibility.Visible;
            lblPhNo.Content = txtbPhNo.Text.ToString();
            txtbPhNo.Visibility = Visibility.Hidden;
            lblPhNo.Visibility = Visibility.Visible;
            btnSubmit.Visibility = Visibility.Hidden;
        }

        private void btnSubmitPD_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                connection.Open();
                string sql = $"UPDATE USER_INFO SET PASSWORD='{txtbPassword.Text.ToString()}' WHERE USER_ID='{user_id}'"; //CREATE A SQL COMMAND OBJECT

                using (SqlCommand myCommand = new SqlCommand(sql, connection))
                {
                    myCommand.ExecuteNonQuery();
                }
            }

            txtbPassword.Visibility = Visibility.Hidden;
            lblPwd.Content = txtbPassword.Text.ToString();
            txtbConfirmPassword.Visibility = Visibility.Hidden;
            btnSubmitPD.Visibility = Visibility.Hidden;
        }
    }
}
