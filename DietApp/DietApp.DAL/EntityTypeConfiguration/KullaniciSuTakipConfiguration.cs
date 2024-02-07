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
    public class KullaniciSuTakipConfiguration : IEntityTypeConfiguration<Su>
    {
        public void Configure(EntityTypeBuilder<Su> builder)
        {
            builder.HasOne(x => x.KullaniciKisisel).WithMany(x => x.IcilenSu).HasForeignKey(x => x.KullaniciKisiselId);
        }
    }
}
