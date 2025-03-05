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
using ArchiveManagerApp.Dao;
using System.Data.Common;

namespace ArchiveManagerApp.Modules.View
{
    public partial class ParametreServerView: UserControl
    {
        string defaultdbName = "gestion_archivage_db";
        public ParametreServerView()
        {
            InitializeComponent();
            txtPassWord.IconRightClick += IconRigt_Click;

        }
        DbConnection connection;
        private void IconRigt_Click(object sender, EventArgs e)
        {

        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (Dao.Helper.AppDao.TestDatabase(connection, cmbDbs.SelectedItem.ToString().Trim()))
            {
                //IsTested = true;
                MessageBox.Show("Connexion réussie !", "Stone Consulting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("La connexion a échoué. Vous avez choisi une mauvaise base de données !");
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Modification(btnModifier.Text == "Modifier");

            DbConfig.DbName = Properties.Settings.Default.local_dbname = cmbDbs?.SelectedItem?.ToString();
            DbConfig.DbUser = Properties.Settings.Default.local_user = txtUserName.Text.Trim();
            DbConfig.DbPassword = Properties.Settings.Default.local_pwd = txtPassWord.Text.Trim();
            DbConfig.ServerName = Properties.Settings.Default.local_server = txtServer.Text.Trim();
            DbConfig.DbPort = Properties.Settings.Default.local_port = txtPort.Text.Trim();

            Properties.Settings.Default.Save();

            MessageBox.Show("Enregistrement reussi avec succès !!", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        void Bind()
        {
            txtServer.Text = Properties.Settings.Default.local_server;
            txtUserName.Text = Properties.Settings.Default.local_user;
            txtPort.Text = Properties.Settings.Default.local_port;
        }

        private void cmbDbs_DropDown(object sender, EventArgs e)
        {
            if (((G.Guna2ComboBox)sender).Items.Count == 0)
            {
                var feed = Dao.Helper.AppDao.CreateConnection(txtServer.Text.Trim(), txtUserName.Text.Trim(), txtPassWord.Text.Trim(), txtPort.Text.Trim());
                if (feed is DbConnection)
                {
                    connection = (DbConnection)feed;
                    LoadDatabases();
                }
                else
                {
                    MessageBox.Show(feed.ToString(), "Stone Consulting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        async Task LoadDatabases(object p = null)
        {
            cmbDbs.Items.Clear();
            //cmbDbs.AutoCompleteCustomSource.Clear();

            var list = await Task.Run(() => Dao.Helper.AppDao.GetDatabases(connection));

            //cmbDbs.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cmbDbs.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (var row in list)
            {
                //cmbDbs.AutoCompleteCustomSource.Add(row.ToString());
                cmbDbs.Items.Add(row);
            }

            cmbDbs.Text = list.Count > 0 ? defaultdbName : null;
        }

        private void ParametreServerView_Load(object sender, EventArgs e)
        {
            Bind();
        }
    }
}
