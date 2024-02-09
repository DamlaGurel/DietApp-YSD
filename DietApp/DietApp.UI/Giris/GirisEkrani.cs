using DietApp.BLL.IServices;
using DietApp.BLL.Services;
using DietApp.Entities;
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
    public partial class GirisEkrani : Form
    {
        KullaniciGirisService _service;
        public GirisEkrani()
        {
            InitializeComponent();
            _service = new KullaniciGirisService();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            Form frm = new UyeOl();
            this.Hide();
            frm.ShowDialog(this);
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            KullaniciGirisVm vm=    new KullaniciGirisVm()
            {
                KullaniciAdi=txtKullaniciAdi.Text,
                Password=txtSifre.Text
            };


          if (_service.KullaniciGirisYap(vm))
            {

                var a = _service.KullaniciBul(vm.KullaniciAdi);
                Form frm = new OzetEkrani(_service.KullaniciBul(vm.KullaniciAdi));
                this.Hide();
                frm.Show();
               
            }
          else
            {
                MessageBox.Show("Yanlış kullanıcı adı ya da şifre!");
            }

           
        }
    }
}
