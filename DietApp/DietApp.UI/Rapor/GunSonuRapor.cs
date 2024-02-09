using DietApp.BLL.Services;
using DietApp.ViewModels.Raporlar;
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
    public partial class GunSonuRapor : Form
    {
        RaporlarService _raporService;
        int _kkId;
        public GunSonuRapor(int id)
        {
            InitializeComponent();
            _kkId = id;
            _raporService = new RaporlarService();
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {   
            var gunlukRapor = _raporService.GunlukRapor(_kkId, dtpTarih.Value);
            dgvListe.DataSource = gunlukRapor;
        }
    }
}
