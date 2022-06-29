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
    /// Interaction logic for Standpunten.xaml
    /// </summary>
    public partial class Standpunten : Page
    {
        VerkiezingenDB db = new VerkiezingenDB();
        public Standpunten()
        {
            InitializeComponent();
            laadItems();
        }

        public void laadItems()
        {
            var data = db.krijgAlleItemsStandpunten();
            Standpunt.ItemsSource = data;
        }

    }
}
