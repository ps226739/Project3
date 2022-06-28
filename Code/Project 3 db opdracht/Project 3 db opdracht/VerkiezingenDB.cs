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
    }
}
