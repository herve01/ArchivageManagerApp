using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchiveManagerApp.Dao;
using ArchiveManagerApp.Model;
using ArchiveManagerApp.Tools;

namespace ArchiveManagerApp
{
    public partial class FormConnexion : Form
    {
        List<User> users = new List<User>();
        public FormConnexion()
        {
            InitializeComponent();
            picCover.MouseEnter += Control_MouseEnter;
            lblTitle.MouseEnter += Control_MouseEnter;
            this.MouseEnter += Control_MouseEnter;
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            bougerControl.TargetControl = this;
            bougerControl.TargetControl = (Control)sender;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (ViewDesign.TextBoxIsNullOrEmpty(this))
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                User user = users.Find(u => u.UserName == txtUser.Text);
                if (user != null)
                {
                    if (true)//user.Password == txtPassword.Text)
                    {
                        ViewDesign.ControlsClear(this);
                        this.Hide();
                        new FormMain().Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe incorrect", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Utilisateur introuvable", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private async Task LoadUsers()
        {
             users = await new UserDao().GetAllAsync();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}
