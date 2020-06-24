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
    /// Логика взаимодействия для AddNewOffer.xaml
    /// </summary>
    public partial class AddNewOffer : Window
    {
        public AddNewOffer()
        {
            InitializeComponent();
        }

        private void AddNewOfferBtn(object sender, RoutedEventArgs e)
        {
            Offer offer = new Offer();

            if (!(clientID.Text != "" && realtorID.Text != "" && price.Text != "" && realtyID.Text != ""))
            {
                MessageBox.Show("Все поля обязательны к заполнению");
                return;
            }
            offer.Insert(Convert.ToInt32(clientID.Text), Convert.ToInt32(realtorID.Text), Convert.ToInt32(realtyID.Text), Convert.ToDecimal(price.Text));

            Close();
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
    }
}
