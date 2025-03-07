using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveManagerApp.Modules.View
{
    public partial class DashBordView: UserControl
    {
        public DashBordView()
        {
            InitializeComponent();
        }

        private void DashBordView_Load(object sender, EventArgs e)
        {
            tdbArchives.Number = new Dao.ArchiveDao().Count().ToString();
            tdbServices.Number = new Dao.ServiceDao().Count().ToString();
            tdbAgents.Number = new Dao.AgentDao().Count().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
