namespace ArchiveManagerApp.Modules.View
{
    partial class ParametreUserView
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
            this.pnlListes = new Guna.UI2.WinForms.Guna2Panel();
            this.lstUsers = new System.Windows.Forms.ListView();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.txtRecherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlEdit = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxAgent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPassword2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombreService = new System.Windows.Forms.Label();
            this.pnlListes.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlListes
            // 
            this.pnlListes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListes.BackColor = System.Drawing.Color.Transparent;
            this.pnlListes.BorderRadius = 10;
            this.pnlListes.Controls.Add(this.lstUsers);
            this.pnlListes.FillColor = System.Drawing.Color.Transparent;
            this.pnlListes.Location = new System.Drawing.Point(412, 63);
            this.pnlListes.Margin = new System.Windows.Forms.Padding(10);
            this.pnlListes.Name = "pnlListes";
            this.pnlListes.Padding = new System.Windows.Forms.Padding(10);
            this.pnlListes.Size = new System.Drawing.Size(468, 517);
            this.pnlListes.TabIndex = 17;
            // 
            // lstUsers
            // 
            this.lstUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUsers.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lstUsers.GridLines = true;
            this.lstUsers.HideSelection = false;
            this.lstUsers.Location = new System.Drawing.Point(10, 10);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.ShowItemToolTips = true;
            this.lstUsers.Size = new System.Drawing.Size(448, 497);
            this.lstUsers.TabIndex = 1;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
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
            this.btnAjouter.Enabled = false;
            this.btnAjouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnAjouter.Font = new System.Drawing.Font("Open Sans", 11F);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = global::ArchiveManagerApp.Properties.Resources.new_copy_26px;
            this.btnAjouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAjouter.Location = new System.Drawing.Point(212, 423);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(170, 40);
            this.btnAjouter.TabIndex = 16;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecherche.Animated = true;
            this.txtRecherche.AutoRoundedCorners = true;
            this.txtRecherche.BorderRadius = 16;
            this.txtRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecherche.DefaultText = "";
            this.txtRecherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRecherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRecherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecherche.Font = new System.Drawing.Font("Open Sans", 11F);
            this.txtRecherche.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecherche.IconRight = global::ArchiveManagerApp.Properties.Resources.search_26px;
            this.txtRecherche.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtRecherche.Location = new System.Drawing.Point(490, 14);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.PlaceholderText = "Recherche...";
            this.txtRecherche.SelectedText = "";
            this.txtRecherche.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtRecherche.ShadowDecoration.Depth = 50;
            this.txtRecherche.Size = new System.Drawing.Size(380, 35);
            this.txtRecherche.TabIndex = 14;
            // 
            // pnlEdit
            // 
            this.pnlEdit.BorderRadius = 10;
            this.pnlEdit.Controls.Add(this.btnAnnuler);
            this.pnlEdit.Controls.Add(this.label5);
            this.pnlEdit.Controls.Add(this.label3);
            this.pnlEdit.Controls.Add(this.btnAjouter);
            this.pnlEdit.Controls.Add(this.label2);
            this.pnlEdit.Controls.Add(this.label4);
            this.pnlEdit.Controls.Add(this.label1);
            this.pnlEdit.Controls.Add(this.cbxRole);
            this.pnlEdit.Controls.Add(this.cbxAgent);
            this.pnlEdit.Controls.Add(this.txtPassword2);
            this.pnlEdit.Controls.Add(this.txtPassword1);
            this.pnlEdit.Controls.Add(this.txtUser);
            this.pnlEdit.FillColor = System.Drawing.Color.Transparent;
            this.pnlEdit.Location = new System.Drawing.Point(13, 63);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Padding = new System.Windows.Forms.Padding(5);
            this.pnlEdit.Size = new System.Drawing.Size(390, 480);
            this.pnlEdit.TabIndex = 18;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Animated = true;
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.BorderRadius = 10;
            this.btnAnnuler.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnAnnuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnnuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnnuler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAnnuler.Font = new System.Drawing.Font("Open Sans", 11F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Image = global::ArchiveManagerApp.Properties.Resources.cancel_26px;
            this.btnAnnuler.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAnnuler.Location = new System.Drawing.Point(14, 423);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(160, 40);
            this.btnAnnuler.TabIndex = 18;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(24, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Confirmer Mot de Passe *";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label3.Location = new System.Drawing.Point(24, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mot de Passe *";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nom Utilisateur *";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label4.Location = new System.Drawing.Point(24, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rôle *";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Agent *";
            // 
            // cbxRole
            // 
            this.cbxRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxRole.AutoRoundedCorners = true;
            this.cbxRole.BackColor = System.Drawing.Color.Transparent;
            this.cbxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxRole.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxRole.ItemHeight = 30;
            this.cbxRole.Items.AddRange(new object[] {
            "Administrateur",
            "Utilisateur"});
            this.cbxRole.Location = new System.Drawing.Point(24, 362);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(330, 36);
            this.cbxRole.StartIndex = 0;
            this.cbxRole.TabIndex = 4;
            // 
            // cbxAgent
            // 
            this.cbxAgent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxAgent.AutoRoundedCorners = true;
            this.cbxAgent.BackColor = System.Drawing.Color.Transparent;
            this.cbxAgent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAgent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxAgent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxAgent.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxAgent.ItemHeight = 30;
            this.cbxAgent.Items.AddRange(new object[] {
            "Nom PostNom Prénom"});
            this.cbxAgent.Location = new System.Drawing.Point(24, 54);
            this.cbxAgent.Name = "cbxAgent";
            this.cbxAgent.Size = new System.Drawing.Size(330, 36);
            this.cbxAgent.StartIndex = 0;
            this.cbxAgent.TabIndex = 0;
            this.cbxAgent.DropDown += new System.EventHandler(this.cbxAgent_DropDown);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword2.Animated = true;
            this.txtPassword2.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword2.BorderRadius = 16;
            this.txtPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword2.DefaultText = "";
            this.txtPassword2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword2.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword2.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtPassword2.Location = new System.Drawing.Point(24, 285);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PlaceholderText = "Mot de passe";
            this.txtPassword2.SelectedText = "";
            this.txtPassword2.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtPassword2.ShadowDecoration.Depth = 50;
            this.txtPassword2.Size = new System.Drawing.Size(330, 36);
            this.txtPassword2.TabIndex = 3;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword1.Animated = true;
            this.txtPassword1.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword1.BorderRadius = 16;
            this.txtPassword1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword1.DefaultText = "";
            this.txtPassword1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword1.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword1.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtPassword1.Location = new System.Drawing.Point(24, 208);
            this.txtPassword1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PlaceholderText = "Mot de passe";
            this.txtPassword1.SelectedText = "";
            this.txtPassword1.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtPassword1.ShadowDecoration.Depth = 50;
            this.txtPassword1.Size = new System.Drawing.Size(330, 36);
            this.txtPassword1.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Animated = true;
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BorderRadius = 16;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtUser.Location = new System.Drawing.Point(24, 131);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Nom utilisateur";
            this.txtUser.SelectedText = "";
            this.txtUser.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtUser.ShadowDecoration.Depth = 50;
            this.txtUser.Size = new System.Drawing.Size(330, 36);
            this.txtUser.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label6.Location = new System.Drawing.Point(417, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreService
            // 
            this.lblNombreService.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblNombreService.Location = new System.Drawing.Point(417, 21);
            this.lblNombreService.Name = "lblNombreService";
            this.lblNombreService.Size = new System.Drawing.Size(60, 32);
            this.lblNombreService.TabIndex = 20;
            this.lblNombreService.Text = "00";
            this.lblNombreService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ParametreUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNombreService);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlListes);
            this.Controls.Add(this.txtRecherche);
            this.Name = "ParametreUserView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.ParametreUserView_Load);
            this.pnlListes.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlListes;
        private System.Windows.Forms.ListView lstUsers;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private Guna.UI2.WinForms.Guna2TextBox txtRecherche;
        private Guna.UI2.WinForms.Guna2Panel pnlEdit;
        private Guna.UI2.WinForms.Guna2Button btnAnnuler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxRole;
        private Guna.UI2.WinForms.Guna2ComboBox cbxAgent;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword1;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNombreService;
    }
}
