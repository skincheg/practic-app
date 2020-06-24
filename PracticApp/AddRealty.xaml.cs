using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для AddRealty.xaml
    /// </summary>
    public partial class AddRealty : Window
    {
        int realtyID;
        PracticApp.RealtorsDataSet realtorsDataSet;
        PracticApp.RealtorsDataSetTableAdapters.RealtyTableAdapter realtorsDataSetRealtyTableAdapter;
        System.Windows.Data.CollectionViewSource realtyViewSource;
        PracticApp.RealtorsDataSetTableAdapters.RealtyAddressesTableAdapter realtorsDataSetRealtyAddressesTableAdapter;
        System.Windows.Data.CollectionViewSource realtyRealtyAddressesViewSource;

        public AddRealty()
        {
            InitializeComponent();

            realtorsDataSet = ((PracticApp.RealtorsDataSet)(this.FindResource("realtorsDataSet")));
            // Загрузить данные в таблицу Realty. Можно изменить этот код как требуется.
            realtorsDataSetRealtyTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.RealtyTableAdapter();
            realtorsDataSetRealtyTableAdapter.Fill(realtorsDataSet.Realty);
            realtyViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("realtyViewSource")));
            realtyViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу RealtyAddresses. Можно изменить этот код как требуется.
            realtorsDataSetRealtyAddressesTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.RealtyAddressesTableAdapter();
            realtorsDataSetRealtyAddressesTableAdapter.Fill(realtorsDataSet.RealtyAddresses);
            realtyRealtyAddressesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("realtyRealtyAddressesViewSource")));
            realtyRealtyAddressesViewSource.View.MoveCurrentToFirst();

        }







        private void DragAndMoveWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void HideWindow(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void saveChanges(object sender, RoutedEventArgs e)
        {
            try
            {
                Realty currentRealty = new Realty();
                int latitude = Convert.ToInt32(latitudeTextBox.Text);
                int longitude = Convert.ToInt32(longitudeTextBox.Text);

                if (latitude <= 90 && latitude >= -90 && longitude <= 180 && longitude >= -180)
                {
                    currentRealty.UpdateFieldsRealty(latitude, longitude, realtyID);
                } else
                {
                    MessageBox.Show("Широта может принимать значения от -90 до +90, долгота - от -180 до +180.");
                    return;
                }

                string city = String.IsNullOrEmpty(cityTextBox.Text) ? "" : cityTextBox.Text;
                string street = String.IsNullOrEmpty(streetTextBox.Text) ? "" : streetTextBox.Text;
                string house = String.IsNullOrEmpty(houseTextBox.Text) ? "" : houseTextBox.Text;
                string flat = String.IsNullOrEmpty(flatTextBox.Text) ? "" : flatTextBox.Text;
                
                currentRealty.UpdateAddress(city, street, house, flat, realtyID);

                string typeRealty = currentRealty.TypeOfRealty(realtyID);

                switch (typeRealty)
                {
                    case "Apartment":
                        int floor = Convert.ToInt32(String.IsNullOrEmpty(apartmentFloor.Text) ? "" : apartmentFloor.Text);
                        int rooms = Convert.ToInt32(String.IsNullOrEmpty(apartmentRooms.Text) ? "" : apartmentRooms.Text);
                        decimal totalArea = Convert.ToDecimal(String.IsNullOrEmpty(apartmentArea.Text) ? "" : apartmentArea.Text);

                        currentRealty.UpdateApartment(floor, rooms, totalArea, realtyID);
                        break;
                    case "House":
                        int floors = Convert.ToInt32(String.IsNullOrEmpty(houseFloor.Text) ? "" : houseFloor.Text);
                        int houseRoom = Convert.ToInt32(String.IsNullOrEmpty(houseRooms.Text) ? "" : houseFloor.Text);
                        decimal houseTotalArea = Convert.ToDecimal(String.IsNullOrEmpty(houseArea.Text) ? "" : houseArea.Text);

                        currentRealty.UpdateHouse(floors, houseRoom, houseTotalArea, realtyID);
                        break;
                    case "Land":
                        decimal landTotalArea = Convert.ToDecimal(String.IsNullOrEmpty(landArea.Text) ? "" : landArea.Text);

                        currentRealty.UpdateLand(landTotalArea, realtyID);
                        break;
                }

                realtyAddressesDataGrid.ItemsSource = currentRealty.GetAllRealty();
                MessageBox.Show("Успешно сохранено");

            }
            catch
            {
                MessageBox.Show("Ошибка в сохранении, повторите позже.");
            }
        }

        private void realtyAddressesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                realtyID = Convert.ToInt32(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[0]);
                Realty currentRealty = new Realty();
                var currentRealtyData = currentRealty.GetCoordinatesByID(realtyID);
                latitudeTextBox.Text = currentRealtyData.IsCoordinateLatitudesNull() ? "" : Convert.ToString(currentRealtyData.CoordinateLatitudes);
                longitudeTextBox.Text = currentRealtyData.IsCoordinateLongitudesNull() ? "" : Convert.ToString(currentRealtyData.CoordinateLongitudes);
                var currentRealtyAddress = currentRealty.GetAddressByID(realtyID);
                cityTextBox.Text = currentRealtyAddress.IsCityNull() ? "" : currentRealtyAddress.City;
                streetTextBox.Text = currentRealtyAddress.IsStreetNull() ? "" : currentRealtyAddress.Street;
                houseTextBox.Text = currentRealtyAddress.IsHouseNull() ? "" : currentRealtyAddress.House;
                flatTextBox.Text = currentRealtyAddress.IsFlatNull() ? "" : currentRealtyAddress.Flat;

                string typeRealty = currentRealty.TypeOfRealty(realtyID);

                switch (typeRealty)
                {
                    case "Apartment":
                        apartmentPanel.Width = 210;
                        housePanel.Width = 0;
                        landPanel.Width = 0;
                        var currentApartmentData = currentRealty.GetApartmentByID(realtyID);
                        apartmentArea.Text = currentApartmentData.IsTotalAreaNull() ? "" : Convert.ToString(currentApartmentData.TotalArea);
                        apartmentFloor.Text = currentApartmentData.IsFloorNull() ? "" : Convert.ToString(currentApartmentData.Floor);
                        apartmentRooms.Text = currentApartmentData.IsRoomsNull() ? "" : Convert.ToString(currentApartmentData.Rooms);
                        break;
                    case "House":
                        apartmentPanel.Width = 0;
                        housePanel.Width = 210;
                        landPanel.Width = 0;
                        var currentHouseData = currentRealty.GetHouseByID(realtyID);
                        houseArea.Text = currentHouseData.IsTotalAreaNull() ? "" : Convert.ToString(currentHouseData.TotalArea);
                        houseFloor.Text = currentHouseData.IsFloorsNull() ? "" : Convert.ToString(currentHouseData.Floors);
                        houseRooms.Text = currentHouseData.IsRoomsNull() ? "" : Convert.ToString(currentHouseData.Rooms);
                        break;
                    case "Land":
                        apartmentPanel.Width = 0;
                        housePanel.Width = 0;
                        landPanel.Width = 210;
                        var currentLandData = currentRealty.GetLandByID(realtyID);
                        landArea.Text = currentLandData.IsTotalAreaNull() ? "" : Convert.ToString(currentLandData.TotalArea);
                        break;
                }
            } catch
            {

            }


        }

        private void RealtyTypeFilter(object sender, RoutedEventArgs e)
        {
            Realty realty = new Realty();

            if (apartmentRB.IsChecked.Value)
            {
                realtyAddressesDataGrid.ItemsSource = realty.GetAddressByRealtyType("Apartment");
            } 
            else if (houseRB.IsChecked.Value)
            {
                realtyAddressesDataGrid.ItemsSource = realty.GetAddressByRealtyType("House");
            }
            else if (landRB.IsChecked.Value)
            {
                realtyAddressesDataGrid.ItemsSource = realty.GetAddressByRealtyType("Land");
            }
        }

        private void deleteRealty(object sender, RoutedEventArgs e)
        {
            Realty realty = new Realty();

            realty.DeleteRealty(realtyID);

            realtyAddressesDataGrid.ItemsSource = realty.GetAllRealty();
            MessageBox.Show("Успешно.");

        }

        private void addRealty(object sender, RoutedEventArgs e)
        {
            AddNewRealty newRealty = new AddNewRealty();
            newRealty.ShowDialog();

            Realty realty = new Realty();
            realtyAddressesDataGrid.ItemsSource = realty.GetAllRealty();

        }
    }
}
