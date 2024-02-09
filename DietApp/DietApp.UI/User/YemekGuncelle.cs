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

        IYemekGuncelleService _service;
        IUserYemekEklemeService _ymkservice;
        YemekListVm _vm;

        public YemekGuncelle(YemekListVm yemekList)
        {
            InitializeComponent();
            _service = new YemekGuncelleService();
            _vm = yemekList;

            _ymkservice = new UserYemekEklemeService();

            cmbYemekGirisi.DataSource = _ymkservice.YemekGetir(-1);
            cmbYemekGirisi.DisplayMember = "YemekAdi";
            cmbYemekGirisi.Text = string.Empty;

            cmbKategori.DataSource = _ymkservice.KategoriGetir();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.Text = string.Empty;


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            double miktar;
            if (double.TryParse(txtMiktar.Text, out miktar))
            {
                YemekGuncelleVm vm = new YemekGuncelleVm()
                {
                    YemekMiktarID=_vm.YemekMiktarID,
                    YemekID = (cmbYemekGirisi.SelectedItem as Yemek).ID,
                    Miktar = miktar
                };
                _service.YemekGuncelle(vm);

                var owner = (this.Owner) as OzetEkrani;
                owner.RefreshDataGrid();
            }
            else
                MessageBox.Show("Bir sayı giriniz!");



        }

        private void YemekGuncelle_Load(object sender, EventArgs e)
        {
            cmbKategori.SelectedItem = _service.KategoriGetir(_vm.KategoriID);
            cmbYemekGirisi.SelectedItem = _service.YemekGetir(_service.YemekMiktarGetir(_vm.YemekMiktarID).YemekID);
            txtMiktar.Text = _vm.Miktar.ToString();

            

        }
    }
}
