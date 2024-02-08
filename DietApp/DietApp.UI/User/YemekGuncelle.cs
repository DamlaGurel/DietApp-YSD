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
       


        public YemekGuncelle()
        {
            InitializeComponent();

            _service = new YemekGuncelleService();
        }
        public YemekGuncelle(YemekGuncelleVm yemekGuncelleVm)
        {
            InitializeComponent();
            _service = new YemekGuncelleService();
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            YemekGuncelleVm yemekGuncelle = new YemekGuncelleVm()
            {
                YemekID = _ygvm.YemekID,
                MiktarGr = _ygvm.MiktarGr,
                OgunAdi = _ygvm.OgunAdi
            };

            _service.YemekGuncelle(yemekGuncelle);
            
        }

        private void YemekGuncelle_Load(object sender, EventArgs e)
        {
            txtMiktar.Text = _ygvm.MiktarGr.ToString();
                
        }
    }
}
