using DietApp.Entities;
using DietApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.IServices
{
    public interface IKullaniciSuTakipService
    {
        int Create(SuTakipVm vm);
        int SuEkleUpdate(SuTakipVm vm);
        int SuCikarUpdate(SuTakipVm vm);
        Su GetById(int id);
        Su SuKontrol(int kkID, DateTime tarih);
    }
}
