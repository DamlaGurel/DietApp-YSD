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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DietApp.UI
{
    public partial class UserYemekEklemePaneli : Form
    {
        IUserYemekEklemeService _service;
        string _ogunCesidi;
        public UserYemekEklemePaneli()
        {
            InitializeComponent();
            _service = new UserYemekEklemeService();

            
        }
        public UserYemekEklemePaneli(string ogunCesidi)
        {
            InitializeComponent();
            _service = new UserYemekEklemeService();

            _ogunCesidi = ogunCesidi;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Yemek yemek=cmbYemekGirisi.SelectedItem as Yemek;

            UserYemekEklemePaneliVm userYemekEkleme = new UserYemekEklemePaneliVm()
            {
                YemekID = yemek.ID,
                MiktarGr = double.Parse(txtMiktar.Text)
            };
          

            if (Enum.TryParse(_ogunCesidi, out OgunCesitleri ogunCesiti))
            {
               
                Ogun _ogun = new Ogun()
                {
                    OgunAdi = ogunCesiti,
                };
                _service.UserYemekEkleme(userYemekEkleme, _ogun);
            }
        }


        private void UserYemekEklemePaneli_Load(object sender, EventArgs e)
        {
            cmbYemekGirisi.DataSource = _service.YemekGetir();
            cmbYemekGirisi.DisplayMember = "YemekAdi";
            cmbYemekGirisi.Text = string.Empty;

            cmbKategori.DataSource = _service.KategoriGetir();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.Text = string.Empty;

            grpOgunAdi.Text = _ogunCesidi;
        }

        private void cmbYemekGirisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
