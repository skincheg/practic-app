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
    /// Логика взаимодействия для AddOffer.xaml
    /// </summary>
    public partial class AddOffer : Window
    {

        int offerID;
        public AddOffer()
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
            // Загрузить данные в таблицу Realtors. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.RealtorsTableAdapter realtorsDataSetRealtorsTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.RealtorsTableAdapter();
            realtorsDataSetRealtorsTableAdapter.Fill(realtorsDataSet.Realtors);
            System.Windows.Data.CollectionViewSource realtorsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("realtorsViewSource")));
            realtorsViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Realty. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.RealtyTableAdapter realtorsDataSetRealtyTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.RealtyTableAdapter();
            realtorsDataSetRealtyTableAdapter.Fill(realtorsDataSet.Realty);
            System.Windows.Data.CollectionViewSource realtyViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("realtyViewSource")));
            realtyViewSource.View.MoveCurrentToFirst();
        }

        private void AddOfferBtn(object sender, RoutedEventArgs e)
        {
            Window addNewOffer = new AddNewOffer();

            addNewOffer.ShowDialog();

            Offer offer = new Offer();

            offerDataGrid.ItemsSource = offer.GetData();

        }

        private void DeleteOffer(object sender, RoutedEventArgs e)
        {
            Offer offer = new Offer();

            offer.Delete(offerID);
            offerDataGrid.ItemsSource = offer.GetData();
        }

        private void SaveDataGridChanges(object sender, RoutedEventArgs e)
        {
            if (!(clientID.Text != "" && realtorID.Text != "" && price.Text != "" && realtyID.Text != ""))
            {
                MessageBox.Show("Все поля обязательны к заполнению");
                return;
            }

            Offer offer = new Offer();

            offer.Update(Convert.ToInt32(clientID.Text), Convert.ToInt32(realtorID.Text), Convert.ToInt32(realtyID.Text), Convert.ToDecimal(price.Text), offerID);
            offerDataGrid.ItemsSource = offer.GetData();

            MessageBox.Show("Успешно");

        }

        private void offerDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           try
            {
                offerID = Convert.ToInt32(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[0]);
                clientID.Text = Convert.ToString(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[1]);
                realtorID.Text = Convert.ToString(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[2]);
                realtyID.Text = Convert.ToString(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[3]);
                price.Text = Convert.ToString(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[4]);
            } catch { }
        }
    }
}
