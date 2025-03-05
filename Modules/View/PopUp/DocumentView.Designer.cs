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
            this.lblEntete = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.lstDetails = new System.Windows.Forms.ListView();
            this.pnlDocument = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExporter = new Guna.UI2.WinForms.Guna2Button();
            this.bouger = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.rszForm = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.pnl_ruban.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ruban
            // 
            this.pnl_ruban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnl_ruban.Controls.Add(this.lblEntete);
            this.pnl_ruban.Controls.Add(this.btn_close);
            this.pnl_ruban.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ruban.Location = new System.Drawing.Point(0, 0);
            this.pnl_ruban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_ruban.Name = "pnl_ruban";
            this.pnl_ruban.Size = new System.Drawing.Size(1375, 43);
            this.pnl_ruban.TabIndex = 1;
            this.pnl_ruban.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_ruban_Paint);
            // 
            // lblEntete
            // 
            this.lblEntete.BackColor = System.Drawing.Color.Transparent;
            this.lblEntete.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEntete.ForeColor = System.Drawing.Color.White;
            this.lblEntete.Location = new System.Drawing.Point(0, 0);
            this.lblEntete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntete.Name = "lblEntete";
            this.lblEntete.Size = new System.Drawing.Size(240, 43);
            this.lblEntete.TabIndex = 0;
            this.lblEntete.Text = "Archive";
            this.lblEntete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.IconColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1308, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(67, 43);
            this.btn_close.TabIndex = 1;
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_body.Controls.Add(this.lstDetails);
            this.pnl_body.Controls.Add(this.pnlDocument);
            this.pnl_body.Controls.Add(this.btnExporter);
            this.pnl_body.Controls.Add(this.pnl_ruban);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(1, 1);
            this.pnl_body.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(1375, 786);
            this.pnl_body.TabIndex = 9;
            // 
            // lstDetails
            // 
            this.lstDetails.BackColor = System.Drawing.SystemColors.Control;
            this.lstDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstDetails.GridLines = true;
            this.lstDetails.HideSelection = false;
            this.lstDetails.Location = new System.Drawing.Point(921, 59);
            this.lstDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDetails.Name = "lstDetails";
            this.lstDetails.ShowItemToolTips = true;
            this.lstDetails.Size = new System.Drawing.Size(439, 297);
            this.lstDetails.TabIndex = 13;
            this.lstDetails.UseCompatibleStateImageBehavior = false;
            this.lstDetails.View = System.Windows.Forms.View.Details;
            // 
            // pnlDocument
            // 
            this.pnlDocument.BackColor = System.Drawing.Color.Transparent;
            this.pnlDocument.BorderRadius = 10;
            this.pnlDocument.Location = new System.Drawing.Point(17, 59);
            this.pnlDocument.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDocument.Name = "pnlDocument";
            this.pnlDocument.Size = new System.Drawing.Size(893, 714);
            this.pnlDocument.TabIndex = 12;
            // 
            // btnExporter
            // 
            this.btnExporter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExporter.Animated = true;
            this.btnExporter.BorderRadius = 10;
            this.btnExporter.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnExporter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExporter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExporter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExporter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExporter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.btnExporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExporter.ForeColor = System.Drawing.Color.White;
            this.btnExporter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExporter.Location = new System.Drawing.Point(921, 367);
            this.btnExporter.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnExporter.Name = "btnExporter";
            this.btnExporter.Size = new System.Drawing.Size(213, 42);
            this.btnExporter.TabIndex = 9;
            this.btnExporter.Text = "Exporter";
            // 
            // bouger
            // 
            this.bouger.DockIndicatorColor = System.Drawing.Color.IndianRed;
            this.bouger.DockIndicatorTransparencyValue = 0.6D;
            this.bouger.TargetControl = this.pnl_ruban;
            this.bouger.UseTransparentDrag = true;
            // 
            // rszForm
            // 
            this.rszForm.TargetForm = this;
            // 
            // DocumentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1377, 788);
            this.Controls.Add(this.pnl_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblEntete;
        private System.Windows.Forms.Panel pnl_body;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private Guna.UI2.WinForms.Guna2Panel pnlDocument;
        private Guna.UI2.WinForms.Guna2DragControl bouger;
        private System.Windows.Forms.ListView lstDetails;
        private Guna.UI2.WinForms.Guna2Button btnExporter;
        private Guna.UI2.WinForms.Guna2ResizeForm rszForm;
    }
}