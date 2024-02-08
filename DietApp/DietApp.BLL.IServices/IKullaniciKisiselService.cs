using DietApp.ViewModels.KullaniciKisiselVms;


namespace DietApp.BLL.IServices
{
    public interface IKullaniciKisiselService
    {
        int Create(KullaniciKisiselCreateVm vm);
        int Update(KullaniciKisiselUpdateVm vm);
        decimal IdealKiloHesapla(KullaniciKisiselVm vm, bool cinsiyet);
        decimal VucutKitleIndeksiHesapla(KullaniciKisiselVm vm);
        KullaniciKisiselUpdateVm GetByID(int id);
        decimal GunlukKaloriIhtiyaci(KullaniciKisiselVm vm);
        KullaniciKisiselSuTakipVm GetByIdKisiselSuTakipVm(int id);
    }
}
