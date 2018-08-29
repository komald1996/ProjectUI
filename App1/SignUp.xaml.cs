using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        public SignUp()
        {
            InitializeComponent();      
            


        }

        private void clear()
        {
            first_name.Text = "";
            last_name.Text = "";
            email.Text = "";
            mobile.Text = "";
            password.Password = "";
            confirm_password.Password = "";
        }

        private void forgot_pass_submit_Click(object sender, RoutedEventArgs e)
        {
            string sec = (this.security_question.SelectedValue as ComboBoxItem).Content.ToString();

            if (first_name.Text == "")
            {
                MessageBox.Show("Please enter First Name");
                first_name.Focus();
            }
            else if (last_name.Text == "")
            {
                MessageBox.Show("Please enter Last Name");
                last_name.Focus();
            }
            else if (email.Text.Length == 0)
            {

                MessageBox.Show("Please enter an email.");
                email.Focus();

            }
            else if(!Regex.IsMatch(email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Please enter a valid email.");
                email.Select(0, email.Text.Length);
                email.Focus();
            }
            else if (mobile.Text == "")
            {
                MessageBox.Show("Please enter Mobile Number");
                mobile.Focus();
            }
            else if (!Regex.IsMatch(mobile.Text, @"[0-9]"))
            {
                MessageBox.Show("Mobile Number can only have numbers.\nPlease enter a 10 digit Mobile Number");
                mobile.Focus();
            }
            else if (password.Password == "")
            {
                MessageBox.Show("Please enter a Password");
                password.Focus();
            }
            else if (confirm_password.Password != password.Password)
            {
                MessageBox.Show("Passwords do not match!");
                confirm_password.Focus();
            }
            else
            {
                

                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                    connection.Open();
                   // string sql = $"insert into user_info (firstname, lastname, email, mobile_no, password, securityquestion, answer) values (@fname, @lname, @email, @mobile, @password, @secques, @secans)"; 

                    string sql = $"insert into user_info (firstname, lastname, email, mobile_no, password, securityquestion, answer) values ('{first_name.Text}', '{last_name.Text}', '{email.Text}', {mobile.Text}, '{password.Password}', '{sec}', '{security_answer.Text}')" ;

                    using (SqlCommand mycommand = new SqlCommand(sql, connection))
                    {
                        /*

                        SqlParameter param = new SqlParameter
                        {
                            ParameterName = "@fname",
                            Value = first_name,
                            SqlDbType = SqlDbType.Char,
                            Size = 10
                        };
                        mycommand.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@lname",
                            Value = last_name,
                            SqlDbType = SqlDbType.Char,
                            Size = 10
                        };
                        mycommand.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@email",
                            Value = email,
                            SqlDbType = SqlDbType.Char,
                            Size = 10
                        };
                        mycommand.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@mobile",
                            Value = mobile,
                            SqlDbType = SqlDbType.Char,
                            Size = 10
                        };
                        mycommand.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@password",
                            Value = password,
                            SqlDbType = SqlDbType.Char,
                            Size = 10
                        };
                        mycommand.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@secques",
                            Value = sec,
                            SqlDbType = SqlDbType.Char,
                            Size = 10
                        };
                        mycommand.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@secans",
                            Value = security_answer,
                            SqlDbType = SqlDbType.Char,
                            Size = 10
                        };
                        mycommand.Parameters.Add(param);

                        */

                        mycommand.ExecuteNonQuery();
                    }
                }

                clear();
                

            }

        }

        private void first_name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void mobile_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void security_question_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void security_answer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Hyperlink_Click_2(object sender, RoutedEventArgs e)
        {
            Login su = new Login();
            if (su != null)
            {
                this.Content = su;
            }
        }

        private void resultButton_Click(object sender, RoutedEventArgs e)
        {
            Login lo = new Login();
            this.NavigationService.Navigate(lo);
        }
    }
}
