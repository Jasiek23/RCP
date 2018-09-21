using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCP
{
    class CardGenerator
    {
        public void GenerateCard(TextBox name, TextBox surname, TextBox position, Image qrcode)
        {
            var pdfDoc = new Document(PageSize.A4, 40f, 40f, 60f, 60f);

            var userCard = new PdfPTable(new[] { .75f, 2f})
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                WidthPercentage = 50,
                DefaultCell = { MinimumHeight = 22f }
            };

            userCard.AddCell("Imie:");
            userCard.AddCell(name.Text);
            userCard.AddCell("Nazwisko:");
            userCard.AddCell(surname.Text);
            userCard.AddCell("Stanowisko:");
            userCard.AddCell(position.Text);
            userCard.AddCell("Kod:");
            userCard.AddCell(new PdfPCell(qrcode));

            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".pdf";
            save.FileName = name.Text +"_"+surname.Text + " - card";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(userCard);
                    pdfDoc.Close();
                    stream.Close();
                }
            }

        }
    }
}
