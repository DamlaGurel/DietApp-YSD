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
    public class YemekMiktariConfiguration : IEntityTypeConfiguration<YemekMiktari>
    {
        public void Configure(EntityTypeBuilder<YemekMiktari> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x=>x.ID).UseIdentityColumn();
            builder.HasOne(x => x.YenilenYemek).WithMany(x => x.YemekMiktarlari).HasForeignKey(x => x.YemekID);
            builder.HasMany(x => x.YemeginOgunleri).WithOne(x => x.Yemek).HasForeignKey(x => x.OgunID);
                }
    }
}
