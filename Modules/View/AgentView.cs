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
using ArchiveManagerApp.Util;
using Guna.UI2.WinForms;
using ArchiveManagerApp.Modules.Extension;

namespace ArchiveManagerApp.Modules.View
{
    public partial class AgentView: UserControl
    {

        //Declaration variable
        Agent agent;
        List<Agent> agents;

        public AgentView()
        {
            agents = new List<Agent>();
            InitializeComponent();
        }

        void DrawListView()
        {
            lstUsers.View = System.Windows.Forms.View.Details;
            lstUsers.GridLines = true;
            lstUsers.FullRowSelect = true;

            var sizeColumn = (lstUsers.Width - 250) /4 ; // pour fixer la taille dynamique de colonne, nous envlevons la taille de la 1ere colonne

            //Ajouter les noms des entetes de la liste
            lstUsers.Columns.Add("#", 50);
            lstUsers.Columns.Add("Noms", sizeColumn + 100);
            lstUsers.Columns.Add("Sexe", 100);
            lstUsers.Columns.Add("Téléphone", 100);
            lstUsers.Columns.Add("Mail", sizeColumn - 50);
            lstUsers.Columns.Add("Poste", sizeColumn + 50);
            lstUsers.Columns.Add("Service", sizeColumn -100);
        }

        void AddItemInListView(Agent instance = null)
        {
            if (instance == null)
                foreach (Agent row in agents)
                {
                    lstUsers.Items.Add(new ListViewItem(row.data));
                }
            else
            {
                instance.NumberRow = agents.Count == 0 ? 1 : agents.FindLast(s => s.NumberRow > 0).NumberRow + 1;
                lstUsers.Items.Add(new ListViewItem(instance.data));

                agents.Add(instance);
            }

            //lblNombreAgent.Text = agents.Count.ToString();
        }

        async System.Threading.Tasks.Task LoadAgents()
        {
            lstUsers.Items.Clear();

            agents = await System.Threading.Tasks.Task.Run(() => new Dao.AgentDao().GetAllAsync());

            AddItemInListView();
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            var motif = ((Guna2TextBox)sender).Text.Trim().ToLower().NoAccent();

            if (motif == null)
                return;

            lstUsers.Items.Clear();

            lstUsers.Items.AddRange(agents.Where(i => string.IsNullOrEmpty(motif) ||
            i.Name.ToLower().Trim().NoAccent().StartsWith(motif) ||
            i.Name.ToLower().Trim().NoAccent().Contains(motif) ||
            i.CurrentAffectation.Service.ToString().ToLower().Trim().NoAccent().StartsWith(motif) ||
            i.CurrentAffectation.Service.ToString().ToLower().Trim().NoAccent().Contains(motif))
            .Select(c => new ListViewItem(c.data)).ToArray());
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            var editAgentView = new EditAgentView();
            editAgentView.ShowDialog();

            agent = editAgentView.Agent;
            if(agent != null)
            {
                MessageBox.Show(agent.Name + ", ajouté avec succès", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddItemInListView(agent);
            }
        }

        private void AgentView_Load(object sender, EventArgs e)
        {
            DrawListView();
            LoadAgents();
        }

        private void détailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        private void suprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
