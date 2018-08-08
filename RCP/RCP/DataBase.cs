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
    class DataBase
    {
        string connectionString = "Server=; Database=espercon_test; Uid=espercon_admin; Pwd=Root1234;";
        public void dataBaseConnection()
        {
            MySqlConnection connToDb = new MySqlConnection(connectionString);
            try
            {
                connToDb.Open();
                MessageBox.Show("Połączono z bazą danych");
                connToDb.Close();
            }
            catch
            {
                MessageBox.Show("Błąd połączenia z bazą danych");
            }
        }

    }
}
