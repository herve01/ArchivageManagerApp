namespace ArchiveManagerApp.Modules.View
{
    partial class ParametreView
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
            this.lbl_entete = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnServeur = new Guna.UI2.WinForms.Guna2Button();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_entete
            // 
            this.lbl_entete.BackColor = System.Drawing.Color.Transparent;
            this.lbl_entete.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_entete.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entete.ForeColor = System.Drawing.Color.White;
            this.lbl_entete.Location = new System.Drawing.Point(10, 0);
            this.lbl_entete.Name = "lbl_entete";
            this.lbl_entete.Size = new System.Drawing.Size(170, 70);
            this.lbl_entete.TabIndex = 2;
            this.lbl_entete.Text = "Paramètres";
            this.lbl_entete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_menu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.btnServeur);
            this.pnlMenu.Controls.Add(this.btnUser);
            this.pnlMenu.Controls.Add(this.lbl_entete);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnl_menu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.pnlMenu.Size = new System.Drawing.Size(190, 600);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnServeur
            // 
            this.btnServeur.Animated = true;
            this.btnServeur.BorderRadius = 5;
            this.btnServeur.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnServeur.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServeur.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServeur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServeur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServeur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServeur.FillColor = System.Drawing.Color.Transparent;
            this.btnServeur.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServeur.ForeColor = System.Drawing.Color.White;
            this.btnServeur.Image = global::ArchiveManagerApp.Properties.Resources.database_administrator_26px;
            this.btnServeur.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnServeur.Location = new System.Drawing.Point(10, 115);
            this.btnServeur.Name = "btnServeur";
            this.btnServeur.Size = new System.Drawing.Size(170, 45);
            this.btnServeur.TabIndex = 8;
            this.btnServeur.Text = "Serveur";
            this.btnServeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnServeur.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnCompte
            // 
            this.btnUser.Animated = true;
            this.btnUser.BorderRadius = 5;
            this.btnUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FillColor = System.Drawing.Color.Transparent;
            this.btnUser.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::ArchiveManagerApp.Properties.Resources.male_user_26px;
            this.btnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.Location = new System.Drawing.Point(10, 70);
            this.btnUser.Name = "btnCompte";
            this.btnUser.Size = new System.Drawing.Size(170, 45);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "Comptes";
            this.btnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(190, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(710, 600);
            this.pnlBody.TabIndex = 4;
            // 
            // ParametreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlMenu);
            this.Name = "ParametreView";
            this.Size = new System.Drawing.Size(900, 600);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_entete;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btnServeur;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private System.Windows.Forms.Panel pnlBody;
    }
}
