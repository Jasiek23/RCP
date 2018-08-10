using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;

namespace RCP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] qr = ms.ToArray();

            try
            {
                AddUser addNewUser = new AddUser();
                addNewUser.addUsers(textBox1.Text, textBox2.Text, dateTimePicker1.Text, textBox3.Text, comboBox1.Text, qr);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw userQRcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = userQRcode.Draw(textBox1.Text, 200);
            AddUserButton.Visible = true;
        }
    }
}
