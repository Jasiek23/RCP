using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

namespace RCP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectUsers select = new SelectUsers();
            select.selectUser(comboBox1.Text, textBox1.Text, textBox2.Text, dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PDFexport pdfExport = new PDFexport();
            pdfExport.exportToPdf(dataGridView1, "users");
        }
    }
}
