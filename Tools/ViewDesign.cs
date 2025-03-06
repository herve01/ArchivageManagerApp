using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G = Guna.UI2.WinForms;


namespace ArchiveManagerApp.Tools
{
    public static class ViewDesign
    {
        public static bool TextBoxIsNullOrEmpty(Control parent)
        {
            foreach (var control in parent.Controls.OfType<Guna2TextBox>())
            {
                if (string.IsNullOrEmpty(control.Text))
                    return true;
            }
            return false;
        }
        public static void ControlsClear(Control parent)
        {
            foreach (var control in parent.Controls.OfType<Guna2TextBox>())
            {
                if (control.Text != string.Empty)
                    control.Text = string.Empty;
            }
            foreach (var control in parent.Controls.OfType<Guna2ComboBox>())
            {
                control.SelectedIndex = 0;
            }
            foreach (var control in parent.Controls.OfType<Guna2PictureBox>())
            {
                control.Image = null;
            }
        }

        public static void EnabledButton(Control parent, bool isEnabled = false)
        {
            foreach (var control in parent.Controls.OfType<Guna2Button>())
                    control.Enabled = isEnabled;
        }

        public static void ShowPage(Panel panelContener, UserControl pageSelected)
        {
            if (!panelContener.Controls.Contains(pageSelected))
            {
                panelContener.Controls.Clear();
                pageSelected.Size = panelContener.Size;
                pageSelected.Dock = DockStyle.Fill;
                panelContener.Controls.Add(pageSelected);
            }
        }
        public static void CheckButton(object buttonClicked, Panel panelContener)
        {
            if (((G.Guna2Button)buttonClicked).Checked == false)
            {
                foreach (G.Guna2Button btn_ in panelContener.Controls.OfType<G.Guna2Button>())
                {
                    btn_.Checked = false;
                }
                ((G.Guna2Button)buttonClicked).Checked = true;
            }
        }
    }
}
