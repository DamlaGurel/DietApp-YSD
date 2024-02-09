using DietApp.BLL.IServices;
using DietApp.BLL.Services;
using DietApp.Entities;
using DietApp.Enums;
using DietApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DietApp.UI
{
    public partial class SuTakipEkrani : Form
    {
        IKullaniciSuTakipService _suTakipService;
        IKullaniciKisiselService _kisiselService;
        int KullaniciKisiselId;
        DateTime Tarih;
        public SuTakipEkrani(int id = 1, DateTime dt = new DateTime())
        {
            InitializeComponent();
            _suTakipService = new KullaniciSuTakipService();
            _kisiselService = new KullaniciKisiselService();
            KullaniciKisiselId = id;
            Tarih = dt;
        }



        private void btnSuEkle_Click(object sender, EventArgs e)
        {
            Su su = _suTakipService.SuKontrol(KullaniciKisiselId, Tarih);

            SuTakipVm suTakipVm = new SuTakipVm()
            {
                ID = su.ID,
                SuMiktari = double.Parse(txtSu.Text)
            };
            _suTakipService.SuEkleUpdate(suTakipVm);

            UpdateProgressBar();
        }

        private void btnSuCikar_Click(object sender, EventArgs e)
        {
            SuTakipVm suTakipVm = new SuTakipVm()
            {
                ID = KullaniciKisiselId,
                SuMiktari = double.Parse(txtSu.Text)
            };
            _suTakipService.SuCikarUpdate(suTakipVm);
            UpdateProgressBar();
        }

        private void SuTakipEkrani_Load(object sender, EventArgs e)
        {
            pbSuTakip.Maximum = (int)_kisiselService.GetByIdKisiselSuTakipVm(KullaniciKisiselId).HedefSuMiktari;
            UpdateProgressBar();
        }

        private void UpdateProgressBar()
        {
            double mevcutSuMiktari;

            Su su = _suTakipService.SuKontrol(KullaniciKisiselId, Tarih);
            mevcutSuMiktari = su.SuMiktari;


            if ((int)mevcutSuMiktari > pbSuTakip.Maximum)
            {
                pbSuTakip.Value = pbSuTakip.Maximum;
                lblKalanSu.Text = "";
                MessageBox.Show("Tebrikler 2 litre su içtiniz!");
            }
            else
            {
                pbSuTakip.Value = (int)mevcutSuMiktari;
                lblKalanSu.Text = (pbSuTakip.Maximum - mevcutSuMiktari) + ("mL");
            }
        }
    }
}
