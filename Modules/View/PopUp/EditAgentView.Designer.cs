namespace ArchiveManagerApp.Modules.View.Pop
{
    partial class EditAgentView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_ruban = new System.Windows.Forms.Panel();
            this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lbl_entete = new System.Windows.Forms.Label();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.btnNettoyer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.btnEnregistrer = new Guna.UI2.WinForms.Guna2Button();
            this.btnImporter = new Guna.UI2.WinForms.Guna2Button();
            this.picProfile = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbxService = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxSexe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFonction = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGrade = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPostnom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.bouger = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnl_ruban.SuspendLayout();
            this.pnl_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_ruban
            // 
            this.pnl_ruban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnl_ruban.Controls.Add(this.btn_close);
            this.pnl_ruban.Controls.Add(this.lbl_entete);
            this.pnl_ruban.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ruban.Location = new System.Drawing.Point(0, 0);
            this.pnl_ruban.Name = "pnl_ruban";
            this.pnl_ruban.Size = new System.Drawing.Size(564, 35);
            this.pnl_ruban.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.IconColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(514, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 35);
            this.btn_close.TabIndex = 2;
            // 
            // lbl_entete
            // 
            this.lbl_entete.BackColor = System.Drawing.Color.Transparent;
            this.lbl_entete.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_entete.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lbl_entete.ForeColor = System.Drawing.Color.White;
            this.lbl_entete.Location = new System.Drawing.Point(0, 0);
            this.lbl_entete.Name = "lbl_entete";
            this.lbl_entete.Size = new System.Drawing.Size(90, 35);
            this.lbl_entete.TabIndex = 0;
            this.lbl_entete.Text = "Edit Agent";
            this.lbl_entete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_body.Controls.Add(this.btnNettoyer);
            this.pnl_body.Controls.Add(this.btnAnnuler);
            this.pnl_body.Controls.Add(this.btnEnregistrer);
            this.pnl_body.Controls.Add(this.btnImporter);
            this.pnl_body.Controls.Add(this.picProfile);
            this.pnl_body.Controls.Add(this.cbxService);
            this.pnl_body.Controls.Add(this.cbxSexe);
            this.pnl_body.Controls.Add(this.txtFonction);
            this.pnl_body.Controls.Add(this.txtGrade);
            this.pnl_body.Controls.Add(this.txtEmail);
            this.pnl_body.Controls.Add(this.txtPhone);
            this.pnl_body.Controls.Add(this.txtPrenom);
            this.pnl_body.Controls.Add(this.txtPostnom);
            this.pnl_body.Controls.Add(this.txtNom);
            this.pnl_body.Controls.Add(this.pnl_ruban);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(1, 1);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(564, 498);
            this.pnl_body.TabIndex = 9;
            // 
            // btnNettoyer
            // 
            this.btnNettoyer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNettoyer.Animated = true;
            this.btnNettoyer.BorderRadius = 10;
            this.btnNettoyer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnNettoyer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNettoyer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNettoyer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNettoyer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNettoyer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnNettoyer.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnNettoyer.ForeColor = System.Drawing.Color.White;
            this.btnNettoyer.Image = global::ArchiveManagerApp.Properties.Resources.broom_26px;
            this.btnNettoyer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNettoyer.Location = new System.Drawing.Point(358, 300);
            this.btnNettoyer.Margin = new System.Windows.Forms.Padding(5);
            this.btnNettoyer.Name = "btnNettoyer";
            this.btnNettoyer.Size = new System.Drawing.Size(40, 40);
            this.btnNettoyer.TabIndex = 17;
            this.btnNettoyer.Click += new System.EventHandler(this.btnNettoyer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Animated = true;
            this.btnAnnuler.BorderRadius = 10;
            this.btnAnnuler.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnAnnuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnnuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnnuler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAnnuler.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Image = global::ArchiveManagerApp.Properties.Resources.cancel_26px;
            this.btnAnnuler.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAnnuler.Location = new System.Drawing.Point(357, 440);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(160, 40);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrer.Animated = true;
            this.btnEnregistrer.BorderRadius = 10;
            this.btnEnregistrer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnEnregistrer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnregistrer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnregistrer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnregistrer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnregistrer.Enabled = false;
            this.btnEnregistrer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnEnregistrer.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Image = global::ArchiveManagerApp.Properties.Resources.save_26px;
            this.btnEnregistrer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEnregistrer.Location = new System.Drawing.Point(357, 391);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(160, 40);
            this.btnEnregistrer.TabIndex = 16;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnImporter
            // 
            this.btnImporter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImporter.Animated = true;
            this.btnImporter.BorderRadius = 10;
            this.btnImporter.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnImporter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImporter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImporter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImporter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImporter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnImporter.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnImporter.ForeColor = System.Drawing.Color.White;
            this.btnImporter.Image = global::ArchiveManagerApp.Properties.Resources.download_26px;
            this.btnImporter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnImporter.Location = new System.Drawing.Point(357, 237);
            this.btnImporter.Margin = new System.Windows.Forms.Padding(5);
            this.btnImporter.Name = "btnImporter";
            this.btnImporter.Size = new System.Drawing.Size(150, 40);
            this.btnImporter.TabIndex = 14;
            this.btnImporter.Text = "Importer";
            this.btnImporter.Click += new System.EventHandler(this.btnImporter_Click);
            // 
            // picProfile
            // 
            this.picProfile.BorderRadius = 10;
            this.picProfile.ImageRotate = 0F;
            this.picProfile.Location = new System.Drawing.Point(358, 59);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(150, 170);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 13;
            this.picProfile.TabStop = false;
            // 
            // cbxService
            // 
            this.cbxService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxService.AutoRoundedCorners = true;
            this.cbxService.BackColor = System.Drawing.Color.Transparent;
            this.cbxService.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxService.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxService.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxService.Font = new System.Drawing.Font("Open Sans", 10F);
            this.cbxService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxService.ItemHeight = 30;
            this.cbxService.Items.AddRange(new object[] {
            "Service"});
            this.cbxService.Location = new System.Drawing.Point(42, 444);
            this.cbxService.Name = "cbxService";
            this.cbxService.Size = new System.Drawing.Size(300, 36);
            this.cbxService.StartIndex = 0;
            this.cbxService.TabIndex = 8;
            // 
            // cbxSexe
            // 
            this.cbxSexe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSexe.AutoRoundedCorners = true;
            this.cbxSexe.BackColor = System.Drawing.Color.Transparent;
            this.cbxSexe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSexe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSexe.Font = new System.Drawing.Font("Open Sans", 10F);
            this.cbxSexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxSexe.ItemHeight = 30;
            this.cbxSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cbxSexe.Location = new System.Drawing.Point(42, 203);
            this.cbxSexe.Name = "cbxSexe";
            this.cbxSexe.Size = new System.Drawing.Size(300, 36);
            this.cbxSexe.StartIndex = 0;
            this.cbxSexe.TabIndex = 3;
            // 
            // txtFonction
            // 
            this.txtFonction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFonction.Animated = true;
            this.txtFonction.BorderRadius = 16;
            this.txtFonction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFonction.DefaultText = "";
            this.txtFonction.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFonction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFonction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFonction.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFonction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFonction.Font = new System.Drawing.Font("Open Sans", 10F);
            this.txtFonction.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFonction.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtFonction.Location = new System.Drawing.Point(42, 396);
            this.txtFonction.Margin = new System.Windows.Forms.Padding(4);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.PlaceholderText = "Fonction";
            this.txtFonction.SelectedText = "";
            this.txtFonction.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtFonction.ShadowDecoration.Depth = 50;
            this.txtFonction.Size = new System.Drawing.Size(300, 35);
            this.txtFonction.TabIndex = 7;
            // 
            // txtGrade
            // 
            this.txtGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrade.Animated = true;
            this.txtGrade.BorderRadius = 16;
            this.txtGrade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrade.DefaultText = "";
            this.txtGrade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrade.Font = new System.Drawing.Font("Open Sans", 10F);
            this.txtGrade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrade.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtGrade.Location = new System.Drawing.Point(42, 348);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.PlaceholderText = "Grade";
            this.txtGrade.SelectedText = "";
            this.txtGrade.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtGrade.ShadowDecoration.Depth = 50;
            this.txtGrade.Size = new System.Drawing.Size(300, 35);
            this.txtGrade.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Animated = true;
            this.txtEmail.BorderRadius = 16;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Open Sans", 10F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtEmail.Location = new System.Drawing.Point(42, 300);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Mail";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtEmail.ShadowDecoration.Depth = 50;
            this.txtEmail.Size = new System.Drawing.Size(300, 35);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Animated = true;
            this.txtPhone.BorderRadius = 16;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Open Sans", 10F);
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtPhone.Location = new System.Drawing.Point(42, 252);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "Téléphone";
            this.txtPhone.SelectedText = "";
            this.txtPhone.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtPhone.ShadowDecoration.Depth = 50;
            this.txtPhone.Size = new System.Drawing.Size(300, 35);
            this.txtPhone.TabIndex = 4;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrenom.Animated = true;
            this.txtPrenom.BorderRadius = 16;
            this.txtPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrenom.DefaultText = "";
            this.txtPrenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrenom.Font = new System.Drawing.Font("Open Sans", 10F);
            this.txtPrenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrenom.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtPrenom.Location = new System.Drawing.Point(42, 155);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PlaceholderText = "Prenom";
            this.txtPrenom.SelectedText = "";
            this.txtPrenom.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtPrenom.ShadowDecoration.Depth = 50;
            this.txtPrenom.Size = new System.Drawing.Size(300, 35);
            this.txtPrenom.TabIndex = 2;
            // 
            // txtPostnom
            // 
            this.txtPostnom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPostnom.Animated = true;
            this.txtPostnom.BorderRadius = 16;
            this.txtPostnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostnom.DefaultText = "";
            this.txtPostnom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPostnom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPostnom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPostnom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPostnom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPostnom.Font = new System.Drawing.Font("Open Sans", 10F);
            this.txtPostnom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPostnom.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtPostnom.Location = new System.Drawing.Point(42, 107);
            this.txtPostnom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostnom.Name = "txtPostnom";
            this.txtPostnom.PlaceholderText = "Postnom";
            this.txtPostnom.SelectedText = "";
            this.txtPostnom.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtPostnom.ShadowDecoration.Depth = 50;
            this.txtPostnom.Size = new System.Drawing.Size(300, 35);
            this.txtPostnom.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNom.Animated = true;
            this.txtNom.BorderRadius = 16;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.DefaultText = "";
            this.txtNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.Font = new System.Drawing.Font("Open Sans", 10F);
            this.txtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtNom.Location = new System.Drawing.Point(42, 59);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.PlaceholderText = "Nom";
            this.txtNom.SelectedText = "";
            this.txtNom.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtNom.ShadowDecoration.Depth = 50;
            this.txtNom.Size = new System.Drawing.Size(300, 35);
            this.txtNom.TabIndex = 0;
            // 
            // bouger
            // 
            this.bouger.DockIndicatorColor = System.Drawing.Color.IndianRed;
            this.bouger.DockIndicatorTransparencyValue = 0.6D;
            this.bouger.TargetControl = this.pnl_ruban;
            this.bouger.UseTransparentDrag = true;
            // 
            // EditAgentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(566, 500);
            this.Controls.Add(this.pnl_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditAgentView";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopArchive";
            this.Load += new System.EventHandler(this.EditAgentView_Load);
            this.pnl_ruban.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ruban;
        private System.Windows.Forms.Label lbl_entete;
        private System.Windows.Forms.Panel pnl_body;
        private Guna.UI2.WinForms.Guna2DragControl bouger;
        private Guna.UI2.WinForms.Guna2TextBox txtFonction;
        private Guna.UI2.WinForms.Guna2TextBox txtGrade;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtPrenom;
        private Guna.UI2.WinForms.Guna2TextBox txtPostnom;
        private Guna.UI2.WinForms.Guna2TextBox txtNom;
        private Guna.UI2.WinForms.Guna2PictureBox picProfile;
        private Guna.UI2.WinForms.Guna2ComboBox cbxSexe;
        private Guna.UI2.WinForms.Guna2Button btnImporter;
        private Guna.UI2.WinForms.Guna2Button btnAnnuler;
        private Guna.UI2.WinForms.Guna2Button btnEnregistrer;
        private Guna.UI2.WinForms.Guna2ComboBox cbxService;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private Guna.UI2.WinForms.Guna2Button btnNettoyer;
    }
}