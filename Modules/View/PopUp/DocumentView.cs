using ArchiveManagerApp.Model;
using ArchiveManagerApp.Tools;
using ArchiveManagerApp.Util;
using DocumentFormat.OpenXml.Packaging;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveManagerApp.Modules.View.PopUp
{
    public partial class DocumentView: Form
    {
        public DocumentView(Archive archive = null)
        {
            InitializeComponent();
            if (archive != null)
            {
                OpenDocument(archive);
            }
        }
        void OpenDocument(Archive archive)
        {
            lstDetails.Items.Add(new ListViewItem("Libellé : ", archive.Document.Libelle));
            lstDetails.Items.Add(new ListViewItem("Mot clé : ", archive.Document.MotCle));
            lstDetails.Items.Add(new ListViewItem("Type Fichier : ", archive.Document.Extension.ToString()));
            lstDetails.Items.Add(new ListViewItem("Type : ", archive.Document.Extension.ToString()));
            lstDetails.Items.Add(new ListViewItem("Date Archivage : ", archive.Date.ToString("G")));

            byte[] fichier = archive.Document.Fichier;

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
            picture.Image = ArchiveDocumentConvert.ConvertByteToImage(fichier);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Dock = DockStyle.Fill;

            pnlDocument.Controls.Clear();
            pnlDocument.Controls.Add(picture);
        }
        void OpenPDF(byte[] fichier)
        {
            var viewer = new PdfViewer();
            viewer.Document = ArchiveDocumentConvert.ConvertByteToPDF(fichier);
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
            lstDetails.View = System.Windows.Forms.View.Details;
            lstDetails.GridLines = true;
            lstDetails.FullRowSelect = true;

            // pour fixer la taille dynamique de colonne
            var sizeColumn = (lstDetails.Width) / 2;

            //Ajouter les noms des entetes de la liste
            lstDetails.Columns.Add("Libellé", 50);
            lstDetails.Columns.Add("Description", sizeColumn);
        }
    }
}
