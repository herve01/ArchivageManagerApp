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
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_apropos = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_parametre = new System.Windows.Forms.Button();
            this.btn_agent = new System.Windows.Forms.Button();
            this.btn_document = new System.Windows.Forms.Button();
            this.lbl_entete = new System.Windows.Forms.Label();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_ruban.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ruban
            // 
            this.pnl_ruban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.pnl_ruban.Controls.Add(this.btn_min);
            this.pnl_ruban.Controls.Add(this.btn_max);
            this.pnl_ruban.Controls.Add(this.btn_apropos);
            this.pnl_ruban.Controls.Add(this.btn_close);
            this.pnl_ruban.Controls.Add(this.btn_parametre);
            this.pnl_ruban.Controls.Add(this.btn_agent);
            this.pnl_ruban.Controls.Add(this.btn_document);
            this.pnl_ruban.Controls.Add(this.lbl_entete);
            this.pnl_ruban.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ruban.Location = new System.Drawing.Point(0, 0);
            this.pnl_ruban.Name = "pnl_ruban";
            this.pnl_ruban.Size = new System.Drawing.Size(1386, 30);
            this.pnl_ruban.TabIndex = 0;
            this.pnl_ruban.DoubleClick += new System.EventHandler(this.DoubleClick_);
            this.pnl_ruban.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_);
            this.pnl_ruban.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_);
            this.pnl_ruban.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(209)))), ((int)(((byte)(79)))));
            this.btn_min.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(1299, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(29, 30);
            this.btn_min.TabIndex = 6;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(255)))), ((int)(((byte)(94)))));
            this.btn_max.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_max.ForeColor = System.Drawing.Color.White;
            this.btn_max.Location = new System.Drawing.Point(1328, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(29, 30);
            this.btn_max.TabIndex = 5;
            this.btn_max.UseVisualStyleBackColor = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_apropos
            // 
            this.btn_apropos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_apropos.FlatAppearance.BorderSize = 0;
            this.btn_apropos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apropos.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.btn_apropos.ForeColor = System.Drawing.Color.White;
            this.btn_apropos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_apropos.Location = new System.Drawing.Point(570, 0);
            this.btn_apropos.Name = "btn_apropos";
            this.btn_apropos.Size = new System.Drawing.Size(110, 30);
            this.btn_apropos.TabIndex = 4;
            this.btn_apropos.Text = "Apropos";
            this.btn_apropos.UseVisualStyleBackColor = true;
            this.btn_apropos.Click += new System.EventHandler(this.btn_apropos_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1357, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(29, 30);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_parametre
            // 
            this.btn_parametre.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_parametre.FlatAppearance.BorderSize = 0;
            this.btn_parametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parametre.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.btn_parametre.ForeColor = System.Drawing.Color.White;
            this.btn_parametre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_parametre.Location = new System.Drawing.Point(460, 0);
            this.btn_parametre.Name = "btn_parametre";
            this.btn_parametre.Size = new System.Drawing.Size(110, 30);
            this.btn_parametre.TabIndex = 3;
            this.btn_parametre.Text = "Paramètres";
            this.btn_parametre.UseVisualStyleBackColor = true;
            this.btn_parametre.Click += new System.EventHandler(this.btn_parametre_Click);
            // 
            // btn_agent
            // 
            this.btn_agent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_agent.FlatAppearance.BorderSize = 0;
            this.btn_agent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agent.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.btn_agent.ForeColor = System.Drawing.Color.White;
            this.btn_agent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agent.Location = new System.Drawing.Point(350, 0);
            this.btn_agent.Name = "btn_agent";
            this.btn_agent.Size = new System.Drawing.Size(110, 30);
            this.btn_agent.TabIndex = 2;
            this.btn_agent.Text = "Agents";
            this.btn_agent.UseVisualStyleBackColor = true;
            this.btn_agent.Click += new System.EventHandler(this.btn_utilisateur_Click);
            // 
            // btn_document
            // 
            this.btn_document.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_document.FlatAppearance.BorderSize = 0;
            this.btn_document.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_document.Font = new System.Drawing.Font("Poppins Light", 12F);
            this.btn_document.ForeColor = System.Drawing.Color.White;
            this.btn_document.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_document.Location = new System.Drawing.Point(240, 0);
            this.btn_document.Name = "btn_document";
            this.btn_document.Size = new System.Drawing.Size(110, 30);
            this.btn_document.TabIndex = 1;
            this.btn_document.Text = "Documents";
            this.btn_document.UseVisualStyleBackColor = true;
            this.btn_document.Click += new System.EventHandler(this.btn_document_Click);
            // 
            // lbl_entete
            // 
            this.lbl_entete.BackColor = System.Drawing.Color.Transparent;
            this.lbl_entete.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_entete.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entete.ForeColor = System.Drawing.Color.White;
            this.lbl_entete.Location = new System.Drawing.Point(0, 0);
            this.lbl_entete.Name = "lbl_entete";
            this.lbl_entete.Size = new System.Drawing.Size(240, 30);
            this.lbl_entete.TabIndex = 0;
            this.lbl_entete.Text = "Archive Manager App";
            this.lbl_entete.DoubleClick += new System.EventHandler(this.DoubleClick_);
            this.lbl_entete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_);
            this.lbl_entete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_);
            this.lbl_entete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_);
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 30);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(1386, 758);
            this.pnl_body.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_ruban);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive Manager App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_ruban.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ruban;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.Label lbl_entete;
        private System.Windows.Forms.Button btn_document;
        private System.Windows.Forms.Button btn_apropos;
        private System.Windows.Forms.Button btn_parametre;
        private System.Windows.Forms.Button btn_agent;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
    }
}

