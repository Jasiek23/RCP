using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RCP
{
    class AddUser
    {
        static string connectionString = "server=localhost; user=root; database=rcp; SslMode=none";
        MySqlConnection connToDb = new MySqlConnection(connectionString);
        public void addUsers(string names, string surnames, string date, string positions, string dep)
        {
            string name = names;
            string surname = surnames;
            string dateOfBirth = date;
            string position = positions;
            string department = dep;

            string insterUser = "INSERT INTO rcp.user(name, surname, data, position, department) VALUES('" + name + "','" + surname + "','" + dateOfBirth + "','" + position + "'," + department + " )";
            connToDb.Open();
            MySqlCommand command = new MySqlCommand(insterUser, connToDb);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Użytkownik został dodany");
                }
                else

                {
                    MessageBox.Show("Wystąpił błąd podczas dodawanai użytkownika");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connToDb.Close();
        }
    }
}
