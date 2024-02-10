using DietApp.Entities;
using DietApp.Enums;
using DietApp.ViewModels;
using DietApp.ViewModels.Raporlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.IServices
{
    public interface IRaporlarService
    {
        List<GunlukRaporVm> GunlukRapor(int id, DateTime gun);
        List<YemekCesidiRaporuVm> YemekCesidiRapor(int id,string yemek);
    }
}
