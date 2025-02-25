using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveManagerApp.Modules.View.Pop
{
    public partial class PopAgent: Form
    {
        string path;
        public PopAgent()
        {
            InitializeComponent();
            btn_annuler.Click += btn_close_Click;
        }


        private void btn_importer_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (op.ShowDialog() == DialogResult.OK)
            {
                path = op.FileName;
                pic_profile.Image = Image.FromFile(op.FileName); // Charger l'image
            }
        }

        private void btn_nettoyer_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Text ="";
            }
            pic_profile.Image = null;
            txt_nom.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_archiver_Click(object sender, EventArgs e)
        {

        }
    }
}
