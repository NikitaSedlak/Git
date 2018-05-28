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
using System.Windows.Shapes;
using Project.BL;
using DAL.Repositories;

namespace Project.OtherWindows
{
    /// <summary>
    /// Логика взаимодействия для CommonUser.xaml
    /// </summary>
    public partial class CommonUser : Window
    {
        GetFlights getFlights;
        public CommonUser()
        {
            InitializeComponent();
            SetComb();
            getFlights = new GetFlights();
        }

        private void SetComb()
        {
            CityRepository cityRepository = new CityRepository();
            foreach (var item in cityRepository.GetAll())
            {
                cmbDep.Items.Add(item.Name);
                cmbArr.Items.Add(item.Name);
            }
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listGrid.ItemsSource = getFlights.ReturnFlights(Convert.ToDateTime(datePicker.Text), cmbDep.Text, cmbArr.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
