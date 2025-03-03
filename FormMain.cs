using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using ArchiveManagerApp.Modules.View;
using ArchiveManagerApp.Tools;
using G = Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    public partial class FormMain: Form
    {
        #region Constructeur & Initialisation
        UserControl pageDashBord, pageArchives, pageAgents, pageServices, pageParametres, pageApropos;
        public FormMain()
        {
            InitializeComponent();
            Initialisation();
        }
        private void Initialisation()
        {
            pageDashBord = new DashBordView();
            pageArchives = new ArchiveView();
            pageAgents = new AgentView();
            pageServices= new ServiceView();
            pageParametres = new ParametreView();
            pageApropos = new AproposView();
            btn_tdb.PerformClick();
        }
        #endregion
        #region ButtonClick
        private void btnDashBord_Click(object sender, EventArgs e)
        {
            ViewDesign.ShowPage(pnlBody, pageDashBord);
            ViewDesign.CheckButton(sender, pnlMenu);
        }
        private void btnArchives_Click(object sender, EventArgs e)
        {
            ViewDesign.ShowPage(pnlBody, pageArchives);
            ViewDesign.CheckButton(sender, pnlMenu);
        }
        private void btnAgents_Click(object sender, EventArgs e)
        {
            ViewDesign.ShowPage(pnlBody, pageAgents);
            ViewDesign.CheckButton(sender, pnlMenu);
        }
        private void btnServices_Click(object sender, EventArgs e)
        {
            ViewDesign.ShowPage(pnlBody, pageServices);
            ViewDesign.CheckButton(sender, pnlMenu);
        }
        private void btnParametres_Click(object sender, EventArgs e)
        {
            ViewDesign.ShowPage(pnlBody, pageParametres);
            ViewDesign.CheckButton(sender, pnlMenu);
        }
        private void btnApropos_Click(object sender, EventArgs e)
        {
            ViewDesign.ShowPage(pnlBody, pageApropos);
            ViewDesign.CheckButton(sender, pnlMenu);
        }
        #endregion
    }
}
