﻿using System;
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
        DataBaseConnection dbConn = new DataBaseConnection();

        public void addUsers(string names, string surnames, string date, string positions, string dep)
        {
            string name = names;
            string surname = surnames;
            string dateOfBirth = date;
            string position = positions;
            string department = dep;

            string insterUser = "INSERT INTO user(name, surname, data, position, department) VALUES('" + name + "','" + surname + "','" + dateOfBirth+ "','" + position + "','" + department + "')";
            MySqlCommand command = new MySqlCommand(insterUser, dbConn.connToDb);
            dbConn.connToDb.Open();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Użytkownik został dodany");
             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbConn.connToDb.Close();
        }
    }
}
