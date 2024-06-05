using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.CustomClasses;
using WinFormsUI.Methods;
using V = VMS.TPS.Common.Model.API;

namespace WinFormsUI
{
    public partial class Main : Form
    {
        public bool IsInDevelopmentMode { get; set; }
        public V.User User { get; set; }
        public V.Application App { get; set; }

        private ObservableCollection<FileData> AllFiles = new ObservableCollection<FileData>();
        private List<FileData> FilesToPush = new List<FileData>();
        private V.Patient Patient;
        private int PDFToViewIndex;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            AllFiles_sfdatagrid.AutoGenerateColumns = false;
            AllFiles_sfdatagrid.DataSource = AllFiles;
            AllFiles_sfdatagrid.Style.CellStyle.Font.Size = 8;
            AllFiles_sfdatagrid.QueryCellStyle += SfDataGrid1_QueryCellStyle;
            AllFiles_sfdatagrid.ContextMenuOpening += AllFiles_sfdatagrid_ContextMenuOpening;
            AllFiles_sfdatagrid.RecordContextMenu = new ContextMenuStrip();
            AllFiles_sfdatagrid.RecordContextMenu.Items.Add("View PDF", null, OnViewPDFClicked);



            //Setup datagrid columns
            int checkBoxColumnSize = 50;
            this.AllFiles_sfdatagrid.Columns.Add(new GridTextColumn() { MappingName = "FileName", HeaderText = "File Name", Width = 300 });
            this.AllFiles_sfdatagrid.Columns.Add(new GridTextColumn() { MappingName = "TemplateName", HeaderText = "Template", Width = 200 });
            this.AllFiles_sfdatagrid.Columns.Add(new GridDateTimeColumn() { MappingName = "DateOfEvent", HeaderText = "Date", Width = 100 });
            this.AllFiles_sfdatagrid.Columns.Add(new GridCheckBoxColumn() { MappingName = "IsPathReport", HeaderText = "Path", Width = checkBoxColumnSize });
            this.AllFiles_sfdatagrid.Columns.Add(new GridCheckBoxColumn() { MappingName = "IsRadReport", HeaderText = "Rad", Width = checkBoxColumnSize });
            this.AllFiles_sfdatagrid.Columns.Add(new GridCheckBoxColumn() { MappingName = "IslabReport", HeaderText = "Lab", Width = checkBoxColumnSize });
            this.AllFiles_sfdatagrid.Columns.Add(new GridCheckBoxColumn() { MappingName = "IsDatabase", HeaderText = "Db", Width = checkBoxColumnSize });
            this.AllFiles_sfdatagrid.Columns.Add(new GridCheckBoxColumn() { MappingName = "IsConsultCard", HeaderText = "Cons", Width = checkBoxColumnSize });
            this.AllFiles_sfdatagrid.Columns.Add(new GridCheckBoxColumn() { MappingName = "IsNursing", HeaderText = "Nurse", Width = checkBoxColumnSize });
            this.AllFiles_sfdatagrid.Columns.Add(new GridCheckBoxColumn() { MappingName = "IsOther", HeaderText = "Other", Width = checkBoxColumnSize });

            AllFiles_sfdatagrid.Columns["TemplateName"].AllowEditing = true;
            AllFiles_sfdatagrid.Columns["DateOfEvent"].AllowEditing = true;
            AllFiles_sfdatagrid.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.DoubleClick;


        }

        private void AllFiles_sfdatagrid_ContextMenuOpening(object obj, ContextMenuOpeningEventArgs e)
        {
            if (e.ContextMenutype == ContextMenuType.Record)
            {
                PDFToViewIndex = e.RowIndex - 1;
            }
        }

        private void OnViewPDFClicked(object sender, EventArgs e)
        {
            string pdfLocation = AllFiles[PDFToViewIndex].FilePath + "\\" + AllFiles[PDFToViewIndex].FileName;

            //pdfViewerControl1.Load(pdfLocation);

            pdfDocumentView1.Load(pdfLocation);
            pdfDocumentView1.Focus();
        }

        

        private void SfDataGrid1_QueryCellStyle(object sender, QueryCellStyleEventArgs e)
        {
            if (e.Column.MappingName == "DateOfEvent")
            {
                e.Style.HorizontalAlignment = HorizontalAlignment.Center;
            }
        
        }

        private void SelectFolder_btn_Click(object sender, EventArgs e)
        {
            if (IsInDevelopmentMode)
            {
                if (Patient == null && !IsInDevelopmentMode)
                {
                    MessageBox.Show("Please select a patient first.", "No Patient selected", MessageBoxButtons.OK);
                    return;
                }
            }

            var result = folderBrowserDialog1.ShowDialog();

            if (result != DialogResult.OK) return;

            if (result == DialogResult.OK && folderBrowserDialog1.SelectedPath != "")
            {
                CollectFiles cf = new CollectFiles(folderBrowserDialog1.SelectedPath);
                AllFiles = new ObservableCollection<FileData>(cf.Execute());
            }

            if (AllFiles != null && AllFiles.Count() > 0)
            {
                AllFiles_sfdatagrid.DataSource = AllFiles;
            }
        }

        private void PushToAria_btn_Click(object sender, EventArgs e)
        {
            if (IsInDevelopmentMode) return;

            if (Patient == null)
            {
                MessageBox.Show("Please select a Patient", "Patient type Not Selected", MessageBoxButtons.OK);
                return;
            }

            FilesToPush = AllFiles.Where(f => f.HasDocumentTypeSelected() == true).ToList();

            SendToAria sa = new SendToAria(FilesToPush, Patient.Id, (string)SelectPhysician_cmbobox.SelectedItem, User);
            bool success = sa.Execute();

            if (success)
            {
                MessageBox.Show("Documents pushed to Aria successfully.", "Success", MessageBoxButtons.OK);
                //reset display and set sent files bool
                return;
            }
        }

        private void SearchForPatient_btn_Click(object sender, EventArgs e)
        {
            if (PatientID_txtbox.Text == "")
            {
                MessageBox.Show("Please enter a Patient ID to perform search.", "Enter Patient ID", MessageBoxButtons.OK);
                return;
            }

            try
            {
                Patient = App.OpenPatientById(PatientID_txtbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid Patient ID to perform search.", "Enter Patient ID", MessageBoxButtons.OK);
                return;
            }

            if (Patient == null)
            {
                MessageBox.Show("Could not find patient. Check Patient ID and perform search again.", "Search Error", MessageBoxButtons.OK);
                return;
            }

            PatientName_lbl.Text = $"{Patient.LastName}, {Patient.FirstName}, DOB: {Patient.DateOfBirth}";

            string radOncID = Patient.PrimaryOncologistId;
            string RadOnc;
            switch (radOncID)
            {
                case "one":
                    RadOnc = "Balfours";
                    break;
                case "two":
                    RadOnc = "Friedman";
                    break;
                case "three":
                    RadOnc = "Suggs";
                    break;
                case "four":
                    RadOnc = "Wadsworth";
                    break;
                default:
                    RadOnc = "Suggs"; 
                    break;
            }

            SelectPhysician_cmbobox.SelectedText = RadOnc;
            
        }
    }
}
