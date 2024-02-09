﻿using DietApp.BLL.IServices;
using DietApp.BLL.Services;
using DietApp.Entities;
using DietApp.Enums;
using DietApp.ViewModels;
using DietApp.ViewModels.KullaniciKisiselVms;

namespace DietApp.UI
{
    public partial class UserYemekEklemePaneli : Form
    {
        IUserYemekEklemeService _service;
        KullaniciKisiselCreateVm _kkCreateVM;
        string _ogunCesidi;

        public DateTime DtpTarih;

        public int kkID ;

        public UserYemekEklemePaneli(string ogunCesidi, DateTime tarih, int id)
        {
            InitializeComponent();
            _service = new UserYemekEklemeService();

            _ogunCesidi = ogunCesidi;
            DtpTarih = tarih;
            kkID = id;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Yemek yemek = cmbYemekGirisi.SelectedItem as Yemek;

            UserYemekEklemePaneliVm userYemekEklemeVM = new UserYemekEklemePaneliVm()
            {
                YemekID = yemek.ID,
                MiktarGr = double.Parse(txtMiktar.Text)
            };


            if (Enum.TryParse(_ogunCesidi, out OgunCesitleri ogunCesiti))
            {

                Ogun ogun = _service.TariheGoreOgunBul(ogunCesiti, DtpTarih.Date, kkID);
                ogun.KullaniciKisiselID = kkID;
                _service.UserYemekEkleme(userYemekEklemeVM, ogun);

                var owner = (this.Owner) as OzetEkrani;
                owner.RefreshDataGrid();
            }
            KaloriHesaplamaPaneli();
        }


        private void UserYemekEklemePaneli_Load(object sender, EventArgs e)
        {
            cmbYemekGirisi.DataSource = _service.YemekGetir();
            cmbYemekGirisi.DisplayMember = "YemekAdi";
            cmbYemekGirisi.Text = string.Empty;

            cmbKategori.DataSource = _service.KategoriGetir();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.Text = string.Empty;
            grpOgunAdi.Text = _ogunCesidi;

            pbGorsel.Image = null;

        }

        private void cmbYemekGirisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbYemekGirisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Yemek seciliYemek = cmbYemekGirisi.SelectedItem as Yemek;
            if (seciliYemek != null)
            {
                string path = Path.Combine(Application.StartupPath, seciliYemek.FotografYolu);
                pbGorsel.Image = Image.FromFile(path);
            }
        }

        private void KaloriHesaplamaPaneli()
        {
            Yemek yemek = cmbYemekGirisi.SelectedItem as Yemek;

            lblKalori.Text = (yemek.Kalori * double.Parse(txtMiktar.Text) / 100).ToString();
            lblKarbonhidrat.Text = (yemek.KarbonhidratMiktari * double.Parse(txtMiktar.Text) / 100).ToString();
            lblProtein.Text = (yemek.ProteinMiktari * double.Parse(txtMiktar.Text) / 100).ToString();
            lblYag.Text = (yemek.YagMiktari * double.Parse(txtMiktar.Text) / 100).ToString();
        }

    }
}
