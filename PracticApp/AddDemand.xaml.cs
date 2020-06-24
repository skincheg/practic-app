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
using static PracticApp.RealtorsDataSet;

namespace PracticApp
{
    /// <summary>
    /// Логика взаимодействия для AddDemand.xaml
    /// </summary>
    public partial class AddDemand : Window
    {
        int demandID;
        string typeDemand;
        public AddDemand()
        {
            InitializeComponent();
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

            PracticApp.RealtorsDataSet realtorsDataSet = ((PracticApp.RealtorsDataSet)(this.FindResource("realtorsDataSet")));
            // Загрузить данные в таблицу Demand. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.DemandTableAdapter realtorsDataSetDemandTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.DemandTableAdapter();
            realtorsDataSetDemandTableAdapter.Fill(realtorsDataSet.Demand);
            System.Windows.Data.CollectionViewSource demandViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("demandViewSource")));
            demandViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Clients. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.ClientsTableAdapter realtorsDataSetClientsTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.ClientsTableAdapter();
            realtorsDataSetClientsTableAdapter.Fill(realtorsDataSet.Clients);
            System.Windows.Data.CollectionViewSource clientsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clientsViewSource")));
            clientsViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Realtors. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.RealtorsTableAdapter realtorsDataSetRealtorsTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.RealtorsTableAdapter();
            realtorsDataSetRealtorsTableAdapter.Fill(realtorsDataSet.Realtors);
            System.Windows.Data.CollectionViewSource realtorsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("realtorsViewSource")));
            realtorsViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу RealtyType. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.RealtyTypeTableAdapter realtorsDataSetRealtyTypeTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.RealtyTypeTableAdapter();
            realtorsDataSetRealtyTypeTableAdapter.Fill(realtorsDataSet.RealtyType);
            System.Windows.Data.CollectionViewSource realtyTypeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("realtyTypeViewSource")));
            realtyTypeViewSource.View.MoveCurrentToFirst();
        }

        private void demandDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                typeDemand = Convert.ToString(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[3]);
                demandID = Convert.ToInt32(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[0]);
                clientID.Text = Convert.ToString(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[1]);
                realtorID.Text = Convert.ToString(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[2]);
                type.Text = typeDemand;
                address.Text = Convert.ToString(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[4]);
                minPrice.Text = Convert.ToString(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[5]);
                maxPrice.Text = Convert.ToString(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[6]);

                switch (typeDemand)
                {
                    case "Квартира":
                        apartmentPanel.Width = 250;
                        housePanel.Width = 0;
                        landPanel.Width = 0;
                        Demand demand = new Demand("Apartment");
                        ApartmentFilterRow data = (ApartmentFilterRow)demand.GetDataByID(demandID);
                        apartmentMinFloor.Text = data.IsMinFloorNull() ? "" : Convert.ToString(data.MinFloor);
                        apartmentMaxFloor.Text = data.IsMaxFloorNull() ? "" : Convert.ToString(data.MaxFloor);
                        apartmentMinArea.Text = data.IsMinAreaNull() ? "" : Convert.ToString(data.MinArea);
                        apartmentMaxArea.Text = data.IsMaxAreaNull() ? "" : Convert.ToString(data.MaxArea);
                        apartmentMinRooms.Text = data.IsMinRoomsNull() ? "" : Convert.ToString(data.MinRooms);
                        apartmentMaxRooms.Text = data.IsMaxRoomsNull() ? "" : Convert.ToString(data.MaxRooms);
                        break;
                    case "Дом":
                        housePanel.Width = 250;
                        landPanel.Width = 0;
                        apartmentPanel.Width = 0;
                        Demand demandHouse = new Demand("House");
                        HouseFilterRow dataHouse = (HouseFilterRow)demandHouse.GetDataByID(demandID);
                        houseMinFloors.Text = dataHouse.IsMinFloorsNull() ? "" : Convert.ToString(dataHouse.MinFloors);
                        houseMaxFloors.Text = dataHouse.IsMaxFloorsNull() ? "" : Convert.ToString(dataHouse.MaxFloors);
                        houseMinArea.Text = dataHouse.IsMinAreaNull() ? "" : Convert.ToString(dataHouse.MinArea);
                        houseMaxArea.Text = dataHouse.IsMaxAreaNull() ? "" : Convert.ToString(dataHouse.MaxArea);
                        houseMinRooms.Text = dataHouse.IsMinRoomsNull() ? "" : Convert.ToString(dataHouse.MinRooms);
                        houseMaxRooms.Text = dataHouse.IsMaxRoomsNull() ? "" : Convert.ToString(dataHouse.MaxRooms);
                        break;
                    case "Земля":
                        landPanel.Width = 250;
                        housePanel.Width = 0;
                        apartmentPanel.Width = 0;
                        Demand landHouse = new Demand("Land");
                        LandFilterRow dataLand = (LandFilterRow)landHouse.GetDataByID(demandID);
                        landMinArea.Text = dataLand.IsMinAreaNull() ? "" : Convert.ToString(dataLand.MinArea);
                        landMaxArea.Text = dataLand.IsMaxAreaNull() ? "" : Convert.ToString(dataLand.MaxArea);
                        break;
                }

            }
            catch { }
        }

        private void SaveDataGridChanges(object sender, RoutedEventArgs e)
        {
            if (!(clientID.Text != "" && realtorID.Text != "" && type.Text != ""))
            {
                MessageBox.Show("Поля 'Клиент', 'Риэлтор', 'Тип недвижимости' обязательны к заполнению. ");
                return;
            }

            int clientId = Convert.ToInt32(clientID.Text);
            int realtorId = Convert.ToInt32(realtorID.Text);
            string Type = type.Text;
            string Address = String.IsNullOrEmpty(address.Text) ? "" : address.Text;
            int MinPrice = String.IsNullOrEmpty(minPrice.Text) ? 0 : Convert.ToInt32(minPrice.Text);
            int MaxPrice = String.IsNullOrEmpty(maxPrice.Text) ? 0 : Convert.ToInt32(maxPrice.Text);



            Demand demand = new Demand(typeDemand);

            switch (typeDemand)
            {
                case "Квартира":
                    demand.Update(clientId, realtorId, Type, Address, MinPrice, MaxPrice, demandID);

                    int apartmentMinFloorsU = String.IsNullOrEmpty(apartmentMinFloor.Text) ? 0 : Convert.ToInt32(apartmentMinFloor.Text);
                    int apartmentMaxFloorsU = String.IsNullOrEmpty(apartmentMaxFloor.Text) ? 0 : Convert.ToInt32(apartmentMaxFloor.Text);
                    decimal apartmentMinAreaU = String.IsNullOrEmpty(apartmentMinArea.Text) ? 0 : Convert.ToDecimal(apartmentMinArea.Text);
                    decimal apartmentMaxAreaU = String.IsNullOrEmpty(apartmentMaxArea.Text) ? 0 : Convert.ToDecimal(apartmentMaxArea.Text);
                    int apartmentMinRoomsU = String.IsNullOrEmpty(apartmentMinRooms.Text) ? 0 : Convert.ToInt32(apartmentMinRooms.Text);
                    int apartmentMaxRoomsU = String.IsNullOrEmpty(apartmentMaxRooms.Text) ? 0 : Convert.ToInt32(apartmentMaxRooms.Text);

                    demand.UpdateApartment(apartmentMinFloorsU, apartmentMaxFloorsU, apartmentMinAreaU, apartmentMaxAreaU, apartmentMinRoomsU, apartmentMaxRoomsU, demandID);
                    break;
                case "Дом":
                    demand.Update(clientId, realtorId, Type, Address, MinPrice, MaxPrice, demandID);

                    int houseMinFloorsU = String.IsNullOrEmpty(houseMinFloors.Text) ? 0 : Convert.ToInt32(houseMinFloors.Text);
                    int houseMaxFloorsU = String.IsNullOrEmpty(houseMaxFloors.Text) ? 0 : Convert.ToInt32(houseMaxFloors.Text);
                    decimal houseMinAreaU = String.IsNullOrEmpty(houseMinArea.Text) ? 0 : Convert.ToDecimal(houseMinArea.Text);
                    decimal houseMaxAreaU = String.IsNullOrEmpty(houseMaxArea.Text) ? 0 : Convert.ToDecimal(houseMaxArea.Text);
                    int houseMinRoomsU = String.IsNullOrEmpty(houseMinRooms.Text) ? 0 : Convert.ToInt32(houseMinRooms.Text);
                    int houseMaxRoomsU = String.IsNullOrEmpty(houseMaxRooms.Text) ? 0 : Convert.ToInt32(houseMaxRooms.Text);

                    demand.UpdateHouse(houseMinFloorsU, houseMaxFloorsU, houseMinAreaU, houseMaxAreaU, houseMinRoomsU, houseMaxRoomsU, demandID);
                    break;
                case "Земля":
                    demand.Update(clientId, realtorId, Type, Address, MinPrice, MaxPrice, demandID);

                    decimal landMinAreaU = String.IsNullOrEmpty(landMinArea.Text) ? 0 : Convert.ToDecimal(landMinArea.Text);
                    decimal landMaxAreaU = String.IsNullOrEmpty(landMaxArea.Text) ? 0 : Convert.ToDecimal(landMaxArea.Text);

                    demand.UpdateLand(landMinAreaU, landMaxAreaU, demandID);
                    break;
            }

            demandDataGrid.ItemsSource = demand.GetData();

            MessageBox.Show("Успешно");

        }

        private void AddDemandBtn(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteDemand(object sender, RoutedEventArgs e)
        {

        }
    }
}
