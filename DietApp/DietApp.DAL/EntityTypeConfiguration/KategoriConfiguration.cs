
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
                });
        }
    }
}
