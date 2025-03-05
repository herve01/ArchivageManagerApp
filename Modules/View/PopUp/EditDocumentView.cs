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
using ArchiveManagerApp.Model;
using ArchiveManagerApp.Util;
using ArchiveManagerApp.Tools;

namespace ArchiveManagerApp.Modules.View.Pop
{
    public partial class EditDocumentView: Form
    {
        public Archive Archive { get; set; }
        string path;
        //private PdfViewer viewer;
        private Microsoft.Office.Interop.Word.Application wordApp;
        private Microsoft.Office.Interop.Word.Document wordDoc;
        public EditDocumentView(Archive archive = null)
        {
            InitializeComponent();

            if(archive != null)
            {
                Detail(archive);
            }
        }


        void Detail(Archive archive)
        {
            txtLibelle.Text = archive.Document.Libelle;
            txtMotCle.Text = archive.Document.MotCle;
            //viewer = new PdfViewer();

            var byteFile = archive.Document.Fichier;
            var doc = PdfDocument.Load(Functions.LoadPdfFromByteArray(byteFile));
            //viewer.Document = doc;
            //viewer.Dock = DockStyle.Fill;
            //pnlDocument.Controls.Clear();
            //pnlDocument.Controls.Add(viewer);
        }
        
        private void btnImporter_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Documents|*.pdf;*.doc;*.docx;*.txt;*.jpg;*.png";
            openFileDialog.Title = "Sélectionné fichier";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;

                txtLibelle.Text = Path.GetFileName(path);

                if (path.ToLower().Contains(".pdf"))
                {
                    var viewer = new PdfViewer();
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
        private void btnArchiver_Click(object sender, EventArgs e)
        {
            Archive = new Archive();
            Archive.Document.Fichier = Functions.ConvertPdfToByteArray(path);
            Archive.Document.MotCle = txtMotCle.Text;
            Archive.Document.Libelle = txtLibelle.Text;
            Archive.User = new User() { Id = "ZERI0100001RU983KDHOJE9747K3" };

            Archive.Document.Extension = path.Trim().ToLower().Contains(".pdf") ? Model.Helper.Util.ExtensionType.PDF :
                path.Trim().ToLower().Contains(".doc") ? Model.Helper.Util.ExtensionType.DOC : Model.Helper.Util.ExtensionType.IMAGE;

            Archive.Date = DateTime.Now;

            if (new Dao.ArchiveDao().Add(Archive) > 0)
            {
                MessageBox.Show("Enregistrement effectué avec succès", "Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViewDesign.TextBoxIsNullOrEmpty(pnl_body);
            }
            else
            {
                MessageBox.Show("Une Erreur est survenue lors de l'enregistrement.\n Rassurez-vous d'avoir rempli tous les champs !!", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}
