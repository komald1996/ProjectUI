﻿using System;
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
            Dashboard dash = new Dashboard();
            if (dash != null)
            {
                this.NavigationService.Navigate(dash);

            }
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
