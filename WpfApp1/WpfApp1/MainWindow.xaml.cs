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

namespace WpfApp1
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

        private void СТАТЬ_РАВШАНОМ_Click(object sender, RoutedEventArgs e)
        {
            Window1 secondWindow = new Window1();
            secondWindow.Show();
            this.Close(); // Закрывает главное окно
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Exit pukWindow = new Exit();
            pukWindow.Owner = this; // чтобы окно было поверх главного
            pukWindow.ShowDialog(); // ShowDialog - блокирует главное окно, пока не закроют
        }
    }
}

