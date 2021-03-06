﻿using iTextSharp.text;
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
            var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.GRAY);
            var userCard = new PdfPTable(2);
            userCard.HorizontalAlignment = Element.ALIGN_LEFT;
            userCard.WidthPercentage = 50;
            PdfPCell cell = new PdfPCell(qrcode);
            cell.Rowspan = 6;
            userCard.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Chunk("Imie:", boldFont)));
            userCard.AddCell(cell);
            cell = new PdfPCell(new Phrase(name.Text));
            userCard.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Chunk("Nazwisko:", boldFont)));
            userCard.AddCell(cell);
            cell = new PdfPCell(new Phrase(surname.Text));
            userCard.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Chunk("Stanowisko:", boldFont)));
            userCard.AddCell(cell);
            cell = new PdfPCell(new Phrase(position.Text));
            userCard.AddCell(cell);


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
