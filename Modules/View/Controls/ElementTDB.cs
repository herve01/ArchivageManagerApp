using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveManagerApp.Modules.View.Controls
{
    public partial class ElementTDB: UserControl
    {

        [Category("Customisé")]
        public string Title
        {
            get { return lbl_title.Text; }
            set {lbl_title.Text = value;}
        }

        [Category("Customisé")]
        public string Number
        {
            get { return lbl_number.Text; }
            set { lbl_number.Text = value; }
        }

        [Category("Customisé")]
        public string Description
        {
            get { return lbl_description.Text; }
            set { lbl_description.Text = value; }
        }


        public ElementTDB()
        {
            InitializeComponent();
        }
    }
}
