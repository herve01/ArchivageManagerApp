namespace ArchiveManagerApp.Modules.View
{
    partial class ServiceView
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lstServices = new System.Windows.Forms.ListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Service = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Agent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtService = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.txt_recherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.lstServices);
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(24, 77);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Size = new System.Drawing.Size(548, 493);
            this.guna2Panel1.TabIndex = 13;
            // 
            // lstServices
            // 
            this.lstServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num,
            this.Service,
            this.Agent});
            this.lstServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstServices.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lstServices.GridLines = true;
            this.lstServices.HideSelection = false;
            this.lstServices.Location = new System.Drawing.Point(10, 10);
            this.lstServices.Name = "lstServices";
            this.lstServices.ShowItemToolTips = true;
            this.lstServices.Size = new System.Drawing.Size(528, 473);
            this.lstServices.TabIndex = 0;
            this.lstServices.UseCompatibleStateImageBehavior = false;
            this.lstServices.View = System.Windows.Forms.View.Details;
            // 
            // Num
            // 
            this.Num.Text = "Num";
            this.Num.Width = 114;
            // 
            // Service
            // 
            this.Service.Text = "Service";
            this.Service.Width = 253;
            // 
            // Agent
            // 
            this.Agent.Text = "Agents";
            this.Agent.Width = 155;
            // 
            // txtService
            // 
            this.txtService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtService.Animated = true;
            this.txtService.AutoRoundedCorners = true;
            this.txtService.BorderRadius = 16;
            this.txtService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtService.DefaultText = "";
            this.txtService.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtService.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtService.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtService.Font = new System.Drawing.Font("Open Sans", 12F);
            this.txtService.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtService.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtService.Location = new System.Drawing.Point(4, 37);
            this.txtService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtService.Name = "txtService";
            this.txtService.PlaceholderText = "Service";
            this.txtService.SelectedText = "";
            this.txtService.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtService.ShadowDecoration.Depth = 50;
            this.txtService.Size = new System.Drawing.Size(242, 35);
            this.txtService.TabIndex = 10;
            this.txtService.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtService_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Service";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouter.Animated = true;
            this.btnAjouter.BorderRadius = 10;
            this.btnAjouter.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouter.Enabled = false;
            this.btnAjouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnAjouter.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = global::ArchiveManagerApp.Properties.Resources.new_copy_26px;
            this.btnAjouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAjouter.Location = new System.Drawing.Point(111, 79);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(135, 40);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAjouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // txt_recherche
            // 
            this.txt_recherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_recherche.Animated = true;
            this.txt_recherche.AutoRoundedCorners = true;
            this.txt_recherche.BorderRadius = 16;
            this.txt_recherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_recherche.DefaultText = "";
            this.txt_recherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_recherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_recherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche.Font = new System.Drawing.Font("Open Sans", 12F);
            this.txt_recherche.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche.IconRight = global::ArchiveManagerApp.Properties.Resources.search_26px;
            this.txt_recherche.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txt_recherche.Location = new System.Drawing.Point(24, 24);
            this.txt_recherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.PlaceholderText = "Recherche...";
            this.txt_recherche.SelectedText = "";
            this.txt_recherche.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txt_recherche.ShadowDecoration.Depth = 50;
            this.txt_recherche.Size = new System.Drawing.Size(548, 35);
            this.txt_recherche.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtService);
            this.panel1.Location = new System.Drawing.Point(602, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 127);
            this.panel1.TabIndex = 15;
            // 
            // ServiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.txt_recherche);
            this.Name = "ServiceView";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(900, 600);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private Guna.UI2.WinForms.Guna2TextBox txt_recherche;
        private Guna.UI2.WinForms.Guna2TextBox txtService;
        private System.Windows.Forms.ListView lstServices;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.ColumnHeader Service;
        private System.Windows.Forms.ColumnHeader Agent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
