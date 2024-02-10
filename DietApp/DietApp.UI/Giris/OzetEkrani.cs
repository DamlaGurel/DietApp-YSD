﻿using DietApp.BLL.IServices;
using DietApp.BLL.Services;
using DietApp.Entities;
using DietApp.Enums;
using DietApp.UI.Rapor;
using DietApp.ViewModels;
using DietApp.ViewModels.KullaniciKisiselVms;

namespace DietApp.UI
{
    public partial class OzetEkrani : Form
    {
        public KullaniciGiris _kullanici;
        IKullaniciKisiselService _kisiselService;

        int _kkId;
        public OzetEkrani(int kkId)
        {
            InitializeComponent();
            InitializeComboBox();

            _kkId = kkId;
            _kisiselService = new KullaniciKisiselService();
        }
        public OzetEkrani(KullaniciGiris kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            InitializeComboBox();

            _kkId = kullanici.KullaniciKisiselID;
            _kisiselService = new KullaniciKisiselService();

        }

        public void RefreshDataGrid()
        {
            UpdateProgressBar();
            if (cmbOgun.SelectedItem == null) return;
            if (Enum.TryParse(cmbOgun.SelectedItem.ToString(), out OgunCesitleri ogunCesiti))
            {
                dgv_OgundekiYemekler.DataSource = new YemekMiktariService().YemekleriGetir(dtpTarih.Value, ogunCesiti, _kkId);

                dgv_OgundekiYemekler.Columns["ID"].Visible = false;
                dgv_OgundekiYemekler.Columns["YemekMiktarID"].Visible = false;
                dgv_OgundekiYemekler.Columns["KategoriID"].Visible = false;
            }


        }

        private void InitializeComboBox()
        {
            cmbOgun.Items.AddRange(Enum.GetNames(typeof(OgunCesitleri)));
        }

        private void OzetEkrani_Load(object sender, EventArgs e)
        {

            pbKaloriTakip.Maximum = (int)_kisiselService.GetByID(_kkId).GunlukKalori;
            RefreshDataGrid();
        }
        private void UpdateProgressBar()
        {
            double guncelKalori = new KaloriHesapService().GunlukKaloriHesabi(_kkId, dtpTarih.Value.Date);
            if (guncelKalori < pbKaloriTakip.Maximum)
                pbKaloriTakip.Value = (int)guncelKalori;
            else
                pbKaloriTakip.Value = pbKaloriTakip.Maximum;
            lblGuncelKalori.Text = guncelKalori + "kcal";
            lblHedefKalori.Text = pbKaloriTakip.Maximum + "kcal";
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (dgv_OgundekiYemekler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Değiştirilmesini istediğiniz bir satırı seçiniz.");
                return;
            }
            else if (dgv_OgundekiYemekler.SelectedRows.Count == 1)
            {
                YemekListVm secilenOgun = (YemekListVm)dgv_OgundekiYemekler.SelectedRows[0].DataBoundItem;

                YemekGuncelle form = new YemekGuncelle(secilenOgun);
                form.ShowDialog(this);
            }
        }

        private void btnSuTakip_Click(object sender, EventArgs e)
        {
            SuTakipEkrani suTakipEkrani = new SuTakipEkrani(_kkId, dtpTarih.Value.Date);
            suTakipEkrani.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbOgun.SelectedItem == null) return;
            string secilenOgun = cmbOgun.SelectedItem.ToString();


            UserYemekEklemePaneli userYemekEkleme = new UserYemekEklemePaneli(secilenOgun, dtpTarih.Value, _kkId);
            userYemekEkleme.ShowDialog(this);
        }

        private void cmbOgun_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            if (cmbOgun.SelectedItem == null) return;

            YemekListVm secilenOgun = (YemekListVm)dgv_OgundekiYemekler.SelectedRows[0].DataBoundItem;

            new YemekGuncelleService().YemekSil(secilenOgun.YemekMiktarID);
            RefreshDataGrid();

        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            AnaRaporEkrani anaRaporEkrani = new AnaRaporEkrani(_kkId);
            anaRaporEkrani.ShowDialog();
        }
    }
}
