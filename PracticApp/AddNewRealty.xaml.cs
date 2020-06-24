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

namespace PracticApp
{
    /// <summary>
    /// Логика взаимодействия для AddNewRealty.xaml
    /// </summary>
    public partial class AddNewRealty : Window
    {
        public AddNewRealty()
        {
            InitializeComponent();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DragAndMoveWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void AddNewRealtyButton(object sender, RoutedEventArgs e)
        {
            string city = String.IsNullOrEmpty(cityTextBox.Text) ? "" : cityTextBox.Text;
            string street = String.IsNullOrEmpty(streetTextBox.Text) ? "" : streetTextBox.Text;
            string house = String.IsNullOrEmpty(houseTextBox.Text) ? "" : houseTextBox.Text;
            string flat = String.IsNullOrEmpty(flatTextBox.Text) ? "" : flatTextBox.Text;
            int latitude = String.IsNullOrEmpty(latitudeTextBox.Text) ? 0 : Convert.ToInt32(latitudeTextBox.Text);
            int longitude = String.IsNullOrEmpty(longitudeTextBox.Text) ? 0 : Convert.ToInt32(longitudeTextBox.Text);

            Realty realty = new Realty();

            if (!(latitude <= 90 && latitude >= -90 && longitude <= 180 && longitude >= -180))
            {
                MessageBox.Show("Широта может принимать значения от -90 до +90, долгота - от -180 до +180.");
                return;
            }


            if (!(apartmentRB.IsChecked.Value || houseRB.IsChecked.Value || landRB.IsChecked.Value))
            {
                MessageBox.Show("Не выбран тип недвижимости.");
                return;
            }

            realty.AddRealty(latitude, longitude);
            var realtyID = realty.GetLastRealty().ID;
            realty.AddAddress(city, street, house, flat, realtyID);

            if (apartmentRB.IsChecked.Value)
            {
                realty.AddTypeOfRealty(realtyID, "Apartment");
            }
            else if (houseRB.IsChecked.Value)
            {
                realty.AddTypeOfRealty(realtyID, "House");
            }
            else if (landRB.IsChecked.Value)
            {
                realty.AddTypeOfRealty(realtyID, "Land");
            }

            MessageBox.Show("Сохранено.");
            Close();

        }
    }
}
