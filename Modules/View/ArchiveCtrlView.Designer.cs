namespace ArchiveManagerApp.Modules.View
{
    partial class ArchiveCtrlView
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
            this.pnl_document = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_filtrer = new System.Windows.Forms.Button();
            this.txt_recherche = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnl_document
            // 
            this.pnl_document.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_document.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnl_document.Location = new System.Drawing.Point(18, 44);
            this.pnl_document.Margin = new System.Windows.Forms.Padding(5);
            this.pnl_document.Name = "pnl_document";
            this.pnl_document.Size = new System.Drawing.Size(752, 499);
            this.pnl_document.TabIndex = 5;
            // 
            // btn_filtrer
            // 
            this.btn_filtrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_filtrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btn_filtrer.FlatAppearance.BorderSize = 0;
            this.btn_filtrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtrer.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrer.ForeColor = System.Drawing.Color.White;
            this.btn_filtrer.Location = new System.Drawing.Point(644, 6);
            this.btn_filtrer.Name = "btn_filtrer";
            this.btn_filtrer.Size = new System.Drawing.Size(130, 30);
            this.btn_filtrer.TabIndex = 4;
            this.btn_filtrer.Text = "Filtrer";
            this.btn_filtrer.UseVisualStyleBackColor = false;
            // 
            // txt_recherche
            // 
            this.txt_recherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_recherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_recherche.Font = new System.Drawing.Font("Poppins Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recherche.Location = new System.Drawing.Point(16, 10);
            this.txt_recherche.Margin = new System.Windows.Forms.Padding(5);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.Size = new System.Drawing.Size(620, 24);
            this.txt_recherche.TabIndex = 3;
            // 
            // ArchiveCtrlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_document);
            this.Controls.Add(this.btn_filtrer);
            this.Controls.Add(this.txt_recherche);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ArchiveCtrlView";
            this.Size = new System.Drawing.Size(889, 469);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_document;
        private System.Windows.Forms.Button btn_filtrer;
        private System.Windows.Forms.TextBox txt_recherche;
    }
}
