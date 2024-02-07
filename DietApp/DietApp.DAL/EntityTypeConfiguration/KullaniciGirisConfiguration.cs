using DietApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.EntityTypeConfiguration
{
    public class KullaniciGirisConfiguration : IEntityTypeConfiguration<KullaniciGiris>
    {
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
        public void Configure(EntityTypeBuilder<KullaniciGiris> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();

            builder.HasData(
new KullaniciGiris { ID = 1, KullaniciAdi = "YalinTuzmen", Sifre = sha256_hash("123")},
new KullaniciGiris { ID = 2, KullaniciAdi = "SilaYildirim", Sifre = sha256_hash("123") },
new KullaniciGiris { ID = 3, KullaniciAdi = "DamlaGurel", Sifre = sha256_hash("123")},
new KullaniciGiris { ID=4,KullaniciAdi="admin",Sifre= sha256_hash("admin") }
);

        }
    }
}
