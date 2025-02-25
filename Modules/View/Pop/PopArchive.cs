using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveManagerApp.Modules.View.Pop
{
    public partial class PopArchive: Form
    {
        public PopArchive()
        {
            InitializeComponent();

            btn_annuler.Click += btn_close_Click;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_impoter_Click(object sender, EventArgs e)
        {
            OpenFileDialog Op = new OpenFileDialog();
            //if(Op.ShowDialog == DialogResult.OK)
            //{

            //}
        }
    }
}
