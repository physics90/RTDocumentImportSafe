
using System;

namespace WinFormsUI.CustomClasses
{
    public class FileData
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string TemplateName { get; set; }
        public DateTime DateOfEvent { get; set; }
        public bool HasBeenSent { get; set; }
        public bool IsPathReport { get; set; } = false;
        public bool IsLabReport { get; set; } = false;
        public bool IsRadReport { get; set; } = false;
        public bool IsDatabase { get; set; } = false;
        public bool IsConsultCard { get; set; } = false;
        public bool IsNursing { get; set; } = false;
        public bool IsOther { get; set; } = false;
        public string FullPath 
        { 
            get { return FilePath + "\\" + FileName; } 
        }


        public bool HasDocumentTypeSelected()
        {
            bool hasDocTypeSelected = true;

            if (!IsPathReport && !IsLabReport && !IsRadReport && !IsDatabase && !IsConsultCard && !IsNursing && !IsOther)
            {
                hasDocTypeSelected = false;
            }

            return hasDocTypeSelected;
        }

        public string SelectedDocumentTypeString()
        {
            string documentTypeString = "";
            if (!HasDocumentTypeSelected())
            {
                return "None";
            }

            if (IsPathReport)
            {
                documentTypeString = "Pathology";
            }
            else if (IsRadReport)
            {
                documentTypeString = "Radiology Report";
            }
            else if (IsLabReport)
            {
                documentTypeString = "Lab Results";
            }
            else if (IsDatabase)
            {
                documentTypeString = "Database";
            }
            else if (IsConsultCard)
            {
                documentTypeString = "Consult Card";
            }
            else if (IsNursing)
            {
                documentTypeString = "Nursing";
            }
            else if (IsOther)
            {
                documentTypeString = "Other Procedure Report";
            }

            return documentTypeString;
        }

    }
}
