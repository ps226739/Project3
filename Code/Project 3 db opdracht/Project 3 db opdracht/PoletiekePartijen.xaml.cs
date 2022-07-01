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
    /// Interaction logic for PoletiekePartijen.xaml
    /// </summary>
    public partial class PoletiekePartijen : Page
    {
        VerkiezingenDB db = new VerkiezingenDB();
        public PoletiekePartijen()
        {
            InitializeComponent();
            laadItems();
        }

        public void laadItems()
        {
            var data = db.krijgAlleItemsPartij();
            Partijen.ItemsSource = data;
        }
        
        private void MaakPartij_Click(object sender, RoutedEventArgs e)
        {
            if (db.NieuwePartij(tb_naam.Text, tb_adres.Text, tb_postcode.Text, tb_gemeente.Text, tb_emailadres.Text, tb_telefoonnummer.Text))
            {
                MessageBox.Show("gelukt!");
                laadItems();
            }
            else
            {
                MessageBox.Show("iets ging mis");
            }

            tb_naam.Text = string.Empty;
            tb_adres.Text = string.Empty;
            tb_postcode.Text = string.Empty;
            tb_gemeente.Text = string.Empty;
            tb_emailadres.Text = string.Empty;
            tb_telefoonnummer.Text = string.Empty;

        }

        private void DeletePartij_Click(object sender, RoutedEventArgs e)
        {
            var selected = Partijen.SelectedItem as DataRowView;
            int id = Convert.ToInt32(selected.Row.ItemArray[0]);

            if (db.verwijderPartij(id))
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
