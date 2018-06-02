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
    /// Логика взаимодействия для Floght.xaml
    /// </summary>
    public partial class Flight : Window
    {
        AddFlights addFlights;
        private void SetCMB()
        {
            CityRepository cityRepository = new CityRepository();
            AircraftRepository aircraftRepository = new AircraftRepository();

            foreach (var item in cityRepository.GetAll())
            {
                cmbAcity.Items.Add(item.Name);
                cmbDcity.Items.Add(item.Name);
            }

            foreach (var item in aircraftRepository.GetAll())
            {
                cmbAir.Items.Add(item.Name);
            }
        }
        public Flight()
        {
            addFlights = new AddFlights();
            InitializeComponent();
            SetCMB();
        }

        private void btnAddFligth_Click(object sender, RoutedEventArgs e)
        {
            //if (addFlights.AddNewFlight(cmbAir.Text, Convert.ToDateTime(pcrAdate.Text), Convert.ToDateTime(pcrDdate.Text), cmbAcity.Text, cmbDcity.Text))
            //{
            //    MessageBox.Show("Flight added!","Success");
            //}
            //else
            //{
            //    MessageBox.Show("error", "Error!");
            //}

            string s = addFlights.Test(cmbAir.Text, Convert.ToDateTime(pcrAdate.Text), Convert.ToDateTime(pcrDdate.Text), cmbAcity.Text, cmbDcity.Text);

            MessageBox.Show(s);
        }
    }
}
