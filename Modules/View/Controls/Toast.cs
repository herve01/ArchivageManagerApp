using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ArchiveManagerApp.Modules.View.Controls
{
    public partial class Toast: Form
    {
        int durationMessage;
        bool sens;
        Point centerScreen, bondsScreen;
        public Toast(string message, int duree, Color BackgroundColor, Color ForeColor)
        {
            InitializeComponent();

            lblMessage.Text = message;
            durationMessage = duree;
            BackColor = BackgroundColor;
            lblMessage.ForeColor = ForeColor;

            bondsScreen = Screen.PrimaryScreen.Bounds.Location;
            centerScreen = new Point((bondsScreen.X - this.Width) / 2,
                                     (bondsScreen.Y - this.Height) / 2);
            this.Show();
            this.Location = new Point(centerScreen.X, bondsScreen.Y);

            tmrMove.Start();
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            int yPosition_ = this.Location.Y;
            if (sens)
            {
                if (yPosition_ >= (centerScreen.Y))
                {
                    this.Location = new Point(centerScreen.X, yPosition_ - 10);
                }
                else
                {
                    tmrMove.Stop();
                    tmrDurationMessage.Start();
                }
            }
            else
            {
                if (yPosition_ <= bondsScreen.Y)
                {
                    this.Location = new Point(centerScreen.X, yPosition_ + 10); 
                }
                else
                { 
                    tmrMove.Stop();
                    this.Close();
                }
            }       
        }
        private void tmrDurationMessage_Tick(object sender, EventArgs e)
        {
            if (durationMessage >= 1)
                durationMessage --;
            else
            {
                tmrDurationMessage.Stop();
                sens = true;
                tmrMove.Start();
            }  
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
