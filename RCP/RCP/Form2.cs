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
using System.Drawing.Imaging;

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
            string file = Application.ExecutablePath + "qr.jpg";
            Size s = pictureBox1.Size;
            Bitmap memoryImage = new Bitmap(s.Width, s.Height);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            Point ScreenPos = this.pictureBox1.PointToScreen(new Point(0, 0));
            memoryGraphics.CopyFromScreen(ScreenPos.X, ScreenPos.Y, 0, 0, s);
            memoryImage.Save(file);

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image = Image.FromFile(file);
            Image img = pictureBox1.Image;
            img.Save(ms, pictureBox1.Image.RawFormat);
            byte[] qr = ms.ToArray();


            try
            {
                AddUser addNewUser = new AddUser();
                addNewUser.addUsers(textBox1.Text, textBox2.Text, dateTimePicker1.Text, textBox3.Text, comboBox1.Text, qr, textBox4.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CardNumber randomCardNo = new CardNumber();
            textBox4.Text = randomCardNo.CardNumberRandom();
            Zen.Barcode.CodeQrBarcodeDraw userQRcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = userQRcode.Draw(textBox1.Text + " " + textBox2.Text,  200);
           
            AddUserButton.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CardGenerator generateUserCard = new CardGenerator();
            string file = Application.ExecutablePath + "qr.jpg";
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(file);
            image.ScaleToFit(120f, 120f);
            generateUserCard.GenerateCard(textBox1, textBox2, textBox3, image);
        }
    }
}
