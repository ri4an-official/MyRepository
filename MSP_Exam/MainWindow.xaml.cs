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
using MyLibrary;

namespace MSP_Exam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Weather[] Weathers = new Weather[]
        {
            new Weather("Облачно",20.4),
            new Weather("Солнечно",30.1),
            new Weather("Холод",-15),
            new Weather("Осадки",-10.8),
            new Weather("Снег",-20.4),
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        readonly Random r = new Random();
        private void ShowWeather_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCity.Text))
            {
                MessageBox.Show("Введите город");
                return;
            }
            blockInfo.Text = Weathers[r.Next(Weathers.Length)].ToString();
        }
    }
}
