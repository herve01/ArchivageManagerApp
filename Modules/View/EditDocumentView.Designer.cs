using System;

namespace ArchiveManagerApp.Modules.View.Pop
{
    partial class EditDocumentView
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
            this.lbl_entete = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnlDocument = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTaille = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotCle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLibelle = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNettoyer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.btnImporter = new Guna.UI2.WinForms.Guna2Button();
            this.btnArchiver = new Guna.UI2.WinForms.Guna2Button();
            this.bouger = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnl_ruban.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ruban
            // 
            this.pnl_ruban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnl_ruban.Controls.Add(this.lbl_entete);
            this.pnl_ruban.Controls.Add(this.btn_close);
            this.pnl_ruban.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ruban.Location = new System.Drawing.Point(0, 0);
            this.pnl_ruban.Name = "pnl_ruban";
            this.pnl_ruban.Size = new System.Drawing.Size(1031, 35);
            this.pnl_ruban.TabIndex = 1;
            // 
            // lbl_entete
            // 
            this.lbl_entete.BackColor = System.Drawing.Color.Transparent;
            this.lbl_entete.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_entete.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lbl_entete.ForeColor = System.Drawing.Color.White;
            this.lbl_entete.Location = new System.Drawing.Point(0, 0);
            this.lbl_entete.Name = "lbl_entete";
            this.lbl_entete.Size = new System.Drawing.Size(180, 35);
            this.lbl_entete.TabIndex = 0;
            this.lbl_entete.Text = "Archive - Agent";
            this.lbl_entete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.IconColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(981, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 35);
            this.btn_close.TabIndex = 1;
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_body.Controls.Add(this.pnlDocument);
            this.pnl_body.Controls.Add(this.lblDate);
            this.pnl_body.Controls.Add(this.lblTaille);
            this.pnl_body.Controls.Add(this.label5);
            this.pnl_body.Controls.Add(this.label2);
            this.pnl_body.Controls.Add(this.lblType);
            this.pnl_body.Controls.Add(this.label1);
            this.pnl_body.Controls.Add(this.txtMotCle);
            this.pnl_body.Controls.Add(this.txtLibelle);
            this.pnl_body.Controls.Add(this.btnNettoyer);
            this.pnl_body.Controls.Add(this.btnAnnuler);
            this.pnl_body.Controls.Add(this.btnImporter);
            this.pnl_body.Controls.Add(this.btnArchiver);
            this.pnl_body.Controls.Add(this.pnl_ruban);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(1, 1);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(1031, 638);
            this.pnl_body.TabIndex = 9;
            // 
            // pnlDocument
            // 
            this.pnlDocument.BackColor = System.Drawing.Color.Transparent;
            this.pnlDocument.BorderRadius = 10;
            this.pnlDocument.Location = new System.Drawing.Point(13, 48);
            this.pnlDocument.Name = "pnlDocument";
            this.pnlDocument.Size = new System.Drawing.Size(670, 580);
            this.pnlDocument.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblDate.Location = new System.Drawing.Point(831, 312);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(190, 23);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "10/12/2023";
            // 
            // lblTaille
            // 
            this.lblTaille.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblTaille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblTaille.Location = new System.Drawing.Point(831, 277);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(190, 23);
            this.lblTaille.TabIndex = 11;
            this.lblTaille.Text = "0.0 ko";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(720, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(720, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Taille";
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblType.Location = new System.Drawing.Point(831, 242);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(190, 23);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type Fichier";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(720, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type";
            // 
            // txtMotCle
            // 
            this.txtMotCle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMotCle.Animated = true;
            this.txtMotCle.BorderRadius = 16;
            this.txtMotCle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotCle.DefaultText = "";
            this.txtMotCle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMotCle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMotCle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotCle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotCle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotCle.Font = new System.Drawing.Font("Open Sans", 12F);
            this.txtMotCle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotCle.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtMotCle.Location = new System.Drawing.Point(691, 180);
            this.txtMotCle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMotCle.Name = "txtMotCle";
            this.txtMotCle.PlaceholderText = "Mot clé";
            this.txtMotCle.SelectedText = "";
            this.txtMotCle.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtMotCle.ShadowDecoration.Depth = 50;
            this.txtMotCle.Size = new System.Drawing.Size(330, 35);
            this.txtMotCle.TabIndex = 10;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLibelle.Animated = true;
            this.txtLibelle.BorderRadius = 16;
            this.txtLibelle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLibelle.DefaultText = "";
            this.txtLibelle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLibelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLibelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLibelle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLibelle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLibelle.Font = new System.Drawing.Font("Open Sans", 12F);
            this.txtLibelle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLibelle.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtLibelle.Location = new System.Drawing.Point(691, 102);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLibelle.Multiline = true;
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.PlaceholderText = "Libellé";
            this.txtLibelle.SelectedText = "";
            this.txtLibelle.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.txtLibelle.ShadowDecoration.Depth = 50;
            this.txtLibelle.Size = new System.Drawing.Size(330, 70);
            this.txtLibelle.TabIndex = 10;
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
            this.btnNettoyer.Location = new System.Drawing.Point(981, 48);
            this.btnNettoyer.Margin = new System.Windows.Forms.Padding(5);
            this.btnNettoyer.Name = "btnNettoyer";
            this.btnNettoyer.Size = new System.Drawing.Size(40, 40);
            this.btnNettoyer.TabIndex = 9;
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
            this.btnAnnuler.Location = new System.Drawing.Point(691, 588);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(160, 40);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
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
            this.btnImporter.Location = new System.Drawing.Point(691, 48);
            this.btnImporter.Margin = new System.Windows.Forms.Padding(5);
            this.btnImporter.Name = "btnImporter";
            this.btnImporter.Size = new System.Drawing.Size(280, 40);
            this.btnImporter.TabIndex = 9;
            this.btnImporter.Text = "Importer un document";
            this.btnImporter.Click += new System.EventHandler(this.btnImporter_Click);
            // 
            // btnArchiver
            // 
            this.btnArchiver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArchiver.Animated = true;
            this.btnArchiver.BorderRadius = 10;
            this.btnArchiver.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnArchiver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnArchiver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnArchiver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnArchiver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnArchiver.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnArchiver.Font = new System.Drawing.Font("Open Sans", 12F);
            this.btnArchiver.ForeColor = System.Drawing.Color.White;
            this.btnArchiver.Image = global::ArchiveManagerApp.Properties.Resources.save_26px;
            this.btnArchiver.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnArchiver.Location = new System.Drawing.Point(861, 588);
            this.btnArchiver.Margin = new System.Windows.Forms.Padding(5);
            this.btnArchiver.Name = "btnArchiver";
            this.btnArchiver.Size = new System.Drawing.Size(160, 40);
            this.btnArchiver.TabIndex = 9;
            this.btnArchiver.Text = "Archiver";
            // 
            // bouger
            // 
            this.bouger.DockIndicatorColor = System.Drawing.Color.IndianRed;
            this.bouger.DockIndicatorTransparencyValue = 0.6D;
            this.bouger.TargetControl = this.pnl_ruban;
            this.bouger.UseTransparentDrag = true;
            // 
            // EditDocumentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1033, 640);
            this.Controls.Add(this.pnl_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditDocumentView";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopArchive";
            this.pnl_ruban.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ruban;
        private System.Windows.Forms.Label lbl_entete;
        private System.Windows.Forms.Panel pnl_body;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private Guna.UI2.WinForms.Guna2Button btnAnnuler;
        private Guna.UI2.WinForms.Guna2Button btnArchiver;
        private Guna.UI2.WinForms.Guna2Button btnNettoyer;
        private Guna.UI2.WinForms.Guna2Button btnImporter;
        private Guna.UI2.WinForms.Guna2TextBox txtLibelle;
        private Guna.UI2.WinForms.Guna2TextBox txtMotCle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblType;
        private Guna.UI2.WinForms.Guna2Panel pnlDocument;
        private Guna.UI2.WinForms.Guna2DragControl bouger;
    }
}