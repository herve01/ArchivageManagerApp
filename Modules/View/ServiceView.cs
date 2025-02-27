using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveManagerApp.Modules.View
{
    public partial class ServiceView: UserControl
    {
        public ServiceView()
        {
            InitializeComponent();
        }

        private void txtService_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtService.Text))
            {
                btnAjouter.Enabled = false;
            }
            else
            {
                btnAjouter.Enabled = true;
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            int nb = lstServices.Items.Count + 1;
            lstServices.Items.Add(new ListViewItem(new string[] { nb.ToString(), txtService.Text, "0" }));
            txtService.Clear();
            btnAjouter.Enabled = false;
        }
    }
}
