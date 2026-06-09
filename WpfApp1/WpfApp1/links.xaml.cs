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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для links.xaml
    /// </summary>
    public partial class links : Window
    {
        public links()
        {
            InitializeComponent();
        }

        private void donat_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Нету :(");
        }

        private void telegram_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://t.me/topor_live_hvh",
                UseShellExecute = true
            });
        }

        private void boosty_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Нету :(");
        }
    }
}
