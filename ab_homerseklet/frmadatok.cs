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
    public partial class frmadatok : Form
    {
        public frmadatok()
        {
            InitializeComponent();
        }
        void betoltes()
        {
            dgadatok.Rows.Clear();
            string lekerdezes = "select * from homerseklet";
            Homerseklet hm = new Homerseklet(lekerdezes);
            while (hm.Dr.Read())
            {
                DateTime datum = Convert.ToDateTime(hm.Dr["datum"]);
                dgadatok.Rows.Add(hm.Dr["azon"], hm.Dr["varos"], hm.Dr["napszak"], datum.Date.ToString("yyyy-MM-dd"), hm.Dr["ertek"], hm.Dr["csapadek"]);
            }
        }

        private void frmadatok_Load(object sender, EventArgs e)
        {
            betoltes();
            rbnew.Checked = true;
        }

        private void txazon_TextChanged(object sender, EventArgs e)
        {
            if (txazon.Text.Length > 0)
            {
                try
                {
                    Convert.ToInt32(txazon.Text);
                }
                catch
                {
                    MessageBox.Show("Csak számod adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txazon.Clear();
                    txazon.Focus();
                }
            }
        }

        private void txcsapadek_TextChanged(object sender, EventArgs e)
        {
            if (txcsapadek.Text.Length > 0)
            {
                try
                {
                    Convert.ToInt32(txcsapadek.Text);
                }
                catch
                {
                    MessageBox.Show("Csak számod adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txcsapadek.Clear();
                    txcsapadek.Focus();
                }
            }
        }
    }
}
