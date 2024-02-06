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
    internal class UserLoginConfiguration : IEntityTypeConfiguration<KullaniciGiris>
    {
        public void Configure(EntityTypeBuilder<KullaniciGiris> builder)
        {
            throw new NotImplementedException();
        }
    }
}
