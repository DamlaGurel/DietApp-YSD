using DietApp.ViewModels.KullaniciKisiselVms;


namespace DietApp.BLL.IServices
{
    public interface IKullaniciKisiselService
    {
        int Create(KullaniciKisiselCreateVm vm);
        int Update(KullaniciKisiselUpdateVm vm);
        double IdealKiloHesapla(KullaniciKisiselVm vm, bool cinsiyet);
        double VucutKitleIndeksiHesapla(KullaniciKisiselVm vm);
        KullaniciKisiselUpdateVm GetByID(int id);
        double GunlukKaloriIhtiyaci(KullaniciKisiselVm vm);
        KullaniciKisiselSuTakipVm GetByIdKisiselSuTakipVm(int id);
    }
}
