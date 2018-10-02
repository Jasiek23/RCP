using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RCP
{
    class InOut
    {
        DataBaseConnection db = new DataBaseConnection();

        public void inMethod(string card, string date, string time)
        {
            string cardNo = card;
            string inDate = date;
            string inTime = time;

            string checkIn = "INSERT INTO card_check(card, in_date, in_time) VALUES('" + cardNo + "','" + inDate + "','" + inTime + "')";
            MySqlCommand command = new MySqlCommand(checkIn, db.connToDb);
            db.connToDb.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.connToDb.Close();

        }

        public void outMethod(string card, string date, string time)
        {
            string cardNo = card;
            string inDate = date;
            string outTime = time;

            string checkIn = "UPDATE card_check SET out_time = '" + outTime + "' WHERE card = '" + cardNo + "' AND in_date = '" + inDate + "'";
            MySqlCommand command = new MySqlCommand(checkIn, db.connToDb);
            db.connToDb.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.connToDb.Close();
        }
    }
}
