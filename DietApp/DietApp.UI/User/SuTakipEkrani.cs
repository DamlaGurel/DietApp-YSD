using DietApp.BLL.IServices;
using DietApp.BLL.Services;
using DietApp.Entities;
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

        public SuTakipEkrani(int id = 1)
        {
            InitializeComponent();
            _suTakipService = new KullaniciSuTakipService();
            _kisiselService = new KullaniciKisiselService();
            KullaniciKisiselId = id;
        }

        private void btnSuEkle_Click(object sender, EventArgs e)
        {
            if (_suTakipService.GetById(KullaniciKisiselId) == null)
            {
                SuTakipVm suTakipVm = new SuTakipVm()
                {
                    ID = KullaniciKisiselId,
                    SuMiktari = double.Parse(txtSu.Text)
                };
                _suTakipService.Create(suTakipVm);
            }
            else
            {
                SuTakipVm suTakipVm = new SuTakipVm()
                {
                    ID = KullaniciKisiselId,
                    SuMiktari = double.Parse(txtSu.Text)
                };
                _suTakipService.SuEkleUpdate(suTakipVm);
            }
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
            pbSuTakip.Maximum =(int)_kisiselService.GetByIdKisiselSuTakipVm(KullaniciKisiselId).HedefSuMiktari;
            UpdateProgressBar();
        }

        private void UpdateProgressBar()
        {
            double mevcutSuMiktari;
            if (_suTakipService.GetById(KullaniciKisiselId) == null)
                mevcutSuMiktari = 0;
            else
                 mevcutSuMiktari = _suTakipService.GetById(KullaniciKisiselId).SuMiktari;

            pbSuTakip.Value = (int)mevcutSuMiktari;
            lblKalanSu.Text = (pbSuTakip.Maximum - mevcutSuMiktari) + ("mL");
        }
    }
}
