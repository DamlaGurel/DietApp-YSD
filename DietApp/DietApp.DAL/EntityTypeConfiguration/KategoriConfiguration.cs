
using DietApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.EntityTypeConfiguration
{
    public class KategoriConfiguration : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasMany(x => x.KategorininYemekListesi).WithOne(x => x.Kategori).HasForeignKey(x => x.KategoriID);

            builder.HasData(
                new Kategori()
                {
                    ID = 1,
                    KategoriAdi = "Meyve",
                },
                new Kategori()
                {
                    ID = 2,
                    KategoriAdi = "Bakliyat",
                },
                new Kategori()
                {
                    ID = 3,
                    KategoriAdi = "HazirYemek",
                },
                new Kategori()
                {
                    ID = 4,
                    KategoriAdi = "Kahvaltilik",
                },
                new Kategori()
                {
                    ID = 5,
                    KategoriAdi = "Sebze",
                });
        }
    }
}
