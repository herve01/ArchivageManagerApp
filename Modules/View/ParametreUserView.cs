using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchiveManagerApp.Tools;
using ArchiveManagerApp.Model;
using Guna.UI2.WinForms;
using ArchiveManagerApp.Modules.Extension;

namespace ArchiveManagerApp.Modules.View
{
    public partial class ParametreUserView: UserControl
    {
        User user;
        List<User> users;
        public ParametreUserView()
        {
            InitializeComponent();
            users = new List<User>();
            txtRecherche.TextChanged += txt_recherche_TextChanged;
            txtUser.TextChanged += textBox_textChanged;
            txtPassword1.TextChanged += textBox_textChanged;
            txtPassword2.TextChanged += textBox_textChanged;
        }

        #region Buttons
        private void btnAjouter_Click(object sender, EventArgs e)
        { 
            if(!txtPassword1.Text.Equals(txtPassword2.Text))
            {
                MessageBox.Show("Les mots de passe ne correspondent pas", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                user = new User();
                user.UserName = txtUser.Text;
                user.Password = txtPassword1.Text;
                user.Agent = (Agent)cbxAgent.SelectedItem;
                if (new Dao.UserDao().Add(user) > 0)
                {
                    MessageBox.Show("Enregistrement effectué avec succès", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    AddItemInListView(user);

                    ViewDesign.ControlsClear(pnlEdit);btnAnnuler.Visible = false;
                }
                else
                {
                    MessageBox.Show("Une Erreur est survenue lors de l'enregistrement.\n" +
                                    " Rassurez-vous d'avoir rempli tous les champs !!", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ViewDesign.ControlsClear(pnlEdit); btnAnnuler.Visible = false;
        }
        #endregion

        #region Evenements
        private void ParametreUserView_Load(object sender, EventArgs e)
        {
            DrawListView();
            //LoadAgents();
            LoadUsers();
            
        }
        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            var motif = ((Guna2TextBox)sender).Text.Trim().ToLower().NoAccent();

            if (motif == null)
                return;

            lstUsers.Items.Clear();

            lstUsers.Items.AddRange(users.Where(i => string.IsNullOrEmpty(motif) ||
            i.Agent.Name.ToLower().Trim().NoAccent().StartsWith(motif) ||
            i.Agent.Name.ToLower().Trim().NoAccent().Contains(motif) ||
            i.UserName.ToLower().Trim().NoAccent().StartsWith(motif) ||
            i.UserName.ToLower().Trim().NoAccent().Contains(motif))
            .Select(c => new ListViewItem(c.data)).ToArray());
        }
        private void textBox_textChanged(object sender, EventArgs e)
        {
            btnAjouter.Enabled = !ViewDesign.TextBoxIsNullOrEmpty(pnlEdit);
        }
        private void cbxAgent_DropDown(object sender, EventArgs e)
        {
            LoadAgents();
        }
        #endregion


        #region Methodes & Fonctions
        async Task LoadUsers()
        {
            var dao = new Dao.UserDao();
            dao.NewConnection();

            users = await Task.Run(() => dao.GetAllAsync());

            AddItemInListView();
        }
        async Task LoadAgents()
        {
            cbxAgent.Items.Clear();

            var list = await Task.Run(() => new Dao.AgentDao().GetAllAsync());

            foreach (var row in list)
            {
                cbxAgent.Items.Add(row);
            }

            cbxAgent.SelectedIndex = list != null ? 0 : -1;
        }
        void DrawListView()
        {
            lstUsers.View = System.Windows.Forms.View.Details;
            lstUsers.GridLines = true;
            lstUsers.FullRowSelect = true;

            var sizeColumn = (lstUsers.Width - 50) /2; 

            //Ajouter les noms des entetes de la liste
            lstUsers.Columns.Add("#", 50);
            lstUsers.Columns.Add("Agent", sizeColumn + 100);
            lstUsers.Columns.Add("Nom utilisateur", sizeColumn - 100);
        }
        void AddItemInListView(User instance = null)
        {
            if (instance == null)
                foreach (var row in users)
                {
                    lstUsers.Items.Add(new ListViewItem(row.data));
                }
            else
            {
                instance.NumberRow = users.Count == 0 ? 1 : users.Last(s => s.NumberRow > 0).NumberRow + 1;
                lstUsers.Items.Add(new ListViewItem(instance.data));

                users.Add(instance);
            }

            lblNombreService.Text = users.Count.ToString("00");
        }
        #endregion
    }
}
