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
                Form4 form4 = new Form4(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                form4.ShowDialog();
            }
        }
    }
}
