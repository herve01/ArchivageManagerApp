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
using ArchiveManagerApp.View.Contract;

namespace ArchiveManagerApp.Modules.View
{
    public partial class AgentView : UserControl, ICallerView, IStructureView
    {

        //Declaration variable
        Agent agent;
        List<Agent> agents;

        public AgentView()
        {
            agents = new List<Agent>();
            InitializeComponent();
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
            var editAgentView = new EditAgentView(this);
            editAgentView.ShowDialog();
        }

        private void AgentView_Load(object sender, EventArgs e)
        {
            DrawListView();
            LoadAgents();
        }

        async Task LoadAgents()
        {
            lstUsers.Items.Clear();

            agents = await Task.Run(() => new Dao.AgentDao().GetAllAsync());

            AddItemListView();
        }
        
        public void AddObject(object obj)
        {
            var _agent = (Agent)obj;

            if(_agent != null)
                AddItemListView(_agent);
        }

        public void DeleteObject(object obj)
        {
            throw new NotImplementedException();
        }

        public void EditObject(object obj)
        {
            throw new NotImplementedException();
        }

        public bool ContainsObject(object obj)
        {
            throw new NotImplementedException();
        }

        public void DrawListView()
        {
            lstUsers.View = System.Windows.Forms.View.Details;
            lstUsers.GridLines = true;
            lstUsers.FullRowSelect = true;

            var sizeColumn = (lstUsers.Width - 250) / 4; // pour fixer la taille dynamique de colonne, nous envlevons la taille de la 1ere colonne

            //Ajouter les noms des entetes de la liste
            lstUsers.Columns.Add("#", 50);
            lstUsers.Columns.Add("Noms", sizeColumn + 100);
            lstUsers.Columns.Add("Sexe", 100);
            lstUsers.Columns.Add("Téléphone", 100);
            lstUsers.Columns.Add("Mail", sizeColumn - 50);
            lstUsers.Columns.Add("Poste", sizeColumn + 50);
            lstUsers.Columns.Add("Service", sizeColumn - 100);
        }
        public void AddItemListView(object obj = null)
        {
            var instance = (Agent)obj;

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
        }
    }
}
