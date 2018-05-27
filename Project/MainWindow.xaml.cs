﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using Project.OtherWindows;

namespace Project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Project.BL.CheckUser checkUser;
        public MainWindow()
        {
            InitializeComponent();
            Database.SetInitializer(new CreateDatabaseIfNotExists<DAL.Context>());
            checkUser = new BL.CheckUser();
        }

        private void tbPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnRegist_Click(object sender, RoutedEventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.ShowDialog();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == "")
            {
                MessageBox.Show("Error!", "Enter Login!", MessageBoxButton.OK);
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Error!", "Enter Password!", MessageBoxButton.OK);
            }
            else
            {
                if (checkUser.LoginedUser(tbLogin.Text, tbPassword.Text))
                {
                    if (checkUser.AdminUser(tbLogin.Text))
                    {
                        AdminUser adminUser = new AdminUser();
                        adminUser.ShowDialog();
                    }
                    else
                    {
                        CommonUser commonUser = new CommonUser();
                        commonUser.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Error!", "Enter correct data!", MessageBoxButton.OK);
                }
                //MessageBox.Show(checkUser.Test(tbLogin.Text, tbPassword.Text).ToString());
                //checkUser.Test(tbLogin.Text, tbPassword.Text);
            }
        }
    }
}
