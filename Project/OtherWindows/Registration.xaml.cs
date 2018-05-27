using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project.OtherWindows
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        Project.BL.AddUserProfile addUser;
        public Registration()
        {
            InitializeComponent();
            Database.SetInitializer(new CreateDatabaseIfNotExists<DAL.Context>());
            addUser = new BL.AddUserProfile();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == "")
            {
                MessageBox.Show("Error", "Enter Login");
            }
            else if (tbPass.Text == "")
            {
                MessageBox.Show("Error", "Enter Password");
            }
            else if (tbName.Text == "")
            {
                MessageBox.Show("Error", "Enter Name");
            }
            else if (tbSurname.Text == "")
            {
                MessageBox.Show("Error", "Enter Surname");
            }
            else
            {
                if (addUser.AddUser(tbLogin.Text, tbPass.Text, tbName.Text, tbSurname.Text))
                {
                    MessageBox.Show("Success!", "User added!");
                }
                else
                {
                    MessageBox.Show("Error!", $"User with login \"{tbLogin.Text}\" already exists");
                }
            }
        }
    }
}
