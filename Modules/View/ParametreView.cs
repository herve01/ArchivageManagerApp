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
    public partial class ParametreView: UserControl
    {
        private UserControl pageUser, pageServer;
        public ParametreView()
        {
            InitializeComponent();
            Initilialisation();
        }
        private void Initilialisation()
        {
            pageUser = new ParametreUserView();
            pageServer = new ParametreServerView();
            btnUser.PerformClick();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            ViewDesign.ShowPage(pnlBody, pageServer);
            ViewDesign.CheckButton(sender, pnlMenu);
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            ViewDesign.ShowPage(pnlBody, pageUser);
            ViewDesign.CheckButton(sender, pnlMenu);
        }
    }
}
