﻿using DietApp.BLL.IServices;
using DietApp.BLL.Services;
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

            var list = _raporlarService.KiyasRaporOgun(dtpBaslangicTarihi.Value.Date, dtpBitisTarihi.Value.Date, ogunCesitleri);
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

            double kullaniciOrtKalori = 0;
            foreach (var item in KullaniciList)
            {
                kullaniciOrtKalori += item.Kalori;
            }

            lblKategoriKullaniciOrtalama.Text = (kullaniciOrtKalori / KullaniciList.Count).ToString();

            double digerOrtKalori = 0;
            foreach (var item in DigerList)
            {
                digerOrtKalori += item.Kalori;
            }

            lblKategoriKullaniciOrtalama.Text = (digerOrtKalori / DigerList.Count).ToString();
        }
    }
}
