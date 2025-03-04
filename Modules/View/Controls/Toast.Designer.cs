namespace ArchiveManagerApp.Modules.View.Controls
{
    partial class Toast
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
            this.pnlConteneur = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.tmrDurationMessage = new System.Windows.Forms.Timer(this.components);
            this.pnlConteneur.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteneur
            // 
            this.pnlConteneur.Controls.Add(this.lblMessage);
            this.pnlConteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteneur.Location = new System.Drawing.Point(5, 5);
            this.pnlConteneur.Name = "pnlConteneur";
            this.pnlConteneur.Size = new System.Drawing.Size(170, 25);
            this.pnlConteneur.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(170, 25);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message ici...";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // tmrMove
            // 
            this.tmrMove.Interval = 1000;
            this.tmrMove.Tick += new System.EventHandler(this.tmrShow_Tick);
            // 
            // tmrDurationMessage
            // 
            this.tmrDurationMessage.Interval = 1000;
            this.tmrDurationMessage.Tick += new System.EventHandler(this.tmrDurationMessage_Tick);
            // 
            // Toast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(180, 35);
            this.Controls.Add(this.pnlConteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Toast";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Toast";
            this.TopMost = true;
            this.pnlConteneur.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConteneur;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer tmrDurationMessage;
    }
}