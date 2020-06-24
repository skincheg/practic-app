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
    /// Логика взаимодействия для AddNewDeal.xaml
    /// </summary>
    public partial class AddNewDeal : Window
    {
        public AddNewDeal()
        {
            InitializeComponent();
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

        private void AddNewDealButton(object sender, RoutedEventArgs e)
        {
            new Deal().NewDeal(Convert.ToInt32(demandID.Text), Convert.ToInt32(offerID.Text));

            MessageBox.Show("Успешно");

            Close();
        }
    }
}
