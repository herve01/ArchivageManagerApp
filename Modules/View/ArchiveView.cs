using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchiveManagerApp.Modules.View.Pop;

namespace ArchiveManagerApp.Modules.View
{
    public partial class ArchiveView: UserControl
    {
        public ArchiveView()
        {
            InitializeComponent();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            AjoutArchive();
            //Form Pop = new EditDocumentView();
            //Pop.ShowDialog();
        }
        private void AjoutArchive()
        {
            for(int a = 0; a < 10; a++)
            {
                Random random = new Random();
                
                lstServices.Items.Add(new ListViewItem(new string[] { a.ToString(), "120 Jours de sodome", "Livre", "Salem Kis" }, random.Next(0, 3)));
            }
        }
        private int Ext(string extension)
        {
            int a=0;
            switch (extension)
            {
                case ".pdf" :
                    a = 0;
                    break;
                case ".docx":
                    a = 1;
                    break;
                case ".doc":
                    a = 1;
                    break;
                case ".png":
                    a = 2;
                    break;
                case ".jpg":
                    a = 2;
                    break;
            }
            return a;
        }
    }
}
