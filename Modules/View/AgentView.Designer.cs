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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_document = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_filtrer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.txt_recherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.pnl_document);
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(24, 77);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Size = new System.Drawing.Size(853, 493);
            this.guna2Panel1.TabIndex = 13;
            // 
            // pnl_document
            // 
            this.pnl_document.BackColor = System.Drawing.Color.Transparent;
            this.pnl_document.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_document.Location = new System.Drawing.Point(10, 10);
            this.pnl_document.Margin = new System.Windows.Forms.Padding(5);
            this.pnl_document.Name = "pnl_document";
            this.pnl_document.Size = new System.Drawing.Size(833, 473);
            this.pnl_document.TabIndex = 5;
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
            this.btn_filtrer.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_filtrer.Image = global::ArchiveManagerApp.Properties.Resources.slider_24px;
            this.btn_filtrer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_filtrer.Location = new System.Drawing.Point(579, 24);
            this.btn_filtrer.Name = "btn_filtrer";
            this.btn_filtrer.Size = new System.Drawing.Size(100, 35);
            this.btn_filtrer.TabIndex = 11;
            this.btn_filtrer.Text = "Filtrer";
            this.btn_filtrer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btn_ajouter.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Image = global::ArchiveManagerApp.Properties.Resources.new_copy_26px;
            this.btn_ajouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ajouter.Location = new System.Drawing.Point(707, 21);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(170, 40);
            this.btn_ajouter.TabIndex = 12;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click_1);
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
            // AgentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_filtrer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txt_recherche);
            this.Name = "AgentView";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(900, 600);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel pnl_document;
        private Guna.UI2.WinForms.Guna2Button btn_filtrer;
        private Guna.UI2.WinForms.Guna2Button btn_ajouter;
        private Guna.UI2.WinForms.Guna2TextBox txt_recherche;
    }
}
