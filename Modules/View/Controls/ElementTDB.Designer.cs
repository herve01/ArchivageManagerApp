namespace ArchiveManagerApp.Modules.View.Controls
{
    partial class ElementTDB
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
            this.components = new System.ComponentModel.Container();
            this.lbl_title = new System.Windows.Forms.Label();
            this.arondir = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_number = new System.Windows.Forms.Label();
            this.spr1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbl_description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titlle
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lbl_title.Location = new System.Drawing.Point(10, 10);
            this.lbl_title.Name = "lbl_titlle";
            this.lbl_title.Size = new System.Drawing.Size(180, 30);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // arondir
            // 
            this.arondir.BorderRadius = 10;
            this.arondir.TargetControl = this;
            // 
            // lbl_number
            // 
            this.lbl_number.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_number.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(10, 40);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(180, 83);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "00.00";
            this.lbl_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spr1
            // 
            this.spr1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spr1.Location = new System.Drawing.Point(10, 123);
            this.spr1.Name = "spr1";
            this.spr1.Size = new System.Drawing.Size(180, 10);
            this.spr1.TabIndex = 1;
            // 
            // lbl_description
            // 
            this.lbl_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_description.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lbl_description.Location = new System.Drawing.Point(10, 133);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(180, 57);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mis" +
    "e en page avant impression.";
            // 
            // ElementTDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.spr1);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.lbl_title);
            this.Name = "ElementTDB";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(200, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private Guna.UI2.WinForms.Guna2Elipse arondir;
        private System.Windows.Forms.Label lbl_number;
        private Guna.UI2.WinForms.Guna2Separator spr1;
        private System.Windows.Forms.Label lbl_description;
    }
}
