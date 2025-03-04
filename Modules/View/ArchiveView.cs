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
using ArchiveManagerApp.Model;
using Microsoft.Office.Interop.Word;
using Guna.UI2.WinForms;
using ArchiveManagerApp.Modules.Extension;
using System.Runtime.InteropServices;

namespace ArchiveManagerApp.Modules.View
{
    public partial class ArchiveView: UserControl
    {
        Archive archive;
        List<Archive> archives;
        public ArchiveView()
        {
            archives = new List<Archive>();
            InitializeComponent();
        }

        void DrawListView()
        {
            lstArchive.View = System.Windows.Forms.View.LargeIcon;
            //lst_agents.GridLines = true;
            //lst_agents.FullRowSelect = true;

            var sizeColumn = (lstArchive.Width - 300) / 2; // pour fixer la taille dynamique de colonne, nous envlevons la taille de la 1ere colonne

            //Ajouter les noms des entetes de la liste
            lstArchive.Columns.Add("#", 50);
            lstArchive.Columns.Add("Libellé", sizeColumn + 100  );
            lstArchive.Columns.Add("Mot clé", 100);
            lstArchive.Columns.Add("Date", 100);
            lstArchive.Columns.Add("Type", 50);
            lstArchive.Columns.Add("Agent", sizeColumn - 100);
        }

        void AddItemInListView(Archive instance = null)
        {
            if (instance == null)
                foreach (var row in archives)
                {
                    var listViewItem = new ListViewItem(row.data, row.Document.Index);
                    listViewItem.Tag = row;
                    lstArchive.Items.Add(listViewItem);
                }
            else
            {
                instance.NumberRow = archives.Count == 0 ? 1 : archives.FindLast(s => s.NumberRow > 0).NumberRow + 1;
                var listViewItem = new ListViewItem(instance.data, instance.Document.Index);
                listViewItem.Tag = instance;
                lstArchive.Items.Add(listViewItem);

                archives.Add(instance);
            }

            //lblNombreAgent.Text = agents.Count.ToString();
        }

        async System.Threading.Tasks.Task LoadArchives()
        {
            lstArchive.Items.Clear();

            archives = await System.Threading.Tasks.Task.Run(() => new Dao.ArchiveDao().GetAllAsync());

            AddItemInListView();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //AjoutArchive();
            var editDocumentView = new EditDocumentView();
            editDocumentView.ShowDialog();

            archive = editDocumentView.Archive;

            if(archive != null)
            {
                MessageBox.Show(archive.Document.Libelle + ", ajouté avec succès", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddItemInListView(archive);
            }      
        }

        private void ArchiveView_Load(object sender, EventArgs e)
        {
            DrawListView();
            LoadArchives();
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            var motif = ((Guna2TextBox)sender).Text.Trim().ToLower().NoAccent();

            if (motif == null)
                return;

            lstArchive.Items.Clear();

            lstArchive.Items.AddRange(archives.Where(i => string.IsNullOrEmpty(motif) ||
            i.Document.Libelle.ToLower().Trim().NoAccent().StartsWith(motif) ||
            i.Document.MotCle.ToLower().Trim().NoAccent().Contains(motif))
            .Select(c => listViewItem(c)
            ).ToArray());
        }

        ListViewItem listViewItem(Archive archive)
        {
           var lstview = new ListViewItem(archive.data, archive.Document.Index);
            lstview.Tag = archive;

            return lstview;

        }

        private void détailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lstArchive.SelectedItems.Count > 0)
            {
                var selectedItem = lstArchive.SelectedItems[0].Tag;

                archive = (Archive)selectedItem;

                var editDocumentView = new EditDocumentView(archive);
                editDocumentView.ShowDialog();
            }
        }
    }
}
