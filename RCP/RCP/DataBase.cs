using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace RCP
{
    class DataBaseConnection
    {
        public string connectionString = "server=localhost; user=root; database=rcp; SslMode=none";

        public void dataBaseConn()
        {
            MySqlConnection connToDb = new MySqlConnection(connectionString);
            try
            {
                connToDb.Open();
                MessageBox.Show("Połączono z bazą danych");
            }
            catch
            {
                MessageBox.Show("Błąd połączenia z bazą danych");
            }
        }
    }
}
