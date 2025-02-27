using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfiumViewer;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace ArchiveManagerApp.Modules.View.Pop
{
    public partial class EditDocumentView: Form
    {
        string path;
        private PdfViewer viewer;
        private Microsoft.Office.Interop.Word.Application wordApp;
        private Document wordDoc;
        public EditDocumentView()
        {
            InitializeComponent();
        }

        private void btnImporter_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Documents|*.pdf;*.doc;*.docx;*.txt;*.jpg;*.png";
            openFileDialog.Title = "Sélectionné fichier";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;

                if (path.ToLower().Contains(".pdf"))
                {
                    viewer = new PdfViewer();

                    var doc = PdfDocument.Load(path);
                    viewer.Document = doc;
                    viewer.Dock = DockStyle.Fill;
                    pnlDocument.Controls.Clear();
                    pnlDocument.Controls.Add(viewer); 
                }
                else if (path.ToLower().Contains(".doc") | path.ToLower().Contains(".docx"))
                {
                    wordApp = new Microsoft.Office.Interop.Word.Application();
                    wordDoc = wordApp.Documents.Open(path);

                    // Make Word visible (optional)
                    wordApp.Visible = true;
                }
                else if (path.ToLower().Contains(".jpg") | path.ToLower().Contains(".png"))
                {
                    pnlDocument.Controls.Clear();
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Dock = DockStyle.Fill;
                    pic.Image = Image.FromFile(path);
                    pnlDocument.Controls.Add(pic);
                }
            }
        }

        private void btnNettoyer_Click(object sender, EventArgs e)
        {

        }
    }
}
