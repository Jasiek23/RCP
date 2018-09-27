using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCP
{
    class CardNumber
    {
        public string CardNumberRandom()
        {
            string no;
            string checkCard;
            DataBaseConnection db = new DataBaseConnection();
            do
            {
                System.Random x = new Random();
                no = x.Next(1, 10000).ToString();
                string dbRequest = "SELECT name FROM user WHERE card = '6323'";
                MySqlCommand command = new MySqlCommand(dbRequest, db.connToDb);
                db.connToDb.Open();
                MySqlDataReader readData = command.ExecuteReader();
                db.connToDb.Close();
                checkCard = readData.ToString();
            }
            while (no == checkCard);


            return no;
        }
    }
}
