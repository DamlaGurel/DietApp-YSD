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

namespace DietApp.UI
{
    public partial class UserYemekEklemePaneli : Form
    {
        IUserYemekEklemeService _service;
        public UserYemekEklemePaneli()
        {
            InitializeComponent();
            _service = new UserYemekEklemeService();


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UserYemekEklemePaneliVm userYemekEkleme = new UserYemekEklemePaneliVm()
            {
                YemekID = cmbYemekGirisi.SelectedIndex,
                MiktarGr = double.Parse(txtMiktar.Text)
            };

            //_service.UserYemekEkleme(userYemekEkleme, );
        }

        private void UserYemekEklemePaneli_Load(object sender, EventArgs e)
        {
            cmbYemekGirisi.DataSource = _service.YemekGetir();
            cmbYemekGirisi.DisplayMember = "YemekAdi";
            cmbYemekGirisi.Text = string.Empty;

            cmbKategori.DataSource = _service.KategoriGetir();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.Text = string.Empty;
        }

        private void cmbYemekGirisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
