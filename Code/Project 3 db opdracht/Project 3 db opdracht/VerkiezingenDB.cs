using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_3_db_opdracht
{
    class VerkiezingenDB
    {
        private MySqlConnection _connection = new MySqlConnection("Server=localhost;Database=verkiezingenprj3;Uid=root;");

        //Read 1
        public DataView krijgAlleItemsPartij()
        {
            _connection.Open();
            DataTable uitslag = new DataTable();
            try
            {
                MySqlCommand command = _connection.CreateCommand();

                command.CommandText = "SELECT * FROM partij";

                MySqlDataReader reader = command.ExecuteReader();

                uitslag.Load(reader);
            }
            catch (Exception)
            {

            }
            finally
            {
                _connection.Close();
            }

            return uitslag.DefaultView;
        }
        //Read 2
        public DataView krijgAlleItemsThema()
        {
            _connection.Open();
            DataTable uitslag = new DataTable();
            try
            {
                MySqlCommand command = _connection.CreateCommand();

                command.CommandText = "SELECT * FROM thema";

                MySqlDataReader reader = command.ExecuteReader();

                uitslag.Load(reader);
            }
            catch (Exception)
            {

            }
            finally
            {
                _connection.Close();
            }

            return uitslag.DefaultView;
        }
        //Read 3
        public DataView krijgAlleItemsStandpunten()
        {
            _connection.Open();
            DataTable uitslag = new DataTable();
            try
            {
                MySqlCommand command = _connection.CreateCommand();

                command.CommandText = "SELECT * FROM standpunt";

                MySqlDataReader reader = command.ExecuteReader();

                uitslag.Load(reader);
            }
            catch (Exception)
            {

            }
            finally
            {
                _connection.Close();
            }

            return uitslag.DefaultView;
        }
        //Read 4
        public DataView krijgAlleItemsVerkiezingsoorten()
        {
            _connection.Open();
            DataTable uitslag = new DataTable();
            try
            {
                MySqlCommand command = _connection.CreateCommand();

                command.CommandText = "SELECT * FROM verkiezingsoort";

                MySqlDataReader reader = command.ExecuteReader();

                uitslag.Load(reader);
            }
            catch (Exception)
            {

            }
            finally
            {
                _connection.Close();
            }

            return uitslag.DefaultView;
        }
        //Read 5
        public DataView krijgAlleItemsVerkiezing()
        {
            _connection.Open();
            DataTable uitslag = new DataTable();
            try
            {
                MySqlCommand command = _connection.CreateCommand();

                command.CommandText = "SELECT * FROM verkiezing";

                MySqlDataReader reader = command.ExecuteReader();

                uitslag.Load(reader);
            }
            catch (Exception)
            {

            }
            finally
            {
                _connection.Close();
            }

            return uitslag.DefaultView;
        }
        //read 6
        public DataView krijgAlleItemsVerkiezingPartijen()
        {
            _connection.Open();
            DataTable uitslag = new DataTable();
            try
            {
                MySqlCommand command = _connection.CreateCommand();

                command.CommandText = "SELECT * FROM partij_verkiezing";
                MySqlDataReader reader = command.ExecuteReader();

                uitslag.Load(reader);
            }
            catch (Exception)
            {

            }
            finally
            {
                _connection.Close();
            }

            return uitslag.DefaultView;
        }
        //nieuw 1
        public bool NieuwePartij(string naam, string adres, string postcode, string gemeente, string emailadres, string telefoonnummer)
        {
            _connection.Open();

            try
            {
                MySqlCommand cmd = _connection.CreateCommand();
                cmd.CommandText = "INSERT INTO partij (naam, adres, postcode, gemeente, emailadres, telefoonnummer) VALUES (@naam, @adres, @postcode, @gemeente, @emailadres, @telefoonnummer)";

                cmd.Parameters.AddWithValue("@naam", naam);
                cmd.Parameters.AddWithValue("@adres", adres);
                cmd.Parameters.AddWithValue("@postcode", postcode);
                cmd.Parameters.AddWithValue("@gemeente", gemeente);
                cmd.Parameters.AddWithValue("@emailadres", emailadres);
                cmd.Parameters.AddWithValue("@telefoonnummer", telefoonnummer);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }
        //nieuw 2
        public bool NieuweThema(string thema)
        {
            _connection.Open();

            try
            {
                MySqlCommand cmd = _connection.CreateCommand();
                cmd.CommandText = "INSERT INTO thema (thema) VALUES (@thema)";

                cmd.Parameters.AddWithValue("@thema", thema);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }
        //delete 1
        public bool verwijderPartij(int partij_id)
        {
            _connection.Open();
            try
            {
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM partij WHERE partij_id = @partij_id";

                command.Parameters.AddWithValue("@partij_id", partij_id);

                command.ExecuteNonQuery();


                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                _connection.Close();
            }
        }
        //delete 2
        public bool verwijderThema(int thema_id)
        {
            _connection.Open();
            try
            {
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM thema WHERE thema_id = @thema_id";

                command.Parameters.AddWithValue("@thema_id", thema_id);

                command.ExecuteNonQuery();


                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
