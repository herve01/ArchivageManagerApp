namespace WindowsFormsApp1
{
    partial class Main
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
            this.pnl_ruban = new System.Windows.Forms.Panel();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.txt_recherche = new System.Windows.Forms.TextBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.pnl_document = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_entete = new System.Windows.Forms.Label();
            this.btn_filtrer = new System.Windows.Forms.Button();
            this.btn_apropos = new System.Windows.Forms.Button();
            this.btn_parametre = new System.Windows.Forms.Button();
            this.btn_utilisateur = new System.Windows.Forms.Button();
            this.btn_document = new System.Windows.Forms.Button();
            this.pnl_ruban.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ruban
            // 
            this.pnl_ruban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.pnl_ruban.Controls.Add(this.btn_apropos);
            this.pnl_ruban.Controls.Add(this.btn_parametre);
            this.pnl_ruban.Controls.Add(this.btn_utilisateur);
            this.pnl_ruban.Controls.Add(this.btn_document);
            this.pnl_ruban.Controls.Add(this.lbl_entete);
            this.pnl_ruban.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ruban.Location = new System.Drawing.Point(0, 0);
            this.pnl_ruban.Name = "pnl_ruban";
            this.pnl_ruban.Size = new System.Drawing.Size(900, 30);
            this.pnl_ruban.TabIndex = 0;
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pnl_body.Controls.Add(this.pnl_document);
            this.pnl_body.Controls.Add(this.btn_filtrer);
            this.pnl_body.Controls.Add(this.btn_ajouter);
            this.pnl_body.Controls.Add(this.txt_recherche);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 30);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(900, 570);
            this.pnl_body.TabIndex = 1;
            // 
            // txt_recherche
            // 
            this.txt_recherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_recherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_recherche.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recherche.Location = new System.Drawing.Point(14, 8);
            this.txt_recherche.Margin = new System.Windows.Forms.Padding(5);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.Size = new System.Drawing.Size(568, 24);
            this.txt_recherche.TabIndex = 0;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btn_ajouter.FlatAppearance.BorderSize = 0;
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(758, 528);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(130, 30);
            this.btn_ajouter.TabIndex = 1;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            // 
            // pnl_document
            // 
            this.pnl_document.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_document.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnl_document.Location = new System.Drawing.Point(16, 42);
            this.pnl_document.Margin = new System.Windows.Forms.Padding(5);
            this.pnl_document.Name = "pnl_document";
            this.pnl_document.Size = new System.Drawing.Size(700, 520);
            this.pnl_document.TabIndex = 2;
            // 
            // lbl_entete
            // 
            this.lbl_entete.BackColor = System.Drawing.Color.Transparent;
            this.lbl_entete.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_entete.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entete.ForeColor = System.Drawing.Color.White;
            this.lbl_entete.Location = new System.Drawing.Point(0, 0);
            this.lbl_entete.Name = "lbl_entete";
            this.lbl_entete.Size = new System.Drawing.Size(200, 30);
            this.lbl_entete.TabIndex = 0;
            this.lbl_entete.Text = "Archive Manager App";
            // 
            // btn_filtrer
            // 
            this.btn_filtrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_filtrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btn_filtrer.FlatAppearance.BorderSize = 0;
            this.btn_filtrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtrer.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrer.ForeColor = System.Drawing.Color.White;
            this.btn_filtrer.Location = new System.Drawing.Point(590, 4);
            this.btn_filtrer.Name = "btn_filtrer";
            this.btn_filtrer.Size = new System.Drawing.Size(130, 30);
            this.btn_filtrer.TabIndex = 1;
            this.btn_filtrer.Text = "Filtrer";
            this.btn_filtrer.UseVisualStyleBackColor = false;
            // 
            // btn_apropos
            // 
            this.btn_apropos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_apropos.FlatAppearance.BorderSize = 0;
            this.btn_apropos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apropos.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.btn_apropos.ForeColor = System.Drawing.Color.White;
            this.btn_apropos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_apropos.Location = new System.Drawing.Point(620, 0);
            this.btn_apropos.Name = "btn_apropos";
            this.btn_apropos.Size = new System.Drawing.Size(140, 30);
            this.btn_apropos.TabIndex = 4;
            this.btn_apropos.Text = "     Apropos";
            this.btn_apropos.UseVisualStyleBackColor = true;
            // 
            // btn_parametre
            // 
            this.btn_parametre.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_parametre.FlatAppearance.BorderSize = 0;
            this.btn_parametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parametre.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.btn_parametre.ForeColor = System.Drawing.Color.White;
            this.btn_parametre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_parametre.Location = new System.Drawing.Point(480, 0);
            this.btn_parametre.Name = "btn_parametre";
            this.btn_parametre.Size = new System.Drawing.Size(140, 30);
            this.btn_parametre.TabIndex = 3;
            this.btn_parametre.Text = "      Paramètres";
            this.btn_parametre.UseVisualStyleBackColor = true;
            // 
            // btn_utilisateur
            // 
            this.btn_utilisateur.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_utilisateur.FlatAppearance.BorderSize = 0;
            this.btn_utilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_utilisateur.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.btn_utilisateur.ForeColor = System.Drawing.Color.White;
            this.btn_utilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_utilisateur.Location = new System.Drawing.Point(340, 0);
            this.btn_utilisateur.Name = "btn_utilisateur";
            this.btn_utilisateur.Size = new System.Drawing.Size(140, 30);
            this.btn_utilisateur.TabIndex = 2;
            this.btn_utilisateur.Text = "     Utilisateurs";
            this.btn_utilisateur.UseVisualStyleBackColor = true;
            // 
            // btn_document
            // 
            this.btn_document.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_document.FlatAppearance.BorderSize = 0;
            this.btn_document.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_document.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.btn_document.ForeColor = System.Drawing.Color.White;
            this.btn_document.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_document.Location = new System.Drawing.Point(200, 0);
            this.btn_document.Name = "btn_document";
            this.btn_document.Size = new System.Drawing.Size(140, 30);
            this.btn_document.TabIndex = 1;
            this.btn_document.Text = "      Documents";
            this.btn_document.UseVisualStyleBackColor = true;
            // 
            // Forme_Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_ruban);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Forme_Principale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive Manager App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_ruban.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            this.pnl_body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ruban;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.TextBox txt_recherche;
        private System.Windows.Forms.FlowLayoutPanel pnl_document;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label lbl_entete;
        private System.Windows.Forms.Button btn_document;
        private System.Windows.Forms.Button btn_apropos;
        private System.Windows.Forms.Button btn_parametre;
        private System.Windows.Forms.Button btn_utilisateur;
        private System.Windows.Forms.Button btn_filtrer;
    }
}

