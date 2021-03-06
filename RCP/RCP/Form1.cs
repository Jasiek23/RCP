﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using ZXing.Aztec;

namespace RCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Image)eventArgs.Frame.Clone();
        }

        private void MenuEndApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.ShowDialog();
        }

        private void polaczZBazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* DataBaseConnection connToDb = new DataBaseConnection();
            connToDb.dataBaseConn();*/
        }

        private void edytujUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            System.Threading.Thread.Sleep(4000);
            button2.Visible = true;
            button3.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            BarcodeReader QrReader = new BarcodeReader();
            Result result = QrReader.Decode((Bitmap)pictureBox1.Image);
            InOut userInOut = new InOut();

            try
            {
                string decode = result.ToString().Trim();
                if (decode != "")
                timer1.Stop();
                DateTime date = DateTime.UtcNow.ToLocalTime();
                string day = date.ToString("dd-MM-yy");
                string time = date.ToString("H:mm:ss");
                userInOut.inMethod(decode, day, time);
                MessageBox.Show("Witaj użytkowniku: " + decode, DateTime.Now.ToString());
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            BarcodeReader QrReader = new BarcodeReader();
            Result result = QrReader.Decode((Bitmap)pictureBox1.Image);
            InOut userInOut = new InOut();

            try
            {
                string decode = result.ToString().Trim();
                if (decode != "")
                    timer2.Stop();
                DateTime date = DateTime.UtcNow.ToLocalTime();
                string day = date.ToString("dd-MM-yy");
                string time = date.ToString("H:mm:ss");
                userInOut.outMethod(decode, day, time);
                MessageBox.Show("Uzytkowniku: " + decode + " Do zobaczeni jutro" , DateTime.Now.ToString());
            }
            catch
            {

            }
        }
    }
}
