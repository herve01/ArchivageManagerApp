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
    public partial class PopArchive: Form
    {
        string path;
        private PdfViewer viewer;
        private Microsoft.Office.Interop.Word.Application wordApp;
        private Document wordDoc;
        public PopArchive()
        {
            InitializeComponent();

            viewer = new PdfViewer();

            viewer = new PdfViewer
            {
                Dock = DockStyle.Fill,
                Parent = this.pnlPdfFile // Set panel1 as the parent container
            };

            btn_annuler.Click += btn_close_Click;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_impoter_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Documents|*.pdf;*.doc;*.docx;*.txt;*.jpg;*.png";
            openFileDialog.Title = "Sélectionné fichier";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;

                if(path.ToLower().Contains(".pdf"))
                {
                    var doc = PdfDocument.Load(path);
                    viewer.Document = doc;
                }
                else if(path.ToLower().Contains(".doc") | path.ToLower().Contains(".docx"))
                {
                    wordApp = new Microsoft.Office.Interop.Word.Application();
                    wordDoc = wordApp.Documents.Open(path);

                    // Make Word visible (optional)
                    wordApp.Visible = true;
                }

                txt_path.Text = path;
            }
        }
    }
}
