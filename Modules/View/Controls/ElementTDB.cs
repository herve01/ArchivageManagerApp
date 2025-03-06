using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArchiveManagerApp.Modules.View.Controls
{
    public partial class ElementTDB: UserControl
    {

        public string Title
        {
            get { return lbl_title.Text; }
            set {lbl_title.Text = value;}
        }

        public string Number
        {
            get { return lbl_number.Text; }
            set { lbl_number.Text = value; }
        }

        public ElementTDB()
        {
            InitializeComponent();
        }
    }
}
