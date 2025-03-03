namespace ArchiveManagerApp.Modules.View
{
    partial class ParametreServerView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataBase = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTestConnection = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_entete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(63, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Serveur";
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Animated = true;
            this.txtServer.BorderRadius = 16;
            this.txtServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServer.DefaultText = "127.0.0.1";
            this.txtServer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtServer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServer.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtServer.Location = new System.Drawing.Point(55, 95);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServer.Name = "txtServer";
            this.txtServer.PlaceholderText = "Adresse IP";
            this.txtServer.ReadOnly = true;
            this.txtServer.SelectedText = "";
            this.txtServer.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtServer.ShadowDecoration.Depth = 50;
            this.txtServer.Size = new System.Drawing.Size(520, 35);
            this.txtServer.TabIndex = 12;
            // 
            // txtPort
            // 
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPort.Animated = true;
            this.txtPort.BorderRadius = 16;
            this.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPort.DefaultText = "3306";
            this.txtPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPort.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtPort.Location = new System.Drawing.Point(55, 173);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.PlaceholderText = "Port";
            this.txtPort.ReadOnly = true;
            this.txtPort.SelectedText = "";
            this.txtPort.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtPort.ShadowDecoration.Depth = 50;
            this.txtPort.Size = new System.Drawing.Size(520, 35);
            this.txtPort.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(63, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Port";
            // 
            // txtDataBase
            // 
            this.txtDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataBase.Animated = true;
            this.txtDataBase.BorderRadius = 16;
            this.txtDataBase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDataBase.DefaultText = "gestion_archivage_db";
            this.txtDataBase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDataBase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDataBase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDataBase.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDataBase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDataBase.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDataBase.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtDataBase.Location = new System.Drawing.Point(55, 407);
            this.txtDataBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.PlaceholderText = "Source des données";
            this.txtDataBase.ReadOnly = true;
            this.txtDataBase.SelectedText = "";
            this.txtDataBase.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtDataBase.ShadowDecoration.Depth = 50;
            this.txtDataBase.Size = new System.Drawing.Size(520, 35);
            this.txtDataBase.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label3.Location = new System.Drawing.Point(63, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Source des Données";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Animated = true;
            this.txtUser.BorderRadius = 16;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "root";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtUser.Location = new System.Drawing.Point(55, 251);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Utilisateur";
            this.txtUser.ReadOnly = true;
            this.txtUser.SelectedText = "";
            this.txtUser.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtUser.ShadowDecoration.Depth = 50;
            this.txtUser.Size = new System.Drawing.Size(520, 35);
            this.txtUser.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label4.Location = new System.Drawing.Point(63, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Utilisateur";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(63, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mot de passe";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassWord.Animated = true;
            this.txtPassWord.BorderRadius = 16;
            this.txtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord.DefaultText = "hunterxhunterA1";
            this.txtPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.IconRight = global::ArchiveManagerApp.Properties.Resources.eye_26px;
            this.txtPassWord.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtPassWord.Location = new System.Drawing.Point(55, 329);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PlaceholderText = "Mot de passe";
            this.txtPassWord.ReadOnly = true;
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtPassWord.ShadowDecoration.Depth = 50;
            this.txtPassWord.Size = new System.Drawing.Size(520, 35);
            this.txtPassWord.TabIndex = 12;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestConnection.Animated = true;
            this.btnTestConnection.BorderRadius = 10;
            this.btnTestConnection.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnTestConnection.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTestConnection.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTestConnection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTestConnection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTestConnection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnTestConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTestConnection.ForeColor = System.Drawing.Color.White;
            this.btnTestConnection.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTestConnection.Location = new System.Drawing.Point(249, 555);
            this.btnTestConnection.Margin = new System.Windows.Forms.Padding(5);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(221, 40);
            this.btnTestConnection.TabIndex = 10;
            this.btnTestConnection.Text = "Tester la connection";
            this.btnTestConnection.Visible = false;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Animated = true;
            this.btnAnnuler.BorderRadius = 10;
            this.btnAnnuler.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnAnnuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnnuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnnuler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAnnuler.Location = new System.Drawing.Point(565, 555);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(160, 40);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Animated = true;
            this.btnModifier.BorderRadius = 10;
            this.btnModifier.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnModifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnModifier.Location = new System.Drawing.Point(735, 555);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(160, 40);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lbl_entete
            // 
            this.lbl_entete.BackColor = System.Drawing.Color.Transparent;
            this.lbl_entete.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_entete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_entete.ForeColor = System.Drawing.Color.Gray;
            this.lbl_entete.Location = new System.Drawing.Point(0, 0);
            this.lbl_entete.Name = "lbl_entete";
            this.lbl_entete.Size = new System.Drawing.Size(900, 31);
            this.lbl_entete.TabIndex = 14;
            this.lbl_entete.Text = "Configuration Serveur";
            this.lbl_entete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ParametreServerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_entete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtDataBase);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Name = "ParametreServerView";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAnnuler;
        private Guna.UI2.WinForms.Guna2Button btnModifier;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtServer;
        private Guna.UI2.WinForms.Guna2TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtDataBase;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPassWord;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnTestConnection;
        private System.Windows.Forms.Label lbl_entete;
    }
}
