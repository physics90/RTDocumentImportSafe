using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.OIS.ARIALocal.WebServices.Document.Contracts;

namespace WinFormsUI.CustomClasses
{
    public class PatientDocument
    {
        public PatientIdentifier PatientId { get; set; }
        public string DateOfService { get; set; }
        public string DateEntered { get; set; }
        public string BinaryContent { get; set; }
        public DocumentUser AuthoredByUser { get; set; }
        public DocumentUser SupervisedByUser { get; set; }
        public DocumentUser EnteredByUser { get; set; }
        public FileFormat FileFormat { get; set; }
        public DocumentType DocumentType { get; set; }
        public string TemplateName { get; set; }


        public PatientDocument(string patientId, VMS.TPS.Common.Model.API.User user, FileData fileData)
        {
            PatientId = new PatientIdentifier { ID1 = patientId };
            DateOfService = $"/Date({Math.Floor((fileData.DateOfEvent - new DateTime(1970, 1, 1)).TotalMilliseconds)})/";
            DateEntered = $"/Date({Math.Floor((DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds)})/";
            BinaryContent = ConvertPDFToBinary(fileData.FullPath);
            FileFormat = FileFormat.PDF;

            AuthoredByUser = new DocumentUser
            {
                SingleUserId = user.Id
            };

            SupervisedByUser = new DocumentUser
            {
                SingleUserId = user.Id
            };

            EnteredByUser = new DocumentUser
            {
                SingleUserId = user.Id
            };

            TemplateName = fileData.TemplateName == null ? "" : fileData.TemplateName;
            DocumentType = new DocumentType { DocumentTypeDescription = fileData.SelectedDocumentTypeString() };
        }

        private string ConvertPDFToBinary(string filePath)
        {
            PdfDocument outputDocument = new PdfDocument();

            PdfDocument inputDocument = PdfReader.Open(filePath, PdfDocumentOpenMode.Import);
            for (int i = 0; i < inputDocument.PageCount; i++)
            {
                PdfPage page = inputDocument.Pages[i];
                outputDocument.AddPage(page);
            }

            MemoryStream stream = new MemoryStream();
            outputDocument.Save(stream, false);
            BinaryContent = Convert.ToBase64String(stream.ToArray());

            return BinaryContent;
        }
    }
}
