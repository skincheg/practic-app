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
    /// Логика взаимодействия для AddDeal.xaml
    /// </summary>
    public partial class AddDeal : Window
    {
        int dealID;
        public AddDeal()
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

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            new Deal().Update(Convert.ToInt32(demandID.Text), Convert.ToInt32(offerID.Text), dealID);
            dealDataGrid.ItemsSource = new Deal().GetData();
        }

        private void AddNewDeal(object sender, RoutedEventArgs e)
        {
            Window window = new AddNewDeal();
            window.ShowDialog();

            dealDataGrid.ItemsSource = new Deal().GetData();
        }

        private void DeleteDeal(object sender, RoutedEventArgs e)
        {
            new Deal().Delete(dealID);

            MessageBox.Show("Успешно");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PracticApp.RealtorsDataSet realtorsDataSet = ((PracticApp.RealtorsDataSet)(this.FindResource("realtorsDataSet")));
            // Загрузить данные в таблицу Deal. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.DealTableAdapter realtorsDataSetDealTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.DealTableAdapter();
            realtorsDataSetDealTableAdapter.Fill(realtorsDataSet.Deal);
            System.Windows.Data.CollectionViewSource dealViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("dealViewSource")));
            dealViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Clients. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.ClientsTableAdapter realtorsDataSetClientsTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.ClientsTableAdapter();
            realtorsDataSetClientsTableAdapter.Fill(realtorsDataSet.Clients);
            System.Windows.Data.CollectionViewSource clientsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clientsViewSource")));
            clientsViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Offer. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.OfferTableAdapter realtorsDataSetOfferTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.OfferTableAdapter();
            realtorsDataSetOfferTableAdapter.Fill(realtorsDataSet.Offer);
            System.Windows.Data.CollectionViewSource offerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("offerViewSource")));
            offerViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Demand. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.DemandTableAdapter realtorsDataSetDemandTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.DemandTableAdapter();
            realtorsDataSetDemandTableAdapter.Fill(realtorsDataSet.Demand);
            System.Windows.Data.CollectionViewSource demandViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("demandViewSource")));
            demandViewSource.View.MoveCurrentToFirst();

            dealDataGrid.ItemsSource = new Deal().GetData();

        }

        private void dealDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                int offerIDs = Convert.ToInt32(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[2]);
                dealID = Convert.ToInt32(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[0]);
                demandID.Text = Convert.ToString(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[1]);
                offerID.Text = Convert.ToString(offerIDs);


                var offerData = new Offer().GetDataByID(offerIDs);
                var realtyType = new Realty().TypeOfRealty(offerData.RealtyID);

                switch (realtyType)
                {
                    case "Apartment":
                        double commissionSells = 36000 + (Convert.ToDouble(offerData.Price) / 100);
                        double commissionBuys = (Convert.ToDouble(offerData.Price) / 100) * 3;
                        double commissionRealtors = (commissionSells + commissionBuys) * 0.45;
                        commissionSell.Content = Convert.ToString(commissionSells);
                        commissionBuy.Content = Convert.ToString(commissionBuys);
                        commissionRealtor.Content = Convert.ToString(commissionRealtors);
                        commissionCompany.Content = Convert.ToString(commissionSells + commissionBuys + commissionRealtors);
                        break;
                    case "House":
                        double commissionSellss = 30000 + (Convert.ToDouble(offerData.Price) / 100);
                        double commissionBuyss = (Convert.ToDouble(offerData.Price) / 100) * 3;
                        double commissionRealtorss = (commissionSellss + commissionBuyss) * 0.45;
                        commissionSell.Content = Convert.ToString(commissionSellss);
                        commissionBuy.Content = Convert.ToString(commissionBuyss);
                        commissionRealtor.Content = Convert.ToString(commissionRealtorss);
                        commissionCompany.Content = Convert.ToString(commissionSellss + commissionBuyss + commissionRealtorss);
                        break;
                    case "Land":
                        double commissionSellsss = 30000 + ((Convert.ToDouble(offerData.Price) / 100) * 2);
                        double commissionBuysss = (Convert.ToDouble(offerData.Price) / 100) * 3;
                        double commissionRealtorsss = (commissionSellsss + commissionBuysss) * 0.45;
                        commissionSell.Content = Convert.ToString(commissionSellsss);
                        commissionBuy.Content = Convert.ToString(commissionBuysss);
                        commissionRealtor.Content = Convert.ToString(commissionRealtorsss);
                        commissionCompany.Content = Convert.ToString(commissionSellsss + commissionBuysss + commissionRealtorsss);
                        break;
                }
            } catch
            {
            }

        }
    }
}
