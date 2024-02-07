using DietApp.Entities;
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
    public partial class OzetEkrani : Form
    {
        public KullaniciGiris Kullanici;

        public OzetEkrani(KullaniciGiris kullanici)
        {
            InitializeComponent();
            Kullanici = kullanici;
        }



        private void OzetEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {

        }

        int id;
        private void btnSuTakip_Click(object sender, EventArgs e)
        {
            SuTakipEkrani suTakipEkrani = new SuTakipEkrani(id = 1);
            suTakipEkrani.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UserYemekEklemePaneli userYemekEkleme = new UserYemekEklemePaneli();
            userYemekEkleme.ShowDialog();
        }
    }
}
