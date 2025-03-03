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

namespace ArchiveManagerApp.Modules.View
{
    public partial class ParametreUserView: UserControl
    {
        public ParametreUserView()
        {
            InitializeComponent();
            txtUser.TextChanged += TextBox_textChanged;
            txtPassword.TextChanged += TextBox_textChanged;
            LoadAgents();
        }

        private void TextBox_textChanged(object sender, EventArgs e)
        {
            btnAjouter.Enabled = !ViewDesign.TextBoxIsNullOrEmpty(pnlEdit);
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            btnAnnuler.Visible = false;
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            btnAnnuler.Visible = false;
        }

        async Task LoadAgents()
        {
            cbxAgent.Items.Clear();

            var list = await Task.Run(() => new Dao.AgentDao().GetAllAsync());

            foreach (var row in list)
            {
                cbxAgent.Items.Add(row.Name);
            }

            cbxAgent.SelectedIndex = list != null ? 0 : -1;
        }
    }
}
