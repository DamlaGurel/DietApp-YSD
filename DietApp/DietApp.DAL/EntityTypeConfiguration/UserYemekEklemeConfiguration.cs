using DietApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.EntityTypeConfiguration
{
    public class UserYemekEklemeConfiguration : IEntityTypeConfiguration<Yemek>
    {
        public void Configure(EntityTypeBuilder<Yemek> builder)
        {
            builder.HasOne(x => x.Kategori).WithMany(x => x.KategorininYemekListesi).HasForeignKey(x => x.KategoriID);

            builder.HasData(
                new Yemek()
                {
                    ID = 1,
                    KategoriID = 1,
                    YemekAdi = "Elma",
                    KarbonhidratMiktari = 19,
                    ProteinMiktari = 0.3,
                    YagMiktari = 0.3,
                    Kalori = 95,
                    FotografYolu = "Fotograflar\\Elma.jpg"
                });
        }
    }
}
