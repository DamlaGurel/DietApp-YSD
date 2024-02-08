using DietApp.Entities;
using DietApp.ViewModels.KullaniciGiris;

namespace DietApp.BLL.IServices
{
    public interface IKullaniciGirisService
    {
        public int KullaniciYarat(KullanicOlusturVm vm);
        bool KullaniciYaratabilirMi(KullanicOlusturVm vm, ref string errorMessage);
        public bool KullaniciGirisYap(KullaniciGirisVm vm);
        public KullaniciGiris KullaniciBul(string kullaniciAdi);
    }
}
