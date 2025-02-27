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

namespace ArchiveManagerApp.Modules.View
{
    public partial class AgentView: UserControl
    {
        public AgentView()
        {
            InitializeComponent();
        }

        private void btn_ajouter_Click_1(object sender, EventArgs e)
        {
              Form Page = new EditAgentView();
            Page.ShowDialog();
        }
    }
}
