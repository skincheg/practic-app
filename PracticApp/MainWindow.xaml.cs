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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void AddRealtor(object sender, RoutedEventArgs e)
        {
            Window addRealtor = new AddRealtor();
            Hide();
            addRealtor.ShowDialog();
            Show();
        }

        private void AddClient(object sender, RoutedEventArgs e)
        {
            Window addClient = new AddClient();
            Hide();
            addClient.ShowDialog();
            Show();
        }

        private void HideWindow(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
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

        private void AddRealty(object sender, RoutedEventArgs e)
        {
            Window addRealty = new AddRealty();
            Hide();
            addRealty.ShowDialog();
            Show();
        }

        private void AddOffer(object sender, RoutedEventArgs e)
        {
            Window AddOffer = new AddOffer();
            Hide();
            AddOffer.ShowDialog();
            Show();
        }

        private void AddDemand(object sender, RoutedEventArgs e)
        {
            Window AddDemand = new AddDemand();
            Hide();
            AddDemand.ShowDialog();
            Show();
        }

        private void AddDeal(object sender, RoutedEventArgs e)
        {
            Window AddDeal = new AddDeal();
            Hide();
            AddDeal.ShowDialog();
            Show();
        }
    }
}
