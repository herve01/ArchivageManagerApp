namespace ArchiveManagerApp.Modules.View
{
    partial class DashBordView
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picCover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tdbServices = new ArchiveManagerApp.Modules.View.Controls.ElementTDB();
            this.tdbAgents = new ArchiveManagerApp.Modules.View.Controls.ElementTDB();
            this.tdbArchives = new ArchiveManagerApp.Modules.View.Controls.ElementTDB();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lbl_title.Location = new System.Drawing.Point(62, 77);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(301, 42);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Archive Manager App";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picCover
            // 
            this.picCover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCover.Image = global::ArchiveManagerApp.Properties.Resources._5130169;
            this.picCover.ImageRotate = 0F;
            this.picCover.Location = new System.Drawing.Point(68, 84);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(550, 463);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCover.TabIndex = 2;
            this.picCover.TabStop = false;
            // 
            // tdbServices
            // 
            this.tdbServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tdbServices.BackColor = System.Drawing.Color.LightGray;
            this.tdbServices.Location = new System.Drawing.Point(624, 409);
            this.tdbServices.Name = "tdbServices";
            this.tdbServices.Number = "04";
            this.tdbServices.Padding = new System.Windows.Forms.Padding(10);
            this.tdbServices.Size = new System.Drawing.Size(200, 160);
            this.tdbServices.TabIndex = 5;
            this.tdbServices.Title = "Services";
            // 
            // tdbAgents
            // 
            this.tdbAgents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tdbAgents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tdbAgents.ForeColor = System.Drawing.Color.White;
            this.tdbAgents.Location = new System.Drawing.Point(624, 243);
            this.tdbAgents.Name = "tdbAgents";
            this.tdbAgents.Number = "23";
            this.tdbAgents.Padding = new System.Windows.Forms.Padding(10);
            this.tdbAgents.Size = new System.Drawing.Size(200, 160);
            this.tdbAgents.TabIndex = 4;
            this.tdbAgents.Title = "Agents";
            // 
            // tdbArchives
            // 
            this.tdbArchives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tdbArchives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.tdbArchives.ForeColor = System.Drawing.Color.White;
            this.tdbArchives.Location = new System.Drawing.Point(624, 77);
            this.tdbArchives.Name = "tdbArchives";
            this.tdbArchives.Number = "130";
            this.tdbArchives.Padding = new System.Windows.Forms.Padding(10);
            this.tdbArchives.Size = new System.Drawing.Size(200, 160);
            this.tdbArchives.TabIndex = 3;
            this.tdbArchives.Title = "Archives";
            // 
            // DashBordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tdbServices);
            this.Controls.Add(this.tdbAgents);
            this.Controls.Add(this.tdbArchives);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCover);
            this.Name = "DashBordView";
            this.Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox picCover;
        private Controls.ElementTDB tdbArchives;
        private Controls.ElementTDB tdbAgents;
        private Controls.ElementTDB tdbServices;
    }
}
