namespace ArchiveManagerApp.Modules.View.PopUp
{
    partial class DocumentView
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
            this.bouger = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.btnArchiver = new Guna.UI2.WinForms.Guna2Button();
            this.lstDetails = new System.Windows.Forms.ListView();
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
            this.lbl_entete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
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
            this.pnl_body.Controls.Add(this.lstDetails);
            this.pnl_body.Controls.Add(this.pnlDocument);
            this.pnl_body.Controls.Add(this.lblDate);
            this.pnl_body.Controls.Add(this.lblTaille);
            this.pnl_body.Controls.Add(this.label5);
            this.pnl_body.Controls.Add(this.label2);
            this.pnl_body.Controls.Add(this.lblType);
            this.pnl_body.Controls.Add(this.label1);
            this.pnl_body.Controls.Add(this.btnAnnuler);
            this.pnl_body.Controls.Add(this.btnArchiver);
            this.pnl_body.Controls.Add(this.pnl_ruban);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(1, 1);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(1031, 638);
            this.pnl_body.TabIndex = 9;
            this.pnl_body.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_body_Paint);
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
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblDate.Location = new System.Drawing.Point(823, 404);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(190, 23);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "10/12/2023";
            // 
            // lblTaille
            // 
            this.lblTaille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTaille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblTaille.Location = new System.Drawing.Point(823, 369);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(190, 23);
            this.lblTaille.TabIndex = 11;
            this.lblTaille.Text = "0.0 ko";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(712, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(712, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Taille";
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblType.Location = new System.Drawing.Point(823, 334);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(190, 23);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type Fichier";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(712, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type";
            // 
            // bouger
            // 
            this.bouger.DockIndicatorColor = System.Drawing.Color.IndianRed;
            this.bouger.DockIndicatorTransparencyValue = 0.6D;
            this.bouger.TargetControl = this.pnl_ruban;
            this.bouger.UseTransparentDrag = true;
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
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
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
            this.btnArchiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
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
            // lstServices
            // 
            this.lstDetails.BackColor = System.Drawing.SystemColors.Control;
            this.lstDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstDetails.GridLines = true;
            this.lstDetails.HideSelection = false;
            this.lstDetails.Location = new System.Drawing.Point(691, 48);
            this.lstDetails.Name = "lstServices";
            this.lstDetails.ShowItemToolTips = true;
            this.lstDetails.Size = new System.Drawing.Size(330, 242);
            this.lstDetails.TabIndex = 13;
            this.lstDetails.UseCompatibleStateImageBehavior = false;
            this.lstDetails.View = System.Windows.Forms.View.Details;
            // 
            // DocumentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1033, 640);
            this.Controls.Add(this.pnl_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocumentView";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblType;
        private Guna.UI2.WinForms.Guna2Panel pnlDocument;
        private Guna.UI2.WinForms.Guna2DragControl bouger;
        private System.Windows.Forms.ListView lstDetails;
    }
}