using DietApp.BLL.IServices;
using DietApp.BLL.Services;
using DietApp.Entities;
using DietApp.Enums;
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
        IRaporlarService _raporlarService;
        int _kkId;
        public KiyasRaporlari(int id)
        {
            InitializeComponent();
            _raporlarService = new RaporlarService();
            _kkId = id;
            cmbOgun.Items.AddRange(Enum.GetNames(typeof(OgunCesitleri)));
        }

        private void btnHesaplaOgun_Click(object sender, EventArgs e)
        {
            if (cmbOgun.SelectedIndex < 0)
            {
                MessageBox.Show("Bir öğün seçiniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpBaslangicTarihi.Value >= dtpBitisTarihi.Value)
            {
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden büyük veya eşit olamaz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secilenOgun = cmbOgun.SelectedItem.ToString();
            OgunCesitleri ogunCesitleri = (OgunCesitleri)Enum.Parse(typeof(OgunCesitleri), secilenOgun);
            int ogunID = (int)ogunCesitleri;

            var list = _raporlarService.KiyasRaporOgun(dtpBaslangicTarihi.Value.Date, dtpBitisTarihi.Value.Date);
            var KullaniciList = list.FindAll(x => x.KullaniciId == _kkId && x.OgunAdi == ogunID);
            var DigerList = list.FindAll(x => x.KullaniciId != _kkId && x.OgunAdi == ogunID);

            if (KullaniciList.Count == 0)
            {
                MessageBox.Show("Kullanıcı verisi bulunamadı!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (DigerList.Count == 0)
            {
                MessageBox.Show("Diger kullanıcı verisi bulunamadı!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeSpan tarihFarki = dtpBitisTarihi.Value - dtpBaslangicTarihi.Value; 
            double kullaniciOrtKalori = 0;
            foreach (var item in KullaniciList)
            {
                kullaniciOrtKalori += item.Kalori;
            }

            lblOgunKullaniciOrtalama.Text = (kullaniciOrtKalori / tarihFarki.Days).ToString();

            double digerOrtKalori = 0;
            foreach (var item in DigerList)
            {
                digerOrtKalori += item.Kalori;
            }

            lblOgunOrtalama.Text = (digerOrtKalori / tarihFarki.Days).ToString();
        }



        private void KiyasRaporlari_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = new RaporlarService().KategoriGetAll();
            cmbKategori.DisplayMember = "KategoriAdi";
        }

        private void btnHesaplaKategori_Click(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedItem == null) return;

            double ortalamaKisi, ortalamaGenel;


            new RaporlarService().KiyasRaporOgun(dtpBaslangicTarihi.Value.Date, dtpBitisTarihi.Value.Date, (Kategori)cmbKategori.SelectedItem, _kkId, out ortalamaGenel, out ortalamaKisi);


            lblKategoriOrtalama.Text = ortalamaGenel.ToString();
            lblKategoriKullaniciOrtalama.Text = ortalamaKisi.ToString();

        }
    }
}
