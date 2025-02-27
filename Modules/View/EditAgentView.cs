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
    public partial class EditAgentView: Form
    {
        string path;
        public EditAgentView()
        {
            InitializeComponent();
            NettoyageControle(this);
        }


        private void btn_importer_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (op.ShowDialog() == DialogResult.OK)
            {
                path = op.FileName;
                picProfile.Image = Image.FromFile(op.FileName); // Charger l'image
            }
        }

        private void btn_nettoyer_Click(object sender, EventArgs e)
        {
            NettoyageControle(this);
            txtNom.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_archiver_Click(object sender, EventArgs e)
        {

        }

        public void NettoyageControle(Control conteneur)
        {
            foreach(Control control in conteneur.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if(control is PictureBox)
                {
                    ((PictureBox)control).Image = null;
                }
                else if(control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
                else
                {
                    NettoyageControle(control);
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
