using DietApp.BLL.IServices;
using DietApp.BLL.Services;
using DietApp.ViewModels.KullaniciGiris;
using DietApp.ViewModels.VucutIndeksiVms;
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
    public partial class UserBilgileriAlmaEkrani : Form
    {
        IVucutIndeksiService _service;
        KullaniciGirisService _kullaniciService;
        public KullanicOlusturVm Vm { get; }

        public UserBilgileriAlmaEkrani(KullanicOlusturVm vm)
        {
            InitializeComponent();
            _service = new VucutIndeksiService();
            _kullaniciService=new KullaniciGirisService();
            Vm = vm;
        }


        private void btnAnaEkranaGec_Click(object sender, EventArgs e)
        {
            Form frm = new OzetEkrani(_kullaniciService.KullaniciBul(Vm.KullaniciAdi));
            this.Hide();
            frm.Show();
        }

        private void btnVucutIndeksiHesapla_Click(object sender, EventArgs e)
        {
            VucutIndeksiVm vivm = new VucutIndeksiVm()
            {
                Boy = decimal.Parse(txtBoy.Text),
                Kilo = decimal.Parse(txtKilo.Text),
            };

            VucutIndeksiCreateVm vicm = new VucutIndeksiCreateVm
            {
                Boy = decimal.Parse(txtBoy.Text),
                Kilo = decimal.Parse(txtKilo.Text),
                Isim = "Damla",
                BaslangicTarihi = DateTime.Now,
                BitisTarihi = DateTime.Now,
                GunlukKalori = 1.2,
                HedefKilo = 1.2M,
                SuMiktari = 1.2,
                Soyisim = "gürel",
                IdealKilo = 1.2,
                Yas = 20,
            };

            if (rbErkek.Checked)
                vicm.Cinsiyet = false;
            else if (rbKadin.Checked)
                vicm.Cinsiyet = true;

            decimal vki = _service.VucutKitleIndeksiHesapla(vivm);
            if (vki >= 20 && vki < 25)
            {
                lblVucutIndeksi.Text = $"Vücut Kitle İndeksiniz: {vki}. Ortalama vucüt kitle indeks aralığındasınız.";
            }
            else if (vki >= 25)
            {
                lblVucutIndeksi.Text = $"Vücut Kitle İndeksiniz: {vki}. Ortalama vucüt kitle indeks aralığının üstündesiniz.";
            }
            else if (vki < 20)
            {
                lblVucutIndeksi.Text = $"Vücut Kitle İndeksiniz: {vki}. Ortalama vucüt kitle indeks aralığının üstündesiniz.";
            }

            lblIdealKilo.Text = "İdeal Kilonuz:" +  _service.IdealKiloHesapla(vivm, vicm.Cinsiyet);

            txtHedefKilo.Text = lblIdealKilo.Text;
            lblGunlukKaloriIhtiyaci.Text = "Gunluk kalori ihtiyacınız: " + _service.GunlukKaloriIhtiyaci(vivm);

            Vm.kullaniciKisiselID=_service.Create(vicm);

            new KullaniciGirisService().KullaniciYarat(Vm);

        }

        private void btnKaloriIhtiyaciniHesapla_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
