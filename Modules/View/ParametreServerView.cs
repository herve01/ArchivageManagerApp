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
using ArchiveManagerApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using G = Guna.UI2.WinForms;
using ArchiveManagerApp.Dao;
using System.Data.Common;
using ArchiveManagerApp.Model;

namespace ArchiveManagerApp.Modules.View
{
    public partial class ParametreServerView: UserControl
    {
        string defaultdbName = "gestion_archivage_db";
        DbConnection connection;
        public ParametreServerView()
        {
            InitializeComponent();
        }
     
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (AppDao.TestDatabase(connection, cbxDataBase.SelectedItem.ToString().Trim()))
            {
                MessageBox.Show("Connexion réussie !", "Test Connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("La connexion a échoué.\nVous avez choisi une mauvaise base de données !",
                    "Test Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Modification(btnModifier.Text == "Modifier");

            DbConfig.DbName = ArchiveManagerApp.Properties.Settings.Default.local_database = cbxDataBase?.SelectedItem?.ToString();
            DbConfig.DbUser = ArchiveManagerApp.Properties.Settings.Default.local_user = txtUserName.Text;
            DbConfig.DbPassword = ArchiveManagerApp.Properties.Settings.Default.local_password = txtPassWord.Text;
            DbConfig.ServerName = ArchiveManagerApp.Properties.Settings.Default.local_server = txtServer.Text;
            DbConfig.DbPort = ArchiveManagerApp.Properties.Settings.Default.local_port = txtPort.Text;

            Properties.Settings.Default.Save();

            MessageBox.Show("Enregistrement reussi avec succès !!", "Enregistrement",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var feed = AppDao.CreateConnection(txtServer.Text.Trim(), txtUserName.Text, txtPassWord.Text.Trim(), txtPort.Text);
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
            cbxDataBase.Items.Clear();
            //cmbDbs.AutoCompleteCustomSource.Clear();

            var list = await Task.Run(() => AppDao.GetDatabases(connection));

            //cmbDbs.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cmbDbs.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (var row in list)
            {
                //cmbDbs.AutoCompleteCustomSource.Add(row.ToString());
                cbxDataBase.Items.Add(row);
            }

            cbxDataBase.Text = list.Count > 0 ? defaultdbName : null;
        }

        private void ParametreServerView_Load(object sender, EventArgs e)
        {
            Bind();
        }
    }
}
