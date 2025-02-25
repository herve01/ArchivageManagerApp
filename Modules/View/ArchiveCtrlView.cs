using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchiveManagerApp.Modules.View.Pop;

namespace ArchiveManagerApp.Modules.View
{
    public partial class ArchiveCtrlView: UserControl
    {
        public ArchiveCtrlView()
        {
            InitializeComponent();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Form Pop = new PopArchive();
            Pop.ShowDialog();
        }
    }
}
