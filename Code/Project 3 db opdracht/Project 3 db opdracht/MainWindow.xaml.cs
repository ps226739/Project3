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

namespace Project_3_db_opdracht
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PoletiekePartijen();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PoletiekeThema();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Standpunten();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Verkiezingsoort();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Verkiezingen();
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new VerkiezingPartijen();
        }
    }
}
