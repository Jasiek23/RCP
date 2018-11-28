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
    public partial class Form3 : Form, Sender
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void Send(string name, string surname, string position, string department, string card)
        {
            string n = name;
            string s = surname;
            string p = position;
            string d = department;
            string c = card;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectUsers select = new SelectUsers();
            select.selectUser(comboBox1.Text, textBox1.Text, textBox2.Text, dataGridView1);
            Edycja.Text = "Edytuj";
            Edycja.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PDFexport pdfExport = new PDFexport();
            pdfExport.exportToPdf(dataGridView1, "users");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            { 
                Send(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                Form4 form4 = new Form4();
                form4.ShowDialog();
            }
        }
    }
}
