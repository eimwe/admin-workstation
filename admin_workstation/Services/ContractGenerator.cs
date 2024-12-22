using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Services
{
    public class ContractGenerator
    {
        private readonly string templateText = @"
            LANGUAGE CENTER CONTRACT

            This Contract (""Agreement"") is entered into on {3} by and between:
            Language Center: symBOL, hereinafter referred to as the ""Language Center.""
            Client: {0}, hereinafter referred to as the ""Client.""

            The Language Center agrees to provide the Client with English language courses.
            
            Responsibilities of the Language Center:
            - Provide qualified instructors for the agreed-upon courses.
            - Ensure the delivery of course materials and resources.
            - Notify the Client promptly of any schedule changes or cancellations.

            Responsibilities of the Client:
            - Attend classes as scheduled.
            - Inform the Language Center at least 24 hours in advance of any absence.
            - Adhere to the Language Center’s policies, including conduct and refund policies.

            Refund and Cancellation Policy:
            - Refunds are only available if the Client withdraws before the start of the course.
            - Cancellations by the Language Center will result in a full refund for missed classes.
            
            This Agreement may be terminated:
            - By mutual consent of both parties.
            - By either party providing 7 days written notice.
            - Immediately, if either party breaches the terms of this Agreement.

            Signatures:

            Language Center:                            Client:
            Name: admin                                    Name: {0}
            Position: Administrator                     Date of Birth: {1}
            Phone Number:                                Phone Number: {2}
            Signature:                                         Signature:
            Date: {3}                             Date: {3}
            ";

        public void GenerateContract(string fullName, string dateOfBirth, string phoneNumber)
        {
            // Configure save dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = $"Contract_{fullName}_{DateTime.Now:yyyyMMdd}"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        // Create PDF document
                        Document document = new Document(PageSize.A4, 50, 50, 50, 50);
                        PdfWriter writer = PdfWriter.GetInstance(document, fs);
                        document.Open();

                        // Format the template with client data and current date
                        string contractContent = string.Format(templateText,
                            fullName,
                            dateOfBirth,
                            phoneNumber,
                            DateTime.Now.ToShortDateString());

                        // Add content to document
                        Paragraph paragraph = new Paragraph(contractContent);
                        paragraph.Alignment = Element.ALIGN_LEFT;
                        document.Add(paragraph);

                        document.Close();
                    }

                    MessageBox.Show("Contract has been generated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error generating contract: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
