using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCP
{
    public partial class Form4 : Form
    {
        public Form4(string data1, string data2, string data3, string data4, string data5)
        { 
            InitializeComponent();
            textBox1.Text = data1;
            textBox2.Text = data2;
            textBox3.Text = data3;
            textBox4.Text = data4;
            textBox5.Text = data5;
            label7.Text = data1 + " " + data2;
        }
    }
}
