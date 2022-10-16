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

namespace korzina
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

        private void product_Click(object sender, RoutedEventArgs e)
        {
            prod11.Text = "Товар 1,стоимость : сумма n";

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            prod11.Text = "";
        }

        private void order_Click(object sender, RoutedEventArgs e)
        {
            if (text1.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели адрес");
            }
            else
            {
                MessageBox.Show("Ваш заказ принят в обработку");
            }
        }

        private void rooster_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("КО,КО,КО ТЫ ПЕТУХ");
        }
    }
}
