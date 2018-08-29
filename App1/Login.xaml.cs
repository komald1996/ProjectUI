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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();

           

        }

        
        private void login_btn_Click(object sender, RoutedEventArgs e)
        {

            if(username.Text == "admin" && password.Password == "admin123")
            {
                AdminDashboard du = new AdminDashboard();
                this.NavigationService.Navigate(du);

            }


           else if (username.Text != "" & password.Password != "")
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                    connection.Open();
                    string sql = $"SELECT PASSWORD FROM USER_INFO WHERE user_id={username.Text}"; //CREATE A SQL COMMAND OBJECT
                    SqlCommand myCommand = new SqlCommand(sql, connection);
                    using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                    {
                        while (myDataReader.Read())
                        {
                            //Console.WriteLine($"->Code:{myDataReader["user_id"]}," + $"Name: {myDataReader["vFirstname"]}.");                        
                                
                                

                            string pas= myDataReader["PASSWORD"].ToString();
                            if (password.Password.ToString() == myDataReader["PASSWORD"].ToString())
                            {

                                Dashboard dash = new Dashboard();
                                if (dash != null)
                                {
                                    this.NavigationService.Navigate(dash);

                                }
                            }
                            else if (password.Password.ToString() != myDataReader["PASSWORD"].ToString() || myDataReader["PASSWORD"] == null)
                           {
                               lblerror.Visibility = Visibility.Visible;
                               username.Focus();
                               break;
                           }

                        }
                    }
                }


                

            }
            else if (username.Text == "" || password.Password == "")
            {
                lblblank.Visibility = Visibility.Visible;
                username.Focus();
            }
            

            


        }
        
        

        private string ToString(object v)
        {
            throw new NotImplementedException();
        }


        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            if (fp != null)
            {
                this.Content = fp;
            }
        }
        
        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            SignUp su = new SignUp();
            if (su != null)
            {
                this.Content = su;
            }
        }

    }
}
