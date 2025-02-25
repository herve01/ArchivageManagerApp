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

namespace WindowsFormsApp1
{
    public partial class Main: Form
    {
        private Point mouseOffset; // Stocke la position de la souris
        private bool isDragging = false; // Indique si on est en train de déplacer

        public Main()
        {
            InitializeComponent();

            lbl_entete.MouseDown += MouseDown_;
            lbl_entete.MouseMove += MouseMove_;
            lbl_entete.MouseUp += MouseUp_;
            //lbl_entete.DoubleClick += DoubleClick_;

            pnl_ruban.MouseDown += MouseDown_;
            pnl_ruban.MouseMove += MouseMove_;
            pnl_ruban.MouseUp += MouseUp_;
            //pnl_ruban.DoubleClick += DoubleClick_;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }
        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MouseDown_(object sender, MouseEventArgs e)
        {
            isDragging = true;
            mouseOffset = new Point(e.X, e.Y);
        }
        private void MouseMove_(object sender, MouseEventArgs e) 
        {           
            if (isDragging)
            {
                this.Left = Cursor.Position.X - mouseOffset.X;
                this.Top = Cursor.Position.Y - mouseOffset.Y;
            }
        }
        private void MouseUp_(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void DoubleClick_(object sender, EventArgs e) 
        {
            this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void btn_apropos_Click(object sender, EventArgs e)
        {
            UserControl Page = new AproposCtrlView();
            AfficherPage(Page);
        }
        private void btn_utilisateur_Click(object sender, EventArgs e)
        {
            UserControl Page = new AgentCtrlView();
            AfficherPage(Page);
        }
        private void btn_parametre_Click(object sender, EventArgs e)
        {
            UserControl Page = new ParametreCtrlView();
            AfficherPage(Page);
        }
        private void btn_document_Click(object sender, EventArgs e)
        {
            UserControl Page = new ArchiveCtrlView();
            AfficherPage(Page);
        }


        private void AfficherPage(UserControl Page)
        {
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(Page);
        }
    }
}
