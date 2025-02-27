using ArchiveManagerApp.Modules.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G = Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    public partial class Main: Form
    {
        UserControl page_archives, page_agents, page_parametres, page_apropos,
                    page_tableau_de_bord, page_services;
        UserControl page_selectionnee;

        public Main()
        {
            InitializeComponent();
            page_archives = new ArchiveView();
            page_agents = new AgentView();
            page_parametres = new ParametreView();
            page_apropos = new AproposView();
            page_tableau_de_bord = new TableDeBordView();
            page_services= new ServiceView();
            Initialisation();
        }

        private void btn_apropos_Click(object sender, EventArgs e)
        {
            AfficherPage(page_apropos);
            Checker(sender, pnl_menu);
        }
        private void btn_agents_Click(object sender, EventArgs e)
        {
            AfficherPage(page_agents);
            Checker(sender, pnl_menu);
        }
        private void btn_parametres_Click(object sender, EventArgs e)
        {
            AfficherPage(page_parametres);
            Checker(sender, pnl_menu);
        }
        private void btn_archives_Click(object sender, EventArgs e)
        {
            AfficherPage(page_archives);
            Checker(sender, pnl_menu);
        }

        private void btn_tdb_Click(object sender, EventArgs e)
        {
            AfficherPage(page_tableau_de_bord);
            Checker(sender, pnl_menu);
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            AfficherPage(page_services);
            Checker(sender, pnl_menu);
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {

        }

        private void AfficherPage(UserControl Page)
        {
            if(Page != page_selectionnee)
            {
                pnl_body.Controls.Clear();
                Page.Size = pnl_body.Size;
                pnl_body.Controls.Add(Page);
                page_selectionnee = Page;
            }
            
        }
        private void Checker(object btn, Panel conteneur)
        {
            if(((G.Guna2Button)btn).Checked == false)
            {
                foreach(G.Guna2Button btn_ in conteneur.Controls.OfType<G.Guna2Button>())
                {
                    btn_.Checked = false;
                }
                ((G.Guna2Button)btn).Checked = true;
            }
        }
        private void Initialisation()
        {
            btn_tdb.PerformClick();
        }
    }
}
