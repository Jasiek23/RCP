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

namespace RCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
