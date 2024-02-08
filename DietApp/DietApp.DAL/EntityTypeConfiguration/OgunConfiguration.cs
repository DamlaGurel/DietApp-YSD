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
    public class OgunConfiguration : IEntityTypeConfiguration<Ogun>
    {
        public void Configure(EntityTypeBuilder<Ogun> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();

            builder.HasOne(x => x.KullaniciKisisel).WithMany(x => x.KullanicininOgunleri).HasForeignKey(x => x.KullaniciKisiselID);
        }
    }
}
