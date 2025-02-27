using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ab_homerseklet
{
    public partial class Fomenu : Form
    {
        public Fomenu()
        {
            InitializeComponent();
        }

        private void txexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txadatok_Click(object sender, EventArgs e)
        {
            frmadatok frmadatok = new frmadatok();
            frmadatok.ShowDialog();
        }
    }
}
