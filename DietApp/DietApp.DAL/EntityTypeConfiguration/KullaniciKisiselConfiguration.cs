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
            // modelBuilder.Entity<KullaniciKisisel>().HasOne(x => x.KullaniciGiris).WithOne(x => x.KullaniciKisisel).HasForeignKey<KullaniciGiris>(x => x.KullaniciKisiselID);

            builder.HasOne(x => x.KullaniciGiris).WithOne(x => x.KullaniciKisisel).HasForeignKey<KullaniciGiris>(x => x.KullaniciKisiselID);

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
                }
                );
        }
    }
}
