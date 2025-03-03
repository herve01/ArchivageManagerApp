using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchiveManagerApp.Dao.Helper;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using G = Guna.UI2.WinForms;

namespace ArchiveManagerApp.Modules.View
{
    public partial class ParametreServerView: UserControl
    {
        public ParametreServerView()
        {
            InitializeComponent();
            txtPassWord.IconRightClick += IconRigt_Click;

        }

        private void IconRigt_Click(object sender, EventArgs e)
        {

        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            ServerConfiguration.TestConnection(txtServer.Text, txtPort.Text,
                              txtDataBase.Text, txtUser.Text, txtPassWord.Text);
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Modification(btnModifier.Text == "Modifier");
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Modification(false);
        }
        private void Modification(bool activer)
        {
            foreach(G.Guna2TextBox txtBox in this.Controls.OfType<G.Guna2TextBox>())
            {
                txtBox.ReadOnly = !activer;
            }
            btnAnnuler.Visible = activer;
            btnTestConnection.Visible = activer;
            if (btnModifier.Text == "Modifier")
                btnModifier.Text = "Sauvegarder";
            else
                btnModifier.Text = "Modifier";
        }

       
    }
}
