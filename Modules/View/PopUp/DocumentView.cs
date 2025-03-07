using ArchiveManagerApp.Model;
using ArchiveManagerApp.Tools;
using ArchiveManagerApp.Util;
using PdfiumViewer;
using System;
using System.Windows.Forms;

namespace ArchiveManagerApp.Modules.View.PopUp
{
    public partial class DocumentView: Form
    {
        public DocumentView(Archive archive)
        {
            InitializeComponent();
            OpenDocument(archive);
        }
        void OpenDocument(Archive archive)
        {
            byte[] fichier = archive.Document.Fichier;

            AddItemInListView(archive);

            switch (archive.Document.Extension)
            {
                case Model.Helper.Util.ExtensionType.PDF:
                    OpenPDF(fichier); break;
                case Model.Helper.Util.ExtensionType.IMAGE:
                    OpenPicture(fichier); break;
                case Model.Helper.Util.ExtensionType.DOC:
                    OpenDocument(fichier); break;
            }
        }

        void OpenPicture(byte[] fichier)
        {
            var picture = new PictureBox();
            //picture.Image = ArchiveDocumentConvert.ConvertByteToImage(fichier);
            picture.Image = Model.Helper.ImageUtil.ByteToBitmap(fichier);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Dock = DockStyle.Fill;

            pnlDocument.Controls.Clear();
            pnlDocument.Controls.Add(picture);
        }
        void OpenPDF(byte[] fichier)
        {
            var viewer = new PdfViewer();
            var doc = PdfDocument.Load(Functions.LoadPdfFromByteArray(fichier));
            viewer.Document = doc;
            // viewer.Document = ArchiveDocumentConvert.ConvertByteToPDF(fichier);
            viewer.Dock = DockStyle.Fill;

            pnlDocument.Controls.Clear();
            pnlDocument.Controls.Add(viewer);
        }
        void OpenDocument(byte[] fichier)
        {
            var txtBox = new TextBox();
            txtBox.Text = ArchiveDocumentConvert.ConvertWordToText(ArchiveDocumentConvert.ConvertByteToWord(fichier));
            txtBox.Multiline = true;
            txtBox.Dock = DockStyle.Fill;

            pnlDocument.Controls.Clear();
            pnlDocument.Controls.Add(txtBox);
        }

        void DrawListView()
        {
            //lstDetails.View = System.Windows.Forms.View.Details;
            //lstDetails.GridLines = true;
            //lstDetails.FullRowSelect = true;

            // pour fixer la taille dynamique de colonne
            var sizeColumn = lstDetails.Width - 150;

            lstDetails.Columns.Add("", 150);
            lstDetails.Columns.Add("", sizeColumn);
        }

        private void DocumentView_Load(object sender, EventArgs e)
        {
            DrawListView();
        }

        void AddItemInListView(Archive archive)
        {
            lstDetails.Items.Add(new ListViewItem(new string[] { "Libellé : ", archive.Document.Libelle }));
            lstDetails.Items.Add(new ListViewItem(new string[] { "Mot clé : ", archive.Document.MotCle }));
            lstDetails.Items.Add(new ListViewItem(new string[] { "Type Fichier : ", archive.Document.Extension.ToString() }));
            lstDetails.Items.Add(new ListViewItem(new string[] { "Taille : ",   Functions.GetSizeInMemory(archive.Document.Fichier.LongLength) }));
            lstDetails.Items.Add(new ListViewItem(new string[] { "Date Archivage : ", archive.Date.ToString("dd-MM-yyyy à HH:mm:ss") }));
        }

        private void btnExporter_Click(object sender, EventArgs e)
        {

        }
    }
}
