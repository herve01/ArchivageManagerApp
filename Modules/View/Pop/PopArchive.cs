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

namespace ArchiveManagerApp.Modules.View.Pop
{
    public partial class PopArchive: Form
    {
        string path;
        private PdfViewer pdfViewer;
        PdfRenderer renderer;
        public PopArchive()
        {
            InitializeComponent();
            pdfViewer = new PdfViewer();
            pdfViewer.Dock = DockStyle.Fill;
            pnl_pdf.Controls.Add(pdfViewer);

            btn_annuler.Click += btn_close_Click;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_impoter_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Documents|*.pdf;*.doc;*.txt;*.jpg;*.png";

            if (op.ShowDialog() == DialogResult.OK)
            {
                path = op.FileName;
                var data = File.ReadAllBytes(path);
                PdfiumViewer.PdfDocument doc;
                using (Stream stream = new MemoryStream(data))
                {
                    doc = PdfiumViewer.PdfDocument.Load(stream);
                    var viewer = new PdfiumViewer.PdfViewer();
                    viewer.Document = doc;
                    viewer.Dock = DockStyle.Fill;
                    pnl_pdf.Controls.Add(viewer);
                }
                
                txt_path.Text = path;
            }
        }
    }
}
