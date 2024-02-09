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
    }
}
