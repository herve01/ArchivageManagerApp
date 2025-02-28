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
            lst_agents.View = System.Windows.Forms.View.Details;
            lst_agents.GridLines = true;
            lst_agents.FullRowSelect = true;

            var sizeColumn = (lst_agents.Width - 250) /4 ; // pour fixer la taille dynamique de colonne, nous envlevons la taille de la 1ere colonne

            //Ajouter les noms des entetes de la liste
            lst_agents.Columns.Add("#", 50);
            lst_agents.Columns.Add("Noms", sizeColumn + 100);
            lst_agents.Columns.Add("Sexe", 100);
            lst_agents.Columns.Add("Téléphone", 100);
            lst_agents.Columns.Add("Mail", sizeColumn - 50);
            lst_agents.Columns.Add("Poste", sizeColumn + 50);
            lst_agents.Columns.Add("Service", sizeColumn -100);
        }

        void AddItemInListView(Agent instance = null)
        {
            if (instance == null)
                foreach (var row in agents)
                {
                    lst_agents.Items.Add(new ListViewItem(row.data));
                }
            else
            {
                instance.NumberRow = agents.Count == 0 ? 1 : agents.FindLast(s => s.NumberRow > 0).NumberRow + 1;
                lst_agents.Items.Add(new ListViewItem(instance.data));

                agents.Add(instance);
            }

            //lblNombreAgent.Text = agents.Count.ToString();
        }

        async System.Threading.Tasks.Task LoadAgents()
        {
            lst_agents.Items.Clear();

            agents = await System.Threading.Tasks.Task.Run(() => new Dao.AgentDao().GetAllAsync());

            AddItemInListView();
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            var motif = ((Guna2TextBox)sender).Text.Trim().ToLower().NoAccent();

            if (motif == null)
                return;

            lst_agents.Items.Clear();

            lst_agents.Items.AddRange(agents.Where(i => string.IsNullOrEmpty(motif) ||
            i.Name.ToLower().Trim().NoAccent().StartsWith(motif) ||
            i.Name.ToLower().Trim().NoAccent().Contains(motif) ||
            i.CurrentAffectation.Service.ToString().ToLower().Trim().NoAccent().StartsWith(motif) ||
            i.CurrentAffectation.Service.ToString().ToLower().Trim().NoAccent().Contains(motif))
            .Select(c => new ListViewItem(c.data)).ToArray());
        }

        private void AgentView_Load(object sender, EventArgs e)
        {
            DrawListView();
            LoadAgents();
        }
     

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Form Page = new EditAgentView();
            Page.ShowDialog();
            agent = ((EditAgentView)Page).Agent;
            MessageBox.Show(agent.Name + ", ajouté avec succès", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
