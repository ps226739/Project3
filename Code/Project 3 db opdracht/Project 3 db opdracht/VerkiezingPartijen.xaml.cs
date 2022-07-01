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
    /// Interaction logic for VerkiezingPartijen.xaml
    /// </summary>
    public partial class VerkiezingPartijen : Page
    {
        VerkiezingenDB db = new VerkiezingenDB();
        public VerkiezingPartijen()
        {
            InitializeComponent();
            laadItems();
        }

        public void laadItems()
        {
            var data = db.krijgAlleItemsVerkiezingPartijen();
            verkiezingsPartijen.ItemsSource = data;
        }
    }
}
