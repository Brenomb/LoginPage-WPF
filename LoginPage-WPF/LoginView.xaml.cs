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

namespace LoginPage_WPF
{
    /// <summary>
    /// Logica di interazione per LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string usernameEntered = UsernameTextBox.Text;
            string passwordEntered = PasswordBox.Password;

            string fixedUsername = "admin";
            string fixedPassword = "admin";

            if (usernameEntered == fixedUsername && passwordEntered == fixedPassword)
            {
                MessageBox.Show("Login Executed!");
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password.");
            }
        }


        public void OnPasswordChanged(object sender, EventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}


