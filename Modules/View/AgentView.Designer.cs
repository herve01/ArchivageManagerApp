namespace ArchiveManagerApp.Modules.View
{
    partial class AgentView
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
            this.pnlList = new Guna.UI2.WinForms.Guna2Panel();
            this.lstUsers = new System.Windows.Forms.ListView();
            this.menuArchive = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.détailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.suprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.txtRecherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.pnlList.SuspendLayout();
            this.menuArchive.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.BackColor = System.Drawing.Color.Transparent;
            this.pnlList.BorderRadius = 10;
            this.pnlList.Controls.Add(this.lstUsers);
            this.pnlList.FillColor = System.Drawing.Color.Transparent;
            this.pnlList.Location = new System.Drawing.Point(40, 90);
            this.pnlList.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlList.Name = "pnlList";
            this.pnlList.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlList.Size = new System.Drawing.Size(1120, 612);
            this.pnlList.TabIndex = 13;
            // 
            // lstUsers
            // 
            this.lstUsers.ContextMenuStrip = this.menuArchive;
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUsers.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsers.GridLines = true;
            this.lstUsers.HideSelection = false;
            this.lstUsers.Location = new System.Drawing.Point(13, 12);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(4);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.ShowItemToolTips = true;
            this.lstUsers.Size = new System.Drawing.Size(1094, 588);
            this.lstUsers.TabIndex = 1;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            // 
            // menuArchive
            // 
            this.menuArchive.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuArchive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.détailToolStripMenuItem,
            this.toolStripMenuItem1,
            this.modifierToolStripMenuItem,
            this.toolStripMenuItem2,
            this.suprimerToolStripMenuItem});
            this.menuArchive.Name = "menuArchive";
            this.menuArchive.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.menuArchive.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.menuArchive.RenderStyle.ColorTable = null;
            this.menuArchive.RenderStyle.RoundedEdges = true;
            this.menuArchive.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.menuArchive.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menuArchive.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.menuArchive.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.menuArchive.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.menuArchive.Size = new System.Drawing.Size(148, 88);
            // 
            // détailToolStripMenuItem
            // 
            this.détailToolStripMenuItem.Name = "détailToolStripMenuItem";
            this.détailToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.détailToolStripMenuItem.Text = "Détail";
              // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 6);
             // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.modifierToolStripMenuItem.Text = "Modifier";
             // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 6);
             // 
            // suprimerToolStripMenuItem
            // 
            this.suprimerToolStripMenuItem.Name = "suprimerToolStripMenuItem";
            this.suprimerToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.suprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.Animated = true;
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BorderRadius = 10;
            this.btnAjouter.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnAjouter.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = global::ArchiveManagerApp.Properties.Resources.new_copy_26px;
            this.btnAjouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAjouter.Location = new System.Drawing.Point(920, 30);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(227, 43);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecherche.Animated = true;
            this.txtRecherche.AutoRoundedCorners = true;
            this.txtRecherche.BorderRadius = 20;
            this.txtRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecherche.DefaultText = "";
            this.txtRecherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRecherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRecherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecherche.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecherche.IconRight = global::ArchiveManagerApp.Properties.Resources.search_26px;
            this.txtRecherche.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtRecherche.Location = new System.Drawing.Point(53, 30);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(5);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.PlaceholderText = "Recherche...";
            this.txtRecherche.SelectedText = "";
            this.txtRecherche.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtRecherche.ShadowDecoration.Depth = 50;
            this.txtRecherche.Size = new System.Drawing.Size(857, 43);
            this.txtRecherche.TabIndex = 10;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txt_recherche_TextChanged);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // AgentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.btnAjouter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgentView";
            this.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.Size = new System.Drawing.Size(1200, 738);
            this.Load += new System.EventHandler(this.AgentView_Load);
            this.pnlList.ResumeLayout(false);
            this.menuArchive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlList;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private Guna.UI2.WinForms.Guna2TextBox txtRecherche;
        private System.Windows.Forms.ListView lstUsers;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip menuArchive;
        private System.Windows.Forms.ToolStripMenuItem détailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem suprimerToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}
