using DietApp.ViewModels.VucutIndeksiVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.IServices
{
    public interface IVucutIndeksiService
    {
        int Create(VucutIndeksiCreateVm vm);
        int Update(VucutIndeksiUpdateVm vm);
        decimal IdealKiloHesapla(VucutIndeksiVm vm, bool cinsiyet);
        decimal VucutKitleIndeksiHesapla(VucutIndeksiVm vm);

        VucutIndeksiUpdateVm GetByID(int id);

        decimal GunlukKaloriIhtiyaci(VucutIndeksiVm vm);

    }
}
