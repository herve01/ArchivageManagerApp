namespace ArchiveManagerApp
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btn_apropos = new Guna.UI2.WinForms.Guna2Button();
            this.btn_parametres = new Guna.UI2.WinForms.Guna2Button();
            this.btn_services = new Guna.UI2.WinForms.Guna2Button();
            this.btn_agents = new Guna.UI2.WinForms.Guna2Button();
            this.btn_archives = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tdb = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_ruban_logo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnl_ruban = new System.Windows.Forms.Panel();
            this.btn_min = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btn_max = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bouger = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnl_ruban_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnl_ruban.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(190, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(710, 600);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlMenu.Controls.Add(this.btn_apropos);
            this.pnlMenu.Controls.Add(this.btn_parametres);
            this.pnlMenu.Controls.Add(this.btn_services);
            this.pnlMenu.Controls.Add(this.btn_agents);
            this.pnlMenu.Controls.Add(this.btn_archives);
            this.pnlMenu.Controls.Add(this.btn_tdb);
            this.pnlMenu.Controls.Add(this.pnl_ruban_logo);
            this.pnlMenu.Controls.Add(this.pnl_ruban);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.pnlMenu.Size = new System.Drawing.Size(190, 600);
            this.pnlMenu.TabIndex = 0;
            // 
            // btn_apropos
            // 
            this.btn_apropos.Animated = true;
            this.btn_apropos.BorderRadius = 5;
            this.btn_apropos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btn_apropos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_apropos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_apropos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_apropos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_apropos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_apropos.FillColor = System.Drawing.Color.Transparent;
            this.btn_apropos.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apropos.ForeColor = System.Drawing.Color.White;
            this.btn_apropos.Image = global::ArchiveManagerApp.Properties.Resources.info_26px;
            this.btn_apropos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_apropos.Location = new System.Drawing.Point(10, 487);
            this.btn_apropos.Name = "btn_apropos";
            this.btn_apropos.Size = new System.Drawing.Size(170, 45);
            this.btn_apropos.TabIndex = 6;
            this.btn_apropos.Text = "Apropos";
            this.btn_apropos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_apropos.Click += new System.EventHandler(this.btnApropos_Click);
            // 
            // btn_parametres
            // 
            this.btn_parametres.Animated = true;
            this.btn_parametres.BorderRadius = 5;
            this.btn_parametres.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btn_parametres.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_parametres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_parametres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_parametres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_parametres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_parametres.FillColor = System.Drawing.Color.Transparent;
            this.btn_parametres.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parametres.ForeColor = System.Drawing.Color.White;
            this.btn_parametres.Image = global::ArchiveManagerApp.Properties.Resources.maintenance_26px;
            this.btn_parametres.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_parametres.Location = new System.Drawing.Point(10, 442);
            this.btn_parametres.Name = "btn_parametres";
            this.btn_parametres.Size = new System.Drawing.Size(170, 45);
            this.btn_parametres.TabIndex = 5;
            this.btn_parametres.Text = "Parametres";
            this.btn_parametres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_parametres.Click += new System.EventHandler(this.btnParametres_Click);
            // 
            // btn_services
            // 
            this.btn_services.Animated = true;
            this.btn_services.BorderRadius = 5;
            this.btn_services.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btn_services.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_services.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_services.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_services.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_services.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_services.FillColor = System.Drawing.Color.Transparent;
            this.btn_services.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_services.ForeColor = System.Drawing.Color.White;
            this.btn_services.Image = global::ArchiveManagerApp.Properties.Resources.hierarchy_26px;
            this.btn_services.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_services.Location = new System.Drawing.Point(10, 397);
            this.btn_services.Name = "btn_services";
            this.btn_services.Size = new System.Drawing.Size(170, 45);
            this.btn_services.TabIndex = 8;
            this.btn_services.Text = "Services";
            this.btn_services.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_services.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btn_agents
            // 
            this.btn_agents.Animated = true;
            this.btn_agents.BorderRadius = 5;
            this.btn_agents.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btn_agents.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_agents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_agents.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_agents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_agents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agents.FillColor = System.Drawing.Color.Transparent;
            this.btn_agents.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agents.ForeColor = System.Drawing.Color.White;
            this.btn_agents.Image = global::ArchiveManagerApp.Properties.Resources.user_account_26px;
            this.btn_agents.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_agents.Location = new System.Drawing.Point(10, 352);
            this.btn_agents.Name = "btn_agents";
            this.btn_agents.Size = new System.Drawing.Size(170, 45);
            this.btn_agents.TabIndex = 4;
            this.btn_agents.Text = "Agents";
            this.btn_agents.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_agents.Click += new System.EventHandler(this.btnAgents_Click);
            // 
            // btn_archives
            // 
            this.btn_archives.Animated = true;
            this.btn_archives.BorderRadius = 5;
            this.btn_archives.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btn_archives.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_archives.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_archives.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_archives.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_archives.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_archives.FillColor = System.Drawing.Color.Transparent;
            this.btn_archives.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_archives.ForeColor = System.Drawing.Color.White;
            this.btn_archives.Image = global::ArchiveManagerApp.Properties.Resources.folder_26px;
            this.btn_archives.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_archives.Location = new System.Drawing.Point(10, 307);
            this.btn_archives.Name = "btn_archives";
            this.btn_archives.Size = new System.Drawing.Size(170, 45);
            this.btn_archives.TabIndex = 2;
            this.btn_archives.Text = "Archives";
            this.btn_archives.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_archives.Click += new System.EventHandler(this.btnArchives_Click);
            // 
            // btn_tdb
            // 
            this.btn_tdb.Animated = true;
            this.btn_tdb.BorderRadius = 5;
            this.btn_tdb.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btn_tdb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tdb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tdb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tdb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tdb.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tdb.FillColor = System.Drawing.Color.Transparent;
            this.btn_tdb.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tdb.ForeColor = System.Drawing.Color.White;
            this.btn_tdb.Image = global::ArchiveManagerApp.Properties.Resources.categorize_26px;
            this.btn_tdb.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_tdb.Location = new System.Drawing.Point(10, 262);
            this.btn_tdb.Name = "btn_tdb";
            this.btn_tdb.Size = new System.Drawing.Size(170, 45);
            this.btn_tdb.TabIndex = 7;
            this.btn_tdb.Text = "Tableau de bord";
            this.btn_tdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_tdb.Click += new System.EventHandler(this.btnDashBord_Click);
            // 
            // pnl_ruban_logo
            // 
            this.pnl_ruban_logo.Controls.Add(this.picLogo);
            this.pnl_ruban_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ruban_logo.Location = new System.Drawing.Point(10, 30);
            this.pnl_ruban_logo.Name = "pnl_ruban_logo";
            this.pnl_ruban_logo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnl_ruban_logo.Size = new System.Drawing.Size(170, 232);
            this.pnl_ruban_logo.TabIndex = 3;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::ArchiveManagerApp.Properties.Resources.Plan_de_travail_5;
            this.picLogo.Location = new System.Drawing.Point(34, 56);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnl_ruban
            // 
            this.pnl_ruban.Controls.Add(this.btn_min);
            this.pnl_ruban.Controls.Add(this.btn_max);
            this.pnl_ruban.Controls.Add(this.btn_close);
            this.pnl_ruban.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ruban.Location = new System.Drawing.Point(10, 0);
            this.pnl_ruban.Name = "pnl_ruban";
            this.pnl_ruban.Size = new System.Drawing.Size(170, 30);
            this.pnl_ruban.TabIndex = 0;
            // 
            // btn_min
            // 
            this.btn_min.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btn_min.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_min.FillColor = System.Drawing.Color.Transparent;
            this.btn_min.IconColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(100, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(50, 30);
            this.btn_min.TabIndex = 2;
            // 
            // btn_max
            // 
            this.btn_max.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btn_max.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_max.FillColor = System.Drawing.Color.Transparent;
            this.btn_max.IconColor = System.Drawing.Color.White;
            this.btn_max.Location = new System.Drawing.Point(50, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(50, 30);
            this.btn_max.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.IconColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(0, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 30);
            this.btn_close.TabIndex = 0;
            // 
            // bouger
            // 
            this.bouger.DockIndicatorColor = System.Drawing.Color.IndianRed;
            this.bouger.DockIndicatorTransparencyValue = 0.6D;
            this.bouger.TargetControl = this.pnl_ruban;
            this.bouger.UseTransparentDrag = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive Manager App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.pnl_ruban_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnl_ruban.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btn_archives;
        private System.Windows.Forms.Panel pnl_ruban_logo;
        private Guna.UI2.WinForms.Guna2Button btn_apropos;
        private Guna.UI2.WinForms.Guna2Button btn_parametres;
        private Guna.UI2.WinForms.Guna2Button btn_agents;
        private System.Windows.Forms.Panel pnl_ruban;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private Guna.UI2.WinForms.Guna2ControlBox btn_min;
        private Guna.UI2.WinForms.Guna2ControlBox btn_max;
        private Guna.UI2.WinForms.Guna2Button btn_tdb;
        private Guna.UI2.WinForms.Guna2DragControl bouger;
        private Guna.UI2.WinForms.Guna2Button btn_services;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

