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

namespace DietApp.UI
{
    public partial class YemekGuncelle : Form
    {

        IYemekGuncellemeService _service;
       YemekListVm _vm;
        

        public YemekGuncelle()
        {
            InitializeComponent();

            _service = new YemekGuncelleService();
        }
        public YemekGuncelle(YemekListVm yemekList)
        {
            InitializeComponent();
            _service = new YemekGuncelleService();
            _vm = yemekList;
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            YemekMiktari ymk = new YemekMik

            _service.YemekGuncelle(ymk);
            
        }

        private void YemekGuncelle_Load(object sender, EventArgs e)
        {
            cmbKategori.SelectedItem = _service.KategoriGetir(_vm.KategoriID);
            cmbYemekGirisi.SelectedItem = _service.YemekGetir(_service.YemekMiktarGetir(_vm.YemekMiktarID).YemekID);
            txtMiktar.Text = _vm.Miktar.ToString();

            

        }
    }
}
