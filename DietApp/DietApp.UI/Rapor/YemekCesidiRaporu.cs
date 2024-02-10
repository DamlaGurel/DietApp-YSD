using DietApp.BLL.IServices;
using DietApp.BLL.Services;
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

namespace DietApp.UI
{
    public partial class YemekCesidiRaporu : Form
    {
        IUserYemekEklemeService _service;
        RaporlarService _raporService;
        int _kkId;
        public YemekCesidiRaporu(int id)
        {
            InitializeComponent();
            _kkId = id;
            _raporService = new RaporlarService();
            _service = new UserYemekEklemeService();
        }

        private void YemekCesidiRaporu_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = _service.KategoriGetir();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.Text = string.Empty;



        }

        private void cmbYemek_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (cmbKategori.SelectedItem != null)
            {
                string yemekAdi = (cmbYemek.SelectedItem as Yemek)?.YemekAdi ?? string.Empty;
                var rapor = _raporService.YemekCesidiRapor(_kkId, yemekAdi);

                dgvYemekCesidiRaporu.DataSource = rapor;
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbKategori.SelectedItem != null)
            {
                cmbYemek.Enabled = true;
                var list = _service.YemekGetir((cmbKategori.SelectedItem as Kategori).ID);
                list.Insert(0, new Yemek());

                cmbYemek.DataSource = list;
                cmbYemek.DisplayMember = "YemekAdi";
                cmbYemek.Text = string.Empty;
            }
        }
    }
}
