using DietApp.ViewModels.KullaniciGiris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.IServices
{
    public interface IKullaniciGirisService
    {
        public void KullaniciYarat(KullanicOlusturVm vm);
        bool KullaniciYaratabilirMi(KullanicOlusturVm vm, ref string errorMessage);
        public bool KullaniciGirisYap(KullaniciGirisVm vm);

    }
}
