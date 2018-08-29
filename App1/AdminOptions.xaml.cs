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
    /// Interaction logic for AdminOptions.xaml
    /// </summary>
    public partial class AdminOptions : Page
    {
        public AdminOptions()
        {
            InitializeComponent();
        }

        private void clear()
        {
            
        }

        private void generate_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                connection.Open();
                // string sql = $"insert into user_info (firstname, lastname, email, mobile_no, password, securityquestion, answer) values (@fname, @lname, @email, @mobile, @password, @secques, @secans)"; 

                string sql = $"update admin_parameters set generator_on = 1 where aid=1";

                using (SqlCommand mycommand = new SqlCommand(sql, connection))
                {
                    mycommand.ExecuteNonQuery();
                }

                
            }
        }

        private void mrktSubmit_Click(object sender, RoutedEventArgs e)
        {

            if (double.Parse(mrktEdit.Text) >= 1 || double.Parse(mrktEdit.Text) < 0)
            {
                MessageBox.Show("Please enter the value from 0 to 1");
            }

            else
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                    connection.Open();
                    // string sql = $"insert into user_info (firstname, lastname, email, mobile_no, password, securityquestion, answer) values (@fname, @lname, @email, @mobile, @password, @secques, @secans)"; 

                    string sql = $"update admin_parameters set market_activity = '{mrktEdit.Text}' where aid=1";

                    using (SqlCommand mycommand = new SqlCommand(sql, connection))
                    {
                        mycommand.ExecuteNonQuery();
                    }

                    string sql2 = $"select market_activity from admin_parameters where aid=1";

                    using (SqlCommand mycommand1 = new SqlCommand(sql2, connection))
                    {

                        using (SqlDataReader myDataReader = mycommand1.ExecuteReader())
                        {

                            while (myDataReader.Read())
                            {
                                mrktVal.Text = myDataReader["market_activity"].ToString();
                            }
                        }
                    }

                }

            }


        }

        private void stckSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (double.Parse(stckEdit.Text) > 1 || double.Parse(stckEdit.Text) <= 0)
            {
                MessageBox.Show("Please enter the value from 0 to 1");
            }

            else
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                    connection.Open();
                    // string sql = $"insert into user_info (firstname, lastname, email, mobile_no, password, securityquestion, answer) values (@fname, @lname, @email, @mobile, @password, @secques, @secans)"; 

                    string sql = $"update admin_parameters set stock_volatality = '{stckEdit.Text}' where aid=1";

                    using (SqlCommand mycommand = new SqlCommand(sql, connection))
                    {
                        mycommand.ExecuteNonQuery();
                    }

                    string sql2 = $"select stock_volatality from admin_parameters where aid=1";

                    using (SqlCommand mycommand1 = new SqlCommand(sql, connection))
                    {

                        using (SqlDataReader myDataReader = mycommand1.ExecuteReader())
                        {

                            while (myDataReader.Read())
                            {
                                stckVal.Text = myDataReader["stock_volatality"].ToString();
                            }
                        }
                    }

                }
            }
        }

        private void userSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(userEdit.Text) < 1 || int.Parse(userEdit.Text) > 70000)
            {
                MessageBox.Show("Please enter the value between 1 and 70000");
            }

            else
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                    connection.Open();
                    // string sql = $"insert into user_info (firstname, lastname, email, mobile_no, password, securityquestion, answer) values (@fname, @lname, @email, @mobile, @password, @secques, @secans)"; 

                    string sql = $"update admin_parameters set no_of_ficticious_users = '{userEdit.Text}' where aid=1";

                    using (SqlCommand mycommand = new SqlCommand(sql, connection))
                    {
                        mycommand.ExecuteNonQuery();
                    }

                    string sql2 = $"select no_of_ficticious_users from admin_parameters where aid=1";

                    using (SqlCommand mycommand1 = new SqlCommand(sql, connection))
                    {

                        using (SqlDataReader myDataReader = mycommand1.ExecuteReader())
                        {

                            while (myDataReader.Read())
                            {
                                userVal.Text = myDataReader["no_of_ficticious_users"].ToString();
                            }
                        }
                    }

                }
            }
        }

        private void orderSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(orderEdit.Text) < 1 )
            {
                MessageBox.Show("Please enter integer value greater than 1");
            }

            else
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                    connection.Open();
                    // string sql = $"insert into user_info (firstname, lastname, email, mobile_no, password, securityquestion, answer) values (@fname, @lname, @email, @mobile, @password, @secques, @secans)"; 

                    string sql = $"update admin_parameters set no_of_random_orders = '{orderEdit.Text}' where aid=1";

                    using (SqlCommand mycommand = new SqlCommand(sql, connection))
                    {
                        mycommand.ExecuteNonQuery();
                    }

                    string sql2 = $"select no_of_random_orders from admin_parameters where aid=1";

                    using (SqlCommand mycommand1 = new SqlCommand(sql, connection))
                    {

                        using (SqlDataReader myDataReader = mycommand1.ExecuteReader())
                        {

                            while (myDataReader.Read())
                            {
                                orderVal.Text = myDataReader["no_of_random_orders"].ToString();
                            }
                        }
                    }

                }
            }
        }

        private void tickSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (double.Parse(tickEdit.Text) >= 1 || double.Parse(tickEdit.Text) <= 0)
            {
                MessageBox.Show("Please enter the value from 0 to 1 excluding 0 & 1");
            }

            else
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = "Data Source=GRAD27-HP; User ID=sa; Password=sa123; INITIAL CATALOG=project_db";
                    connection.Open();
                    // string sql = $"insert into user_info (firstname, lastname, email, mobile_no, password, securityquestion, answer) values (@fname, @lname, @email, @mobile, @password, @secques, @secans)"; 

                    string sql = $"update admin_parameters set tick_size = '{tickEdit.Text}' where aid=1";

                    using (SqlCommand mycommand = new SqlCommand(sql, connection))
                    {
                        mycommand.ExecuteNonQuery();
                    }

                    string sql2 = $"select tick_size from admin_parameters where aid=1";

                    using (SqlCommand mycommand1 = new SqlCommand(sql, connection))
                    {

                        using (SqlDataReader myDataReader = mycommand1.ExecuteReader())
                        {

                            while (myDataReader.Read())
                            {
                                tickVal.Text = myDataReader["tick_size"].ToString();
                            }
                        }
                    }

                }
            }
        }

    }
}
