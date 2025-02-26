using System;

namespace ArchiveManagerApp.Modules.View.Pop
{
    partial class PopArchive
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
            this.pnl_ruban = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_entete = new System.Windows.Forms.Label();
            this.btn_impoter = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.txt_libelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mot_cle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_archiver = new System.Windows.Forms.Button();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_pdf = new System.Windows.Forms.Panel();
            this.btn_nettoyer = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.pnl_ruban.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ruban
            // 
            this.pnl_ruban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.pnl_ruban.Controls.Add(this.btn_close);
            this.pnl_ruban.Controls.Add(this.lbl_entete);
            this.pnl_ruban.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ruban.Location = new System.Drawing.Point(0, 0);
            this.pnl_ruban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_ruban.Name = "pnl_ruban";
            this.pnl_ruban.Size = new System.Drawing.Size(1375, 37);
            this.pnl_ruban.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1336, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(39, 37);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_entete
            // 
            this.lbl_entete.AutoSize = true;
            this.lbl_entete.BackColor = System.Drawing.Color.Transparent;
            this.lbl_entete.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_entete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_entete.ForeColor = System.Drawing.Color.White;
            this.lbl_entete.Location = new System.Drawing.Point(0, 0);
            this.lbl_entete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_entete.Name = "lbl_entete";
            this.lbl_entete.Size = new System.Drawing.Size(174, 29);
            this.lbl_entete.TabIndex = 0;
            this.lbl_entete.Text = "Ajouter Archive";
            // 
            // btn_impoter
            // 
            this.btn_impoter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_impoter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.btn_impoter.FlatAppearance.BorderSize = 0;
            this.btn_impoter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_impoter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_impoter.ForeColor = System.Drawing.Color.White;
            this.btn_impoter.Location = new System.Drawing.Point(16, 44);
            this.btn_impoter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_impoter.Name = "btn_impoter";
            this.btn_impoter.Size = new System.Drawing.Size(405, 37);
            this.btn_impoter.TabIndex = 5;
            this.btn_impoter.Text = "Importer un document";
            this.btn_impoter.UseVisualStyleBackColor = false;
            this.btn_impoter.Click += new System.EventHandler(this.btn_impoter_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.btn_annuler.FlatAppearance.BorderSize = 0;
            this.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.ForeColor = System.Drawing.Color.White;
            this.btn_annuler.Location = new System.Drawing.Point(953, 798);
            this.btn_annuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(200, 49);
            this.btn_annuler.TabIndex = 5;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            // 
            // txt_libelle
            // 
            this.txt_libelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_libelle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_libelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_libelle.Location = new System.Drawing.Point(952, 121);
            this.txt_libelle.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_libelle.Multiline = true;
            this.txt_libelle.Name = "txt_libelle";
            this.txt_libelle.Size = new System.Drawing.Size(409, 106);
            this.txt_libelle.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(949, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Libellé";
            // 
            // txt_mot_cle
            // 
            this.txt_mot_cle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mot_cle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mot_cle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mot_cle.Location = new System.Drawing.Point(952, 265);
            this.txt_mot_cle.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_mot_cle.Name = "txt_mot_cle";
            this.txt_mot_cle.Size = new System.Drawing.Size(412, 23);
            this.txt_mot_cle.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(951, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mot clé";
            // 
            // btn_archiver
            // 
            this.btn_archiver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_archiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btn_archiver.FlatAppearance.BorderSize = 0;
            this.btn_archiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_archiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_archiver.ForeColor = System.Drawing.Color.White;
            this.btn_archiver.Location = new System.Drawing.Point(1161, 798);
            this.btn_archiver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_archiver.Name = "btn_archiver";
            this.btn_archiver.Size = new System.Drawing.Size(200, 49);
            this.btn_archiver.TabIndex = 5;
            this.btn_archiver.Text = "Archiver";
            this.btn_archiver.UseVisualStyleBackColor = false;
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_body.Controls.Add(this.pnl_pdf);
            this.pnl_body.Controls.Add(this.btn_nettoyer);
            this.pnl_body.Controls.Add(this.btn_archiver);
            this.pnl_body.Controls.Add(this.btn_annuler);
            this.pnl_body.Controls.Add(this.btn_impoter);
            this.pnl_body.Controls.Add(this.txt_libelle);
            this.pnl_body.Controls.Add(this.txt_path);
            this.pnl_body.Controls.Add(this.txt_mot_cle);
            this.pnl_body.Controls.Add(this.label1);
            this.pnl_body.Controls.Add(this.label2);
            this.pnl_body.Controls.Add(this.pnl_ruban);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(1, 1);
            this.pnl_body.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(1375, 860);
            this.pnl_body.TabIndex = 9;
            // 
            // pnl_pdf
            // 
            this.pnl_pdf.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_pdf.Location = new System.Drawing.Point(16, 90);
            this.pnl_pdf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_pdf.Name = "pnl_pdf";
            this.pnl_pdf.Size = new System.Drawing.Size(920, 757);
            this.pnl_pdf.TabIndex = 8;
            // 
            // btn_nettoyer
            // 
            this.btn_nettoyer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nettoyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btn_nettoyer.FlatAppearance.BorderSize = 0;
            this.btn_nettoyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nettoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nettoyer.ForeColor = System.Drawing.Color.White;
            this.btn_nettoyer.Location = new System.Drawing.Point(947, 44);
            this.btn_nettoyer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_nettoyer.Name = "btn_nettoyer";
            this.btn_nettoyer.Size = new System.Drawing.Size(415, 37);
            this.btn_nettoyer.TabIndex = 5;
            this.btn_nettoyer.Text = "Nettoyer";
            this.btn_nettoyer.UseVisualStyleBackColor = false;
            // 
            // txt_path
            // 
            this.txt_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_path.Enabled = false;
            this.txt_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path.Location = new System.Drawing.Point(432, 44);
            this.txt_path.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(504, 23);
            this.txt_path.TabIndex = 6;
            // 
            // PopArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1377, 862);
            this.Controls.Add(this.pnl_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PopArchive";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopArchive";
            this.pnl_ruban.ResumeLayout(false);
            this.pnl_ruban.PerformLayout();
            this.pnl_body.ResumeLayout(false);
            this.pnl_body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ruban;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_entete;
        private System.Windows.Forms.Button btn_impoter;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.TextBox txt_libelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mot_cle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_archiver;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_nettoyer;
        private System.Windows.Forms.Panel pnl_pdf;
    }
}