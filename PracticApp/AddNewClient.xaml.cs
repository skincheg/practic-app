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
    public partial class AddNewClient : Window
    {
        public AddNewClient()
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
            string clientEmail = String.IsNullOrEmpty(Email.Text) ? "" : Email.Text;
            string clientPhone = String.IsNullOrEmpty(Phone.Text) ? "" : Phone.Text;
            if (clientEmail == "" && clientPhone == "")
            {
                errorLabel.Content = "Одно из полей Email или Телефон должны быть заполнены";
                return;
            }
            PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter realtorsDataSetPersonTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter();
            realtorsDataSetPersonTableAdapter.AddNewClient(clientName, clientSurname, clientPatronymic);
            var newPersonData = realtorsDataSetPersonTableAdapter.GetLastID();
            PracticApp.RealtorsDataSetTableAdapters.ClientsTableAdapter realtorsDataSetClientsTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.ClientsTableAdapter();
            realtorsDataSetClientsTableAdapter.AddNewClient(newPersonData.Last().ID, clientPhone, clientEmail);
            Close();
        }
    }
}
