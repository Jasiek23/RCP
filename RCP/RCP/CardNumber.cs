using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCP
{
    class CardNumber
    {
        public string CardNumberRandom()
        {
            string  no;
            string checkCard;
            DataBaseConnection db = new DataBaseConnection();
            MySqlDataReader readData;
            do
            {
                System.Random x = new Random();
                no = x.Next(1, 10000).ToString();
                string dbRequest = "SELECT card FROM user WHERE card = '" + no + "'";
                MySqlCommand command = new MySqlCommand(dbRequest, db.connToDb);
                if (db.connToDb.State == System.Data.ConnectionState.Closed)
                {
                    db.connToDb.Open();
                }

                using (readData = command.ExecuteReader())
                {
                    if (readData.HasRows)
                    {
                        readData.Read();
                        checkCard = readData.GetString("card");
                    }
                    else
                    {
                        checkCard = "0";
                    }
                }
            }

            while (no == checkCard);

            db.connToDb.Close();

            return no;
        }
    }
}
