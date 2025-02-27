namespace ArchiveManagerApp.Modules.View
{
    partial class TableDeBordView
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
            this.elementTDB4 = new ArchiveManagerApp.Modules.View.Controls.ElementTDB();
            this.elementTDB3 = new ArchiveManagerApp.Modules.View.Controls.ElementTDB();
            this.elementTDB2 = new ArchiveManagerApp.Modules.View.Controls.ElementTDB();
            this.elementTDB1 = new ArchiveManagerApp.Modules.View.Controls.ElementTDB();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Open Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(16, 53);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(382, 30);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Archive Manager App 1.0.0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue";
            // 
            // elementTDB4
            // 
            this.elementTDB4.BackColor = System.Drawing.Color.White;
            this.elementTDB4.Description = "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mis" +
    "e en page avant impression.";
            this.elementTDB4.Location = new System.Drawing.Point(675, 139);
            this.elementTDB4.Name = "elementTDB4";
            this.elementTDB4.Number = "00.00";
            this.elementTDB4.Padding = new System.Windows.Forms.Padding(10);
            this.elementTDB4.Size = new System.Drawing.Size(200, 200);
            this.elementTDB4.TabIndex = 1;
            this.elementTDB4.Title = "Title";
            // 
            // elementTDB3
            // 
            this.elementTDB3.BackColor = System.Drawing.Color.White;
            this.elementTDB3.Description = "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mis" +
    "e en page avant impression.";
            this.elementTDB3.Location = new System.Drawing.Point(459, 139);
            this.elementTDB3.Name = "elementTDB3";
            this.elementTDB3.Number = "00.00";
            this.elementTDB3.Padding = new System.Windows.Forms.Padding(10);
            this.elementTDB3.Size = new System.Drawing.Size(200, 200);
            this.elementTDB3.TabIndex = 1;
            this.elementTDB3.Title = "Title";
            // 
            // elementTDB2
            // 
            this.elementTDB2.BackColor = System.Drawing.Color.White;
            this.elementTDB2.Description = "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mis" +
    "e en page avant impression.";
            this.elementTDB2.Location = new System.Drawing.Point(238, 139);
            this.elementTDB2.Name = "elementTDB2";
            this.elementTDB2.Number = "00.00";
            this.elementTDB2.Padding = new System.Windows.Forms.Padding(10);
            this.elementTDB2.Size = new System.Drawing.Size(200, 200);
            this.elementTDB2.TabIndex = 1;
            this.elementTDB2.Title = "Title";
            // 
            // elementTDB1
            // 
            this.elementTDB1.BackColor = System.Drawing.Color.White;
            this.elementTDB1.Description = "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mis" +
    "e en page avant impression.";
            this.elementTDB1.Location = new System.Drawing.Point(19, 139);
            this.elementTDB1.Name = "elementTDB1";
            this.elementTDB1.Number = "00.00";
            this.elementTDB1.Padding = new System.Windows.Forms.Padding(10);
            this.elementTDB1.Size = new System.Drawing.Size(200, 200);
            this.elementTDB1.TabIndex = 1;
            this.elementTDB1.Title = "Title";
            // 
            // TableDeBordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.elementTDB4);
            this.Controls.Add(this.elementTDB3);
            this.Controls.Add(this.elementTDB2);
            this.Controls.Add(this.elementTDB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.Name = "TableDeBordView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private Controls.ElementTDB elementTDB1;
        private Controls.ElementTDB elementTDB2;
        private Controls.ElementTDB elementTDB3;
        private Controls.ElementTDB elementTDB4;
    }
}
