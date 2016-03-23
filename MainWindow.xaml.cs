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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IO_LAB3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool isOpenMenu = false;
        bool isOpenDockPanel = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOpenMenu)
            {
                menuMenu.Visibility = Visibility.Collapsed;
                isOpenMenu = false;
            }
               
            else
            {
                menuMenu.Visibility = Visibility.Visible;
                isOpenMenu = true;
            }
        }

        private void ukryjButton_Click(object sender, RoutedEventArgs e)
        {
            if(isOpenDockPanel)
            {
                isOpenDockPanel = false;
                ListaAnkiet.Visibility = Visibility.Collapsed;
                //ukryjButton.FontFamily = new FontFamily("Segoe MDL2 Assets");
                //ukryjButton.Content = new ContentControl("&#59193;");
            }
            else
            {
                ListaAnkiet.Visibility = Visibility.Visible;
                isOpenDockPanel = true;
                //ukryjButton.Content = "&#59194;";
            }
                
        }

        private void WyjscieButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void PrzeslanieButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zainicjalizowano przesłanie danych!");
        }

        private void KontrolaButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kontrola komplementności ankiety!");
        }

        private void ZapisButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zapis ankiety!");
        }

        private void OdzczytButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Odczyt ankiety!");
        }

        private void PomocButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pomoc!");
        }

        private void InformacjeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Informacje o programie!");
        }
    }
}
