using DietApp.DAL.EntityTypeConfiguration;
using DietApp.Entities;
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
        //DbSet<BesinDegeri> besinDegerleri;
        DbSet<GunlukRapor> gunlukRaporlari;
        DbSet<Kategori> kategoriler;
        DbSet<KullaniciGiris> kullaniciGirisleri;
        DbSet<KullaniciKisisel> kullaniciKisiseller;
        DbSet<Ogun> ogunler;
        DbSet<OgunKullanici> ogunKullanicilar;
        DbSet<Su> sular;
        DbSet<Yemek> yemekler;
        DbSet<YemekMiktari> yemekMiktarlari;
        DbSet<YemekMiktarOgun> yemekOgunleri;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

       optionsBuilder.UseSqlServer(@"Server=DESKTOP-LLGUTIH; Database=WF1DB-YSD; Uid=sa; Pwd=123;");
         //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-VU62QDF\SQLSERVERMS; Database=WF1DB-YSD; Uid=sa; Pwd=123;");

          //  optionsBuilder.UseSqlServer(@"Server=DESKTOP-G2S16HQ; Database=WF1DB-YSD; Uid=sa; Pwd=123;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<GunlukRapor>();
            modelBuilder.Entity<Kategori>();
            modelBuilder.ApplyConfiguration(new KullaniciGirisConfiguration());

            modelBuilder.ApplyConfiguration(new KategoriConfiguration());
            modelBuilder.Entity<KullaniciGiris>();
            modelBuilder.ApplyConfiguration(new KullaniciKisiselConfiguration());
            modelBuilder.Entity<Ogun>();

            modelBuilder.ApplyConfiguration(new KullaniciSuTakipConfiguration());

            modelBuilder.ApplyConfiguration(new UserYemekEklemeConfiguration());

            modelBuilder.ApplyConfiguration(new YemekMiktariConfiguration());
            modelBuilder.Entity<YemekMiktarOgun>().HasOne(yo => yo.Yemek).WithMany(y => y.YemeginOgunleri).HasForeignKey(yo => yo.OgunID).HasForeignKey(yo => yo.YemekMiktarID);

        }
    }
}
