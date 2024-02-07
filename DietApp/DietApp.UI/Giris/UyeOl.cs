using DietApp.BLL.Services;
using DietApp.ViewModels.KullaniciGiris;
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
    public partial class UyeOl : Form
    {
        KullaniciGirisService _service;
        public UyeOl()
        {
            InitializeComponent();
            _service=new KullaniciGirisService();
        }
        string hata;
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            if (!chkAydinlatmaMetni.Checked)
            {
                MessageBox.Show("Aydınlanma metnini kabul etmeden hesap oluşturamazsınız!");
            }

            KullanicOlusturVm vm = new KullanicOlusturVm()
            {
                KullaniciAdi=txtKullaniciAdi.Text,
                Sifre=txtSifre.Text,
            };

            if (txtSifre.Text != txtSifreTekrari.Text)
            {
                MessageBox.Show("Şifreler Aynı Değil!");
            }


            if (_service.KullaniciYarat(vm, ref hata))
            {
                Form frm = new UserBilgileriAlmaEkrani(vm);
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show(hata);
            }



        }
    }
}
