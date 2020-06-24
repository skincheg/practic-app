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
    /// Логика взаимодействия для AddNewDemand.xaml
    /// </summary>
    public partial class AddNewDemand : Window
    {
        public AddNewDemand()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PracticApp.RealtorsDataSet realtorsDataSet = ((PracticApp.RealtorsDataSet)(this.FindResource("realtorsDataSet")));
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Успешно.");
            Close();
        }
    }
}
