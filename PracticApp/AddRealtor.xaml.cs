﻿using System;
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
    /// Логика взаимодействия для AddRealtor.xaml
    /// </summary>
    public partial class AddRealtor : Window
    {
        public int clientID;
        public AddRealtor()
        {
            InitializeComponent();
        }


        public void Window_Loaded(object sender, RoutedEventArgs e)
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

            personDataGrid1.ItemsSource = realtorsDataSetPersonTableAdapter.InitializeRealtor();
            // Загрузить данные в таблицу Realtors. Можно изменить этот код как требуется.
            PracticApp.RealtorsDataSetTableAdapters.RealtorsTableAdapter realtorsDataSetRealtorsTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.RealtorsTableAdapter();
            realtorsDataSetRealtorsTableAdapter.Fill(realtorsDataSet.Realtors);
            System.Windows.Data.CollectionViewSource realtorsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("realtorsViewSource")));
            realtorsViewSource.View.MoveCurrentToFirst();
        }


        public static int LevenshteinDistance(string string1, string string2)
        {
            if (string1 == null) throw new ArgumentNullException("string1");
            if (string2 == null) throw new ArgumentNullException("string2");
            int diff;
            int[,] m = new int[string1.Length + 1, string2.Length + 1];

            for (int i = 0; i <= string1.Length; i++) { m[i, 0] = i; }
            for (int j = 0; j <= string2.Length; j++) { m[0, j] = j; }

            for (int i = 1; i <= string1.Length; i++)
            {
                for (int j = 1; j <= string2.Length; j++)
                {
                    diff = (string1[i - 1] == string2[j - 1]) ? 0 : 1;

                    m[i, j] = Math.Min(Math.Min(m[i - 1, j] + 1,
                                             m[i, j - 1] + 1),
                                             m[i - 1, j - 1] + diff);
                }
            }
            return m[string1.Length, string2.Length];
        }

        private void SaveDataGridChanges(object sender, RoutedEventArgs e)
        {
            string clientName = String.IsNullOrEmpty(ClientName.Text) ? "" : ClientName.Text;
            string clientSurname = String.IsNullOrEmpty(ClientSurname.Text) ? "" : ClientSurname.Text;
            string clientPatronymic = String.IsNullOrEmpty(ClientPatronymic.Text) ? "" : ClientPatronymic.Text;
            int clientDeal = Convert.ToInt32(String.IsNullOrEmpty(phoneTextBox.Text) ? "" : phoneTextBox.Text);
            if (clientDeal <= 100 || clientDeal >= 0)
            {
                new PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter().SaveChangesRealtor(clientName, clientSurname, clientPatronymic, clientID);
                new PracticApp.RealtorsDataSetTableAdapters.RealtorsTableAdapter().SaveChangesRealtors(Convert.ToInt32(clientDeal), clientID);
            } else
            {
                return;
            }

            PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter realtorsDataSetPersonTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter();
            personDataGrid1.ItemsSource = realtorsDataSetPersonTableAdapter.InitializeRealtor();

            MessageBox.Show("Данные сохранены");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var currentClient = new PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter().InitializeRealtor();
                int i = 0;
                while (i < currentClient.Rows.Count && currentClient.Rows.Count > 0)
                {

                    string dbName = String.IsNullOrEmpty(currentClient.Rows[i].ItemArray[1] as string) ? "" : currentClient.Rows[i].ItemArray[1] as string;
                    string dbSurname = String.IsNullOrEmpty(currentClient.Rows[i].ItemArray[2] as string) ? "" : currentClient.Rows[i].ItemArray[2] as string;
                    string dbPatronymic = String.IsNullOrEmpty(currentClient.Rows[i].ItemArray[3] as string) ? "" : currentClient.Rows[i].ItemArray[3] as string;



                    if (((LevenshteinDistance(dbName, searchTextBox.Text) >= 3) && (LevenshteinDistance(dbSurname, searchTextBox.Text) >= 3) && (LevenshteinDistance(dbPatronymic, searchTextBox.Text) >= 3)))
                    {
                        currentClient.Rows.Remove(currentClient.Rows[i]);

                        i = 0;
                    }
                    else
                    {
                        i++;
                    }

                }

                if (searchTextBox.Text == "")
                {
                    personDataGrid1.ItemsSource = new PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter().InitializeRealtor();
                }
                else
                {
                    personDataGrid1.ItemsSource = currentClient;
                }
            }
            catch
            {

            }

        }

        private void personDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                clientID = Convert.ToInt32(((System.Data.DataRowView)((object[])e.AddedItems)[0]).Row.ItemArray[0]);
                var currentClient = new PracticApp.RealtorsDataSetTableAdapters.RealtorsTableAdapter().InitializeTextBox(clientID);
                phoneTextBox.Text = Convert.ToString(currentClient.First().Deal);
                var currentClientCopy = new PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter().InitializeRealtorByID(currentClient.First().ID).First();
                string clientName = String.IsNullOrEmpty(currentClientCopy.Name) ? "" : currentClientCopy.Name;
                string clientSurname = String.IsNullOrEmpty(currentClientCopy.Surname) ? "" : currentClientCopy.Surname;
                string clientPatronymic = String.IsNullOrEmpty(currentClientCopy.Patronymic) ? "" : currentClientCopy.Patronymic;

                ClientName.Text = clientName;
                ClientSurname.Text = clientSurname;
                ClientPatronymic.Text = clientPatronymic;
            } catch { }

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

        private void AddNewClient(object sender, RoutedEventArgs e)
        {
            Window addNewClient = new AddNewRealtor();
            addNewClient.ShowDialog();

            PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter realtorsDataSetPersonTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter();
            personDataGrid1.ItemsSource = realtorsDataSetPersonTableAdapter.InitializeRealtor();
        }

        private void DeleteClient(object sender, RoutedEventArgs e)
        {
            new PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter().DeleteClient(clientID);
            PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter realtorsDataSetPersonTableAdapter = new PracticApp.RealtorsDataSetTableAdapters.PersonTableAdapter();
            personDataGrid1.ItemsSource = realtorsDataSetPersonTableAdapter.InitializeRealtor();


            MessageBox.Show("Риэлтор удалён");
        }
    }
}
