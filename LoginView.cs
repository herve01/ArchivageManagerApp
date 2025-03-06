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
using ArchiveManagerApp.Model.App;
using ArchiveManagerApp.Tools;

namespace ArchiveManagerApp
{
    public partial class LoginView : Form
    {
        public LoginView()
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
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //User user = users.Find(u => u.UserName == txtUser.Text);
                var user = new Dao.UserDao().Get(txtUser.Text, txtPassword.Text);

                if (user != null)
                {
                    AppConfig.CURRENT_USER = user;

                    Properties.Settings.Default.last_connected_user_name = txtUser.Text.Trim();
                    Properties.Settings.Default.Save();

                    //ViewDesign.ControlsClear(this);
                    //this.Hide();
                    //new FormMain().Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Utilisateur introuvable", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            txtUser.Text = Properties.Settings.Default.last_connected_user_name;
        }
    }
}
