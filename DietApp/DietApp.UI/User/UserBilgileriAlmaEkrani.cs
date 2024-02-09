﻿using DietApp.BLL.IServices;
using DietApp.BLL.Services;
using DietApp.ViewModels.KullaniciGiris;
using DietApp.ViewModels.KullaniciKisiselVms;

namespace DietApp.UI
{
    public partial class UserBilgileriAlmaEkrani : Form
    {
        IKullaniciGirisService _kullaniciService;
        IKullaniciKisiselService _kullaniciKisiselService;

        KullaniciKisiselCreateVm vivm;

        public KullanicOlusturVm Vm { get; }

        public UserBilgileriAlmaEkrani(KullanicOlusturVm vm)
        {
            InitializeComponent();
            _kullaniciService = new KullaniciGirisService();
            _kullaniciKisiselService = new KullaniciKisiselService();

            vivm = new KullaniciKisiselCreateVm();
            Vm = vm;
        }


        private void btnAnaEkranaGec_Click(object sender, EventArgs e)
        {
            Form frm = new OzetEkrani(_kullaniciService.KullaniciBul(Vm.KullaniciAdi));
            this.Hide();
            frm.Show();
        }

        private void btnKullaniciKisiselHesapla_Click(object sender, EventArgs e)
        {
            int kullaniciKisiselId = new KullaniciGirisService().KullaniciYarat(Vm);


            vivm.KullaniciGirisId = kullaniciKisiselId;
            vivm.Boy = decimal.Parse(txtBoy.Text);
            vivm.Kilo = decimal.Parse(txtKilo.Text);
            
            if (rbErkek.Checked)
                vivm.Cinsiyet = false;
            else if (rbKadin.Checked)
                vivm.Cinsiyet = true;


            KullaniciKisiselVm kisiselVm = new KullaniciKisiselVm()
            {
                Boy = vivm.Boy,
                Kilo = vivm.Kilo,
                Cinsiyet = vivm.Cinsiyet,
            };

            decimal vki = _kullaniciKisiselService.VucutKitleIndeksiHesapla(kisiselVm);
            if (vki >= 20 && vki < 25)
            {
                lblKullaniciKisisel.Text = $"Vücut Kitle İndeksiniz: {vki}. Ortalama vucüt kitle indeks aralığındasınız.";
            }
            else if (vki >= 25)
            {
                lblKullaniciKisisel.Text = $"Vücut Kitle İndeksiniz: {vki}. Ortalama vucüt kitle indeks aralığının üstündesiniz.";
            }
            else if (vki < 20)
            {
                lblKullaniciKisisel.Text = $"Vücut Kitle İndeksiniz: {vki}. Ortalama vucüt kitle indeks aralığının üstündesiniz.";
            }

            lblIdealKilo.Text = "İdeal Kilonuz:" + _kullaniciKisiselService.IdealKiloHesapla(kisiselVm, vivm.Cinsiyet);

            txtHedefKilo.Text = lblIdealKilo.Text;
            lblGunlukKaloriIhtiyaci.Text = "Gunluk kalori ihtiyacınız: " + _kullaniciKisiselService.GunlukKaloriIhtiyaci(kisiselVm);


        }

        private void btnKaloriIhtiyaciniHesapla_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
