using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RCP
{

    class SelectUsers
    {
        DataBaseConnection dbConn = new DataBaseConnection();
        
        public void selectUser(string depBox, string name, string surname, DataGridView dgvUsers)
        {
            string select = "SELECT name, surname, position FROM user WHERE department = '" + depBox +"' OR name = '" + name + "' OR surname = '" + surname + "'";
            MySqlCommand command = new MySqlCommand(select, dbConn.connToDb);
            dbConn.connToDb.Open();
            try
            {
                DataTable dt = new DataTable();
                MySqlDataReader readData = command.ExecuteReader();
                dt.Load(readData);

                if(dt.Rows.Count > 0)
                {
                    dgvUsers.DataSource = dt;
                }
                MessageBox.Show("Poprawnie pobrano użytkowników");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbConn.connToDb.Close();
        }
    }
}
