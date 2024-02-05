using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp.UI
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            Form frm = new UyeOl();
            frm.ShowDialog();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Form frm = new OzetEkrani();
            frm.ShowDialog();
        }
    }
}
