using DietApp.Entities;
using DietApp.Enums;
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
    public partial class OzetEkrani : Form
    {
        public KullaniciKisisel _kullanici;

        public OzetEkrani(KullaniciGiris kullanici = null)
        {
            InitializeComponent();
            _kullanici = kullanici.KullaniciKisisel;
            InitializeComboBox();


        }

        private void InitializeComboBox()
        {
            cmbOgun.Items.AddRange(Enum.GetNames(typeof(OgunCesitleri)));
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
            if(cmbOgun.SelectedItem==null) return;
            string secilenOgun = cmbOgun.SelectedItem.ToString();
            UserYemekEklemePaneli userYemekEkleme = new UserYemekEklemePaneli(secilenOgun,dtpTarih.Value);

            userYemekEkleme.ShowDialog();
        }
    }
}
