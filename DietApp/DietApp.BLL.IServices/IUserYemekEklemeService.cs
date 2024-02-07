using DietApp.Entities;
using DietApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.IServices
{
    public interface IUserYemekEklemeService
    {
        void UserYemekEkleme(UserYemekEklemePaneliVm userYemekEkleme, Ogun ogun);
    }
}
