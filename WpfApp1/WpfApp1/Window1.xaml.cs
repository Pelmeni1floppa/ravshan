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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private int cottonGrams = 0;
        private int money = 0;
        private int health = 100;
        private int energy = 100;
        public Window1()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {
            txtCotton.Text = cottonGrams.ToString();
            txtMoney.Content = money.ToString();
            txtHealth.Content = health.ToString();
            txtEnergy.Content = energy.ToString();
        }

        private void button_Копировать_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Collect_Click(object sender, RoutedEventArgs e)
        {
            if (energy <= 0)
            {
                MessageBox.Show("Нет энергии!");
                return;
            }

            if (health <= 0)
            {
                MessageBox.Show("Ты присмерте, олух!");
                return;
            }

            cottonGrams += 50;   // +10 грамм
            energy -= 5;          // -5 энергии
            health -= 1;          // -1 здоровье

            if (energy < 0) energy = 0;
            if (health < 0) health = 0;

            UpdateUI();
            CheckDeath();
        }

        private void sell_Click(object sender, RoutedEventArgs e)
        {
            if (cottonGrams < 1000)
            {
                MessageBox.Show("Нужно минимум 1 кг хлопка!");
                return;
            }

            int kgToSell = cottonGrams / 1000;
            int earnings = kgToSell * 5;  // 1 кг = 1 доллар

            cottonGrams -= kgToSell * 1000;
            money += earnings;

            UpdateUI();
            MessageBox.Show($"Продано {kgToSell} кг! +{earnings}$");
        }

        private void otdyhat_Click(object sender, RoutedEventArgs e)
        {
            energy += 25;
            health += 2;

            if (energy > 100) energy = 100;
            if (health > 100) health = 100;

            UpdateUI();
            MessageBox.Show("Отдохнул! Иди работай, сука");
        }

        private void magazin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("На обнове!");
        }

        private void dead_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Ты чё хочешь сдаться?",
                "Слабак ебаный",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Ты здох, лошок");
                this.Close();
            }
        }

        private void CheckDeath()
        {
            if (health <= 0)
            {
                MessageBox.Show("Ты здох!");
                this.Close();
            }
        }
    }
    
}
