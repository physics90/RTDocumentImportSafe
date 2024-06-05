
namespace WinFormsUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings2 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings2 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings2 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetPhysician_btn = new System.Windows.Forms.Button();
            this.SelectPhysician_cmbobox = new System.Windows.Forms.ComboBox();
            this.PatientName_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchForPatient_btn = new System.Windows.Forms.Button();
            this.PatientID_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectFolder_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PushToAria_btn = new System.Windows.Forms.Button();
            this.PDFViewer_grpbox = new System.Windows.Forms.GroupBox();
            this.pdfDocumentView1 = new Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.AllFiles_sfdatagrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PDFViewer_grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllFiles_sfdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SetPhysician_btn);
            this.groupBox1.Controls.Add(this.SelectPhysician_cmbobox);
            this.groupBox1.Controls.Add(this.PatientName_lbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SearchForPatient_btn);
            this.groupBox1.Controls.Add(this.PatientID_txtbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // SetPhysician_btn
            // 
            this.SetPhysician_btn.Location = new System.Drawing.Point(254, 88);
            this.SetPhysician_btn.Name = "SetPhysician_btn";
            this.SetPhysician_btn.Size = new System.Drawing.Size(75, 23);
            this.SetPhysician_btn.TabIndex = 7;
            this.SetPhysician_btn.Text = "Set";
            this.SetPhysician_btn.UseVisualStyleBackColor = true;
            // 
            // SelectPhysician_cmbobox
            // 
            this.SelectPhysician_cmbobox.FormattingEnabled = true;
            this.SelectPhysician_cmbobox.Items.AddRange(new object[] {
            "Balfour",
            "Friedman",
            "Suggs",
            "Wadsworth"});
            this.SelectPhysician_cmbobox.Location = new System.Drawing.Point(105, 89);
            this.SelectPhysician_cmbobox.Name = "SelectPhysician_cmbobox";
            this.SelectPhysician_cmbobox.Size = new System.Drawing.Size(142, 21);
            this.SelectPhysician_cmbobox.TabIndex = 6;
            // 
            // PatientName_lbl
            // 
            this.PatientName_lbl.AutoSize = true;
            this.PatientName_lbl.Location = new System.Drawing.Point(105, 62);
            this.PatientName_lbl.Name = "PatientName_lbl";
            this.PatientName_lbl.Size = new System.Drawing.Size(73, 13);
            this.PatientName_lbl.TabIndex = 5;
            this.PatientName_lbl.Text = "Select Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Physician:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient:";
            // 
            // SearchForPatient_btn
            // 
            this.SearchForPatient_btn.Location = new System.Drawing.Point(252, 24);
            this.SearchForPatient_btn.Name = "SearchForPatient_btn";
            this.SearchForPatient_btn.Size = new System.Drawing.Size(75, 23);
            this.SearchForPatient_btn.TabIndex = 2;
            this.SearchForPatient_btn.Text = "Search";
            this.SearchForPatient_btn.UseVisualStyleBackColor = true;
            this.SearchForPatient_btn.Click += new System.EventHandler(this.SearchForPatient_btn_Click);
            // 
            // PatientID_txtbox
            // 
            this.PatientID_txtbox.Location = new System.Drawing.Point(105, 25);
            this.PatientID_txtbox.Name = "PatientID_txtbox";
            this.PatientID_txtbox.Size = new System.Drawing.Size(142, 20);
            this.PatientID_txtbox.TabIndex = 1;
            this.PatientID_txtbox.Text = "zzz001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Patient ID:";
            // 
            // SelectFolder_btn
            // 
            this.SelectFolder_btn.Location = new System.Drawing.Point(18, 19);
            this.SelectFolder_btn.Name = "SelectFolder_btn";
            this.SelectFolder_btn.Size = new System.Drawing.Size(157, 35);
            this.SelectFolder_btn.TabIndex = 1;
            this.SelectFolder_btn.Text = "Select Files Folder";
            this.SelectFolder_btn.UseVisualStyleBackColor = true;
            this.SelectFolder_btn.Click += new System.EventHandler(this.SelectFolder_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectFolder_btn);
            this.groupBox2.Controls.Add(this.PushToAria_btn);
            this.groupBox2.Location = new System.Drawing.Point(369, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 128);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // PushToAria_btn
            // 
            this.PushToAria_btn.Location = new System.Drawing.Point(18, 78);
            this.PushToAria_btn.Name = "PushToAria_btn";
            this.PushToAria_btn.Size = new System.Drawing.Size(157, 35);
            this.PushToAria_btn.TabIndex = 6;
            this.PushToAria_btn.Text = "Push To Aria";
            this.PushToAria_btn.UseVisualStyleBackColor = true;
            this.PushToAria_btn.Click += new System.EventHandler(this.PushToAria_btn_Click);
            // 
            // PDFViewer_grpbox
            // 
            this.PDFViewer_grpbox.Controls.Add(this.pdfDocumentView1);
            this.PDFViewer_grpbox.Location = new System.Drawing.Point(1069, 14);
            this.PDFViewer_grpbox.Name = "PDFViewer_grpbox";
            this.PDFViewer_grpbox.Size = new System.Drawing.Size(481, 707);
            this.PDFViewer_grpbox.TabIndex = 7;
            this.PDFViewer_grpbox.TabStop = false;
            this.PDFViewer_grpbox.Text = "PDF Viewer";
            // 
            // pdfDocumentView1
            // 
            this.pdfDocumentView1.AutoScroll = true;
            this.pdfDocumentView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.pdfDocumentView1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            this.pdfDocumentView1.EnableContextMenu = true;
            this.pdfDocumentView1.HorizontalScrollOffset = 0;
            this.pdfDocumentView1.IsTextSearchEnabled = true;
            this.pdfDocumentView1.IsTextSelectionEnabled = true;
            this.pdfDocumentView1.Location = new System.Drawing.Point(6, 17);
            messageBoxSettings2.EnableNotification = true;
            this.pdfDocumentView1.MessageBoxSettings = messageBoxSettings2;
            this.pdfDocumentView1.MinimumZoomPercentage = 50;
            this.pdfDocumentView1.Name = "pdfDocumentView1";
            this.pdfDocumentView1.PageBorderThickness = 1;
            pdfViewerPrinterSettings2.Copies = 1;
            pdfViewerPrinterSettings2.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings2.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings2.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings2.PrintLocation")));
            pdfViewerPrinterSettings2.ShowPrintStatusDialog = true;
            this.pdfDocumentView1.PrinterSettings = pdfViewerPrinterSettings2;
            this.pdfDocumentView1.ReferencePath = null;
            this.pdfDocumentView1.ScrollDisplacementValue = 0;
            this.pdfDocumentView1.ShowHorizontalScrollBar = true;
            this.pdfDocumentView1.ShowVerticalScrollBar = true;
            this.pdfDocumentView1.Size = new System.Drawing.Size(469, 682);
            this.pdfDocumentView1.SpaceBetweenPages = 8;
            this.pdfDocumentView1.TabIndex = 0;
            textSearchSettings2.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings2.HighlightAllInstance = true;
            textSearchSettings2.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pdfDocumentView1.TextSearchSettings = textSearchSettings2;
            this.pdfDocumentView1.ThemeName = "Default";
            this.pdfDocumentView1.VerticalScrollOffset = 0;
            this.pdfDocumentView1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            this.pdfDocumentView1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // AllFiles_sfdatagrid
            // 
            this.AllFiles_sfdatagrid.AccessibleName = "Table";
            this.AllFiles_sfdatagrid.Font = new System.Drawing.Font("Monotype Corsiva", 3.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllFiles_sfdatagrid.Location = new System.Drawing.Point(12, 188);
            this.AllFiles_sfdatagrid.Name = "AllFiles_sfdatagrid";
            this.AllFiles_sfdatagrid.Size = new System.Drawing.Size(1030, 533);
            this.AllFiles_sfdatagrid.TabIndex = 9;
            this.AllFiles_sfdatagrid.Text = "sfDataGrid1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Files List";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 733);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AllFiles_sfdatagrid);
            this.Controls.Add(this.PDFViewer_grpbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Viewer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.PDFViewer_grpbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllFiles_sfdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SelectPhysician_cmbobox;
        private System.Windows.Forms.Label PatientName_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchForPatient_btn;
        private System.Windows.Forms.TextBox PatientID_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SetPhysician_btn;
        private System.Windows.Forms.Button SelectFolder_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PushToAria_btn;
        private System.Windows.Forms.GroupBox PDFViewer_grpbox;
        private Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView pdfDocumentView1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid AllFiles_sfdatagrid;
        private System.Windows.Forms.Label label4;
    }
}

