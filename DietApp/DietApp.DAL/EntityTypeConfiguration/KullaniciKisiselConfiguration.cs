using DietApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.EntityTypeConfiguration
{
    internal class KullaniciKisiselConfiguration : IEntityTypeConfiguration<KullaniciKisisel>
    {
        public void Configure(EntityTypeBuilder<KullaniciKisisel> builder)
        {

            builder.HasOne(x => x.KullaniciGiris).WithOne(x => x.KullaniciKisisel).HasForeignKey<KullaniciKisisel>(x=>x.KullaniciGirisID);

            builder.HasData(
                new KullaniciKisisel()
                {
                    ID = 1,
                    HedefKilo = 70,
                    Boy = 170,
                    Cinsiyet = false,
                    BaslangicTarihi = DateTime.Now,
                    GunlukKalori = 3000,
                    Isim = "ahmet",
                    Kilo = 80,
                    Soyisim = "mehmet",
                    Yas = 18,
                    HedefSuMiktari = 2000,
                    KullaniciGirisID = 1
                } ,
                new KullaniciKisisel()
                {
                    ID = 2,
                    HedefKilo = 70,
                    Boy = 170,
                    Cinsiyet = false,
                    BaslangicTarihi = DateTime.Now,
                    GunlukKalori = 3000,
                    Isim = "ahmet",
                    Kilo = 80,
                    Soyisim = "mehmet",
                    Yas = 18,
                    HedefSuMiktari = 2000,
                    KullaniciGirisID = 2
                }, 
                new KullaniciKisisel()
                {
                    ID = 3,
                    HedefKilo = 70,
                    Boy = 170,
                    Cinsiyet = false,
                    BaslangicTarihi = DateTime.Now,
                    GunlukKalori = 3000,
                    Isim = "ahmet",
                    Kilo = 80,
                    Soyisim = "mehmet",
                    Yas = 18,
                    HedefSuMiktari = 2000,
                    KullaniciGirisID = 3
                },
                new KullaniciKisisel()
                {
                    ID = 4,
                    HedefKilo = 70,
                    Boy = 170,
                    Cinsiyet = false,
                    BaslangicTarihi = DateTime.Now,
                    GunlukKalori = 3000,
                    Isim = "ahmet",
                    Kilo = 80,
                    Soyisim = "mehmet",
                    Yas = 18,
                    HedefSuMiktari = 2000,
                    KullaniciGirisID = 4
                },
                new KullaniciKisisel()
                {
                    ID = 5,
                    HedefKilo = 70,
                    Boy = 170,
                    Cinsiyet = false,
                    BaslangicTarihi = DateTime.Now,
                    GunlukKalori = 3000,
                    Isim = "admin",
                    Kilo = 80,
                    Soyisim = "adminoğlu",
                    Yas = 18,
                    HedefSuMiktari = 2000,
                    KullaniciGirisID=5
                }





                );
        }
    }
}
