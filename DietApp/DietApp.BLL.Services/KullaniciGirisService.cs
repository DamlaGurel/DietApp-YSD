using DietApp.BLL.IServices;
using DietApp.DAL.IRepositories;
using DietApp.DAL.Repositories;
using DietApp.Entities;
using DietApp.ViewModels.KullaniciGiris;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class KullaniciGirisService : IKullaniciGirisService
    {
        IUserRepository _userRepo;
        IKullaniciKisiselRepository _kullaniciKisiselRepository;
        string[] special = new string[] { "!", ":", "+", "*" };

        public KullaniciGirisService()
        {
            _userRepo = new UserRepository();
            _kullaniciKisiselRepository = new KullaniciKisiselRepository();
        }


        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }


        public bool KullaniciYaratabilirMi(KullanicOlusturVm vm, ref string errorMessage)
        {
            bool kullaniciVarMi = _userRepo.GetAll().ToList().Exists(x => x.KullaniciAdi.Equals(vm.KullaniciAdi));

            if (kullaniciVarMi)
            {
                errorMessage = "Bu mail adresiyle kayıtlı bir hesap var,başka bir mail adresi giriniz!";
                return false;
            }


            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(vm.KullaniciAdi))
            {
                errorMessage = "Bir mail adresi giriniz!";
                return false;
            }



            int lowerCount = 0;
            int upperCount = 0;
            int specialCount = 0;
            foreach (char c in vm.Sifre.ToCharArray())
            {
                if (char.IsLower(c))
                {
                    lowerCount++;
                }
                if (char.IsUpper(c))
                {
                    upperCount++;
                }
                if (special.ToList().Contains(new string(c, 1)))
                {
                    specialCount++;
                }


            }

            if (upperCount < 2 && //en az 2 büyük harf olacak
                lowerCount < 3 && //en az 3 küçük harf olacak
                specialCount < 2 && // en az 2 özel karakteri olacak
                vm.Sifre.Length < 8 // en az 8 karakter uzunluğunda olacak
                )
            {
                errorMessage = "Şifreniz en az 3 küçük harf,2 büyük harf ve 2 özel karakter(!,:,+,*) içermelidir!";
                return false;
            }



            return true;
        }
        public int KullaniciYarat(KullanicOlusturVm vm)
        {
            KullaniciGiris kullanici = new KullaniciGiris()
            {
                KullaniciAdi = vm.KullaniciAdi,
                Sifre = sha256_hash(vm.Sifre),
            };

            int kgId = _userRepo.Create(kullanici);

            return kgId;
        }

        public bool KullaniciGirisYap(KullaniciGirisVm vm)
        {
            KullaniciGiris kullanici = _userRepo.GetAll().ToList().Find(x => x.KullaniciAdi.Equals(vm.KullaniciAdi));
            if (kullanici == null)
            {
                Debug.WriteLine("Kullanici Adi Hatali");
                return false;
            }

            if (kullanici.Sifre != sha256_hash(vm.Password))
            {

                return false;
            }

            return true;

        }
        public KullaniciGiris KullaniciBul(string kullaniciAdi)
        {
            KullaniciGiris kullanici = _userRepo.GetAll().ToList().Find(x => x.KullaniciAdi.Equals(kullaniciAdi));

            return kullanici;
        }


    }
}
