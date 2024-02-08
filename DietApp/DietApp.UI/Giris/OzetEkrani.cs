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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Değiştirilmesini istediğiniz bir satırı seçiniz.");
                return;
            }
            else if (dataGridView1.SelectedRows.Count == 1)
            {
                Ogun secilenOgun = (Yeme)dataGridView1.SelectedRows[0].DataBoundItem;

                Yemek ygvm = new Yemek()
                {
                   ID = secilenOgun.,
                };
                YemekGuncelle form = new YemekGuncelle(ygvm);
                form.ShowDialog();
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
    }
}
