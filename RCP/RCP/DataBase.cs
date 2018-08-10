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
       static string connectionString = "server=localhost; user=root; database=rcp; SslMode=none";


       public MySqlConnection connToDb = new MySqlConnection(connectionString);

    }
}
