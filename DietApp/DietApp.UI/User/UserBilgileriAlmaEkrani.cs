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
    public partial class UserBilgileriAlmaEkrani : Form
    {
        KullaniciGirisService _service;
        public UserBilgileriAlmaEkrani()
        {
            InitializeComponent();
            _service = new KullaniciGirisService();
        }

        public UserBilgileriAlmaEkrani(KullanicOlusturVm vm)
        {
            Vm = vm;
        }

        public KullanicOlusturVm Vm { get; }

        private void btnAnaEkranaGec_Click(object sender, EventArgs e)
        {
            Form frm = new OzetEkrani(_service.KullaniciBul(Vm.KullaniciAdi));
            frm.ShowDialog();
        }

        private void btnIndexHesapla_Click(object sender, EventArgs e)
        {

        }
    }
}
