using DietApp.BLL.Services;
using DietApp.Entities;
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
    public partial class KiyasRaporlari : Form
    {
        int kisiID;
        public KiyasRaporlari(int id)
        {
            InitializeComponent();
            kisiID = id;
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedItem == null) return;

            double ortalamaKisi, ortalamaGenel;


            new RaporlarService().KiyasRaporOgun(dtpBaslangicTarihi.Value.Date, dtpBitisTarihi.Value.Date,  
(Kategori)cmbKategori.SelectedItem, kisiID, out ortalamaGenel, out ortalamaKisi);
        }

        private void KiyasRaporlari_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = new RaporlarService().KategoriGetAll();
            cmbKategori.DisplayMember = "KategoriAdi";
        }
    }
}
