using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for PoletiekeThema.xaml
    /// </summary>
    public partial class PoletiekeThema : Page
    {
        VerkiezingenDB db = new VerkiezingenDB();
        public PoletiekeThema()
        {
            InitializeComponent();
            laadItems();
        }

        public void laadItems()
        {
            var data = db.krijgAlleItemsThema();
            Thema.ItemsSource = data;
        }

        private void MaakThema_Click(object sender, RoutedEventArgs e)
        {
            if (db.NieuweThema(tb_thema.Text))
            {
                MessageBox.Show("gelukt!");
                laadItems();
            }
            else
            {
                MessageBox.Show("iets ging mis");
            }

            tb_thema.Text = string.Empty;
        }
        private void DeleteThema_Click(object sender, RoutedEventArgs e)
        {
            var selected = Thema.SelectedItem as DataRowView;
            int id = Convert.ToInt32(selected.Row.ItemArray[0]);

            if (db.verwijderThema(id))
            {
                MessageBox.Show("deleted item");
                laadItems();
            }
            else
            {
                MessageBox.Show("");
            }
        }

    }
}
