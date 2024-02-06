using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL
{
    public class DietAppDBContext : DbContext
    {

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            // optionsBuilder.UseSqlServer(@"Server=DESKTOP-LLGUTIH; Database=EFMARATONDB; Uid=sa; Pwd=123;");

            // optionsBuilder.UseSqlServer(@"Server=DESKTOP-VU62QDF; Database=EFMARATONDB; Uid=sa; Pwd=123;");

            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-G2S16HQ; Database=EFMARATONDB; Uid=sa; Pwd=123;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
