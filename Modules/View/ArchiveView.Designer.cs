namespace ArchiveManagerApp.Modules.View
{
    partial class ArchiveView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchiveView));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lstArchive = new System.Windows.Forms.ListView();
            this.menuArchive = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.détailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.suprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lst_image_grand = new System.Windows.Forms.ImageList(this.components);
            this.lst_image_petit = new System.Windows.Forms.ImageList(this.components);
            this.btn_ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.txt_recherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_filtrer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.menuArchive.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.lstArchive);
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(31, 90);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.guna2Panel1.Size = new System.Drawing.Size(1129, 612);
            this.guna2Panel1.TabIndex = 9;
            // 
            // lstArchive
            // 
            this.lstArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.lstArchive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstArchive.ContextMenuStrip = this.menuArchive;
            this.lstArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstArchive.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstArchive.FullRowSelect = true;
            this.lstArchive.GridLines = true;
            this.lstArchive.HideSelection = false;
            this.lstArchive.LargeImageList = this.lst_image_grand;
            this.lstArchive.Location = new System.Drawing.Point(13, 12);
            this.lstArchive.Margin = new System.Windows.Forms.Padding(4);
            this.lstArchive.Name = "lstArchive";
            this.lstArchive.ShowItemToolTips = true;
            this.lstArchive.Size = new System.Drawing.Size(1103, 588);
            this.lstArchive.SmallImageList = this.lst_image_petit;
            this.lstArchive.TabIndex = 1;
            this.lstArchive.UseCompatibleStateImageBehavior = false;
            this.lstArchive.View = System.Windows.Forms.View.Details;
            // 
            // menuArchive
            // 
            this.menuArchive.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            this.menuArchive.Size = new System.Drawing.Size(211, 128);
            // 
            // détailToolStripMenuItem
            // 
            this.détailToolStripMenuItem.Name = "détailToolStripMenuItem";
            this.détailToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.détailToolStripMenuItem.Text = "Détail";
            this.détailToolStripMenuItem.Click += new System.EventHandler(this.détailToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(207, 6);
            // 
            // suprimerToolStripMenuItem
            // 
            this.suprimerToolStripMenuItem.Name = "suprimerToolStripMenuItem";
            this.suprimerToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.suprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // lst_image_grand
            // 
            this.lst_image_grand.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lst_image_grand.ImageStream")));
            this.lst_image_grand.TransparentColor = System.Drawing.Color.Transparent;
            this.lst_image_grand.Images.SetKeyName(0, "pdf_480px.png");
            this.lst_image_grand.Images.SetKeyName(1, "Word File_480px.png");
            this.lst_image_grand.Images.SetKeyName(2, "image_file_480px.png");
            this.lst_image_grand.Images.SetKeyName(3, "document_480px.png");
            // 
            // lst_image_petit
            // 
            this.lst_image_petit.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lst_image_petit.ImageStream")));
            this.lst_image_petit.TransparentColor = System.Drawing.Color.Transparent;
            this.lst_image_petit.Images.SetKeyName(0, "pdf_26px.png");
            this.lst_image_petit.Images.SetKeyName(1, "doc_26px.png");
            this.lst_image_petit.Images.SetKeyName(2, "image_file_26px.png");
            this.lst_image_petit.Images.SetKeyName(3, "txt_26px.png");
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouter.Animated = true;
            this.btn_ajouter.BorderRadius = 10;
            this.btn_ajouter.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btn_ajouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ajouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ajouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Image = global::ArchiveManagerApp.Properties.Resources.new_copy_26px;
            this.btn_ajouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ajouter.Location = new System.Drawing.Point(933, 26);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(227, 49);
            this.btn_ajouter.TabIndex = 8;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // txt_recherche
            // 
            this.txt_recherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_recherche.Animated = true;
            this.txt_recherche.AutoRoundedCorners = true;
            this.txt_recherche.BorderRadius = 20;
            this.txt_recherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_recherche.DefaultText = "";
            this.txt_recherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_recherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_recherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_recherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_recherche.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_recherche.IconRight = global::ArchiveManagerApp.Properties.Resources.search_26px;
            this.txt_recherche.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txt_recherche.Location = new System.Drawing.Point(31, 30);
            this.txt_recherche.Margin = new System.Windows.Forms.Padding(5);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.PlaceholderText = "Recherche...";
            this.txt_recherche.SelectedText = "";
            this.txt_recherche.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txt_recherche.ShadowDecoration.Depth = 50;
            this.txt_recherche.Size = new System.Drawing.Size(752, 43);
            this.txt_recherche.TabIndex = 7;
            this.txt_recherche.TextChanged += new System.EventHandler(this.txt_recherche_TextChanged);
            // 
            // btn_filtrer
            // 
            this.btn_filtrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_filtrer.Animated = true;
            this.btn_filtrer.BorderRadius = 10;
            this.btn_filtrer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btn_filtrer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_filtrer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_filtrer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_filtrer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_filtrer.FillColor = System.Drawing.Color.Transparent;
            this.btn_filtrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_filtrer.Image = global::ArchiveManagerApp.Properties.Resources.slider_24px;
            this.btn_filtrer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_filtrer.Location = new System.Drawing.Point(792, 30);
            this.btn_filtrer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtrer.Name = "btn_filtrer";
            this.btn_filtrer.Size = new System.Drawing.Size(133, 43);
            this.btn_filtrer.TabIndex = 12;
            this.btn_filtrer.Text = "Filtrer";
            this.btn_filtrer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ArchiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.btn_filtrer);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txt_recherche);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ArchiveView";
            this.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.Size = new System.Drawing.Size(1200, 738);
            this.Load += new System.EventHandler(this.ArchiveView_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.menuArchive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txt_recherche;
        private Guna.UI2.WinForms.Guna2Button btn_ajouter;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_filtrer;
        private System.Windows.Forms.ImageList lst_image_grand;
        private System.Windows.Forms.ImageList lst_image_petit;
        private System.Windows.Forms.ListView lstArchive;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip menuArchive;
        private System.Windows.Forms.ToolStripMenuItem détailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem suprimerToolStripMenuItem;
    }
}
