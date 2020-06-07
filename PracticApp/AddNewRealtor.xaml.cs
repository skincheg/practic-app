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
    /// Логика взаимодействия для AddNewClient.xaml
    /// </summary>
    public partial class AddNewRealtor : Window
    {
        public AddNewRealtor()
        {

            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PracticApp.RealtorsDataSet realtorsDataSet = ((PracticApp.RealtorsDataSet)(this.FindResource("realtorsDataSet")));
            // Загрузить данные в таблицу Person. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter realtorsDataSetPersonTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter();
            realtorsDataSetPersonTableAdapter.Fill(realtorsDataSet.Person);
            System.Windows.Data.CollectionViewSource personViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("personViewSource")));
            personViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Clients. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.ClientsTableAdapter realtorsDataSetClientsTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.ClientsTableAdapter();
            realtorsDataSetClientsTableAdapter.Fill(realtorsDataSet.Clients);
            System.Windows.Data.CollectionViewSource personClientsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("personClientsViewSource")));
            personClientsViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Realtors. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.RealtorsTableAdapter realtorsDataSetRealtorsTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.RealtorsTableAdapter();
            realtorsDataSetRealtorsTableAdapter.Fill(realtorsDataSet.Realtors);
            System.Windows.Data.CollectionViewSource realtorsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("realtorsViewSource")));
            realtorsViewSource.View.MoveCurrentToFirst();
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

        private void AddNewClientButton(object sender, RoutedEventArgs e)
        {
            string clientName = String.IsNullOrEmpty(ClientName.Text) ? "" : ClientName.Text;
            string clientSurname = String.IsNullOrEmpty(ClientSurname.Text) ? "" : ClientSurname.Text;
            string clientPatronymic = String.IsNullOrEmpty(ClientPatronymic.Text) ? "" : ClientPatronymic.Text;
            int clientDeal;
            try
            {
                clientDeal = Convert.ToInt32(String.IsNullOrEmpty(Deal.Text) ? "" : Deal.Text);
            }
            catch
            {
                errorLabel.Content = "Ставка должна быть от 0 до 100.";
                return;
            }
            if (clientName == "" || clientSurname == "" || clientPatronymic == "")
            {
                errorLabel.Content = "Поля ФИО обязательны к заполнению.";
                return;
            } else if (Convert.ToInt32(clientDeal) > 100 || Convert.ToInt32(clientDeal) < 0)
            {
                errorLabel.Content = "Ставка должна быть от 0 до 100.";
                return;
            }
            PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter realtorsDataSetPersonTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter();
            realtorsDataSetPersonTableAdapter.AddNewClient(clientName, clientSurname, clientPatronymic, "Realtor");
            var newPersonData = realtorsDataSetPersonTableAdapter.GetLastID();
            PracticApp.RealtorsDataSetTableAdapters.RealtorsTableAdapter realtorsDataSetRealtorsTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.RealtorsTableAdapter();
            realtorsDataSetRealtorsTableAdapter.AddNewRealtor(newPersonData.Last().ID, Convert.ToInt32(clientDeal));
            Close();
        }
    }
}
