using DietApp.BLL.Services;
using DietApp.Entities;
using DietApp.Enums;
using DietApp.ViewModels;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DietApp.UI
{
    public partial class OzetEkrani : Form
    {
        public KullaniciGiris _kullanici;

        public OzetEkrani(KullaniciGiris kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            InitializeComboBox();


        }

        public void RefreshDataGrid()
        {
            if (cmbOgun.SelectedItem == null) return;
            if (Enum.TryParse(cmbOgun.SelectedItem.ToString(), out OgunCesitleri ogunCesiti))
            {
                dgv_OgundekiYemekler.DataSource = new YemekMiktariService().YemekleriGetir(dtpTarih.Value, ogunCesiti);

                dgv_OgundekiYemekler.Columns["ID"].Visible = false;
                dgv_OgundekiYemekler.Columns["YemekMiktarID"].Visible = false;
                dgv_OgundekiYemekler.Columns["KategoriID"].Visible = false;
            }

        }

        private void InitializeComboBox()
        {
            cmbOgun.Items.AddRange(Enum.GetNames(typeof(OgunCesitleri)));
        }

        private void OzetEkrani_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (dgv_OgundekiYemekler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Değiştirilmesini istediğiniz bir satırı seçiniz.");
                return;
            }
            else if (dgv_OgundekiYemekler.SelectedRows.Count == 1)
            {
                YemekListVm secilenOgun = (YemekListVm)dgv_OgundekiYemekler.SelectedRows[0].DataBoundItem;


                YemekGuncelle form = new YemekGuncelle(secilenOgun);
                form.ShowDialog(this);
            }

        }

        int id;
        private void btnSuTakip_Click(object sender, EventArgs e)
        {
            SuTakipEkrani suTakipEkrani = new SuTakipEkrani(id = 1);
            suTakipEkrani.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbOgun.SelectedItem == null) return;
            string secilenOgun = cmbOgun.SelectedItem.ToString();



            UserYemekEklemePaneli userYemekEkleme = new UserYemekEklemePaneli(secilenOgun, dtpTarih.Value, _kullanici.KullaniciKisiselID);
            userYemekEkleme.ShowDialog(this);
        }

        private void cmbOgun_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            if (cmbOgun.SelectedItem == null) return;

            YemekListVm secilenOgun = (YemekListVm)dgv_OgundekiYemekler.SelectedRows[0].DataBoundItem;


        }
    }
}
