using System;
using System.Collections.Generic;
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

        private void forgot_pass_submit_Click(object sender, RoutedEventArgs e)
        {

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

                first_name.Text = "";
                last_name.Text = "";
                email.Text = "";
                mobile.Text = "";
                password.Password = "";
                confirm_password.Password = "";

                Login lo = new Login();
                this.NavigationService.Navigate(lo);

            }

        }


    }
}
