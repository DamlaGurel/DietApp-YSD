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

            // optionsBuilder.UseSqlServer(@"Server=DESKTOP-VU62QDF\SQLSERVERMS; Database=WF1DB-YSD; Uid=sa; Pwd=123;");

            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-G2S16HQ; Database=WF1DB-YSD; Uid=sa; Pwd=123;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BesinDegeri>();
            modelBuilder.Entity<GunlukRapor>();
            modelBuilder.Entity<Kategori>();
            modelBuilder.Entity<KullaniciGiris>();
            modelBuilder.Entity<KullaniciKisisel>().HasOne(x=>x.KullaniciGiris).WithOne(x=>x.KullaniciKisisel).HasForeignKey<KullaniciGiris>(x=>x.KullaniciKisiselID);
            modelBuilder.Entity<Ogun>();
            modelBuilder.Entity<Su>();
            modelBuilder.Entity<Yemek>();
            modelBuilder.Entity<YemekMiktari>();
            modelBuilder.Entity<YemekMiktarOgun>().HasOne(yo => yo.Yemek).WithMany(y => y.YemeginOgunleri).HasForeignKey(yo => yo.YemekMiktarID).HasForeignKey(yo => yo.OgunID);



        }
    }
}
