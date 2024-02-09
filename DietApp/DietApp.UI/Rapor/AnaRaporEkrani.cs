using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp.UI.Rapor
{
    public partial class AnaRaporEkrani : Form
    {
        int _kkId;
        public AnaRaporEkrani(int id)
        {
            InitializeComponent();
            _kkId = id;
        }

        private void btnGunSonu_Click(object sender, EventArgs e)
        {
            GunSonuRapor gunSonuRapor = new GunSonuRapor(_kkId);
            gunSonuRapor.ShowDialog();
        }

        private void btnKiyasRaporlari_Click(object sender, EventArgs e)
        {
            KiyasRaporlari kiyasRaporlari = new KiyasRaporlari(_kkId);
            kiyasRaporlari.ShowDialog();
        }

        private void btnYemekKiyaslamaRaporu_Click(object sender, EventArgs e)
        {
            YemekCesidiRaporu yemekCesidiRaporu = new YemekCesidiRaporu(_kkId);
            yemekCesidiRaporu.ShowDialog();
        }
    }
}
