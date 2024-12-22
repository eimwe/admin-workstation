using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Services
{
    public class TableExporter
    {
        public void ExportDataGridToPdf(DataGridView dataGrid, string title)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = $"{title.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd}"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 20f);
                        PdfWriter writer = PdfWriter.GetInstance(document, fs);

                        document.Open();

                        // Add title
                        Paragraph titleParagraph = new Paragraph(title)
                        {
                            Alignment = Element.ALIGN_CENTER,
                            SpacingAfter = 20f
                        };
                        document.Add(titleParagraph);

                        // Create the table with the same number of columns as the DataGridView
                        PdfPTable pdfTable = new PdfPTable(dataGrid.Columns.Count);
                        pdfTable.WidthPercentage = 100;

                        // Add headers
                        foreach (DataGridViewColumn column in dataGrid.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                            {
                                BackgroundColor = new BaseColor(240, 240, 240),
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                VerticalAlignment = Element.ALIGN_MIDDLE,
                                Padding = 5f
                            };
                            pdfTable.AddCell(cell);
                        }

                        // Add data rows
                        foreach (DataGridViewRow row in dataGrid.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string value = cell.Value?.ToString() ?? "";
                                PdfPCell pdfCell = new PdfPCell(new Phrase(value))
                                {
                                    HorizontalAlignment = Element.ALIGN_CENTER,
                                    VerticalAlignment = Element.ALIGN_MIDDLE,
                                    Padding = 4f
                                };
                                pdfTable.AddCell(pdfCell);
                            }
                        }

                        // Add table to document
                        document.Add(pdfTable);

                        // Add export date at the bottom
                        Paragraph footer = new Paragraph($"\nExported on: {DateTime.Now}")
                        {
                            Alignment = Element.ALIGN_RIGHT,
                            SpacingBefore = 10f
                        };
                        document.Add(footer);

                        document.Close();
                    }

                    MessageBox.Show("Data has been exported successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting data: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
