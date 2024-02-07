﻿// <auto-generated />
using System;
using DietApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DietApp.DAL.Migrations
{
    [DbContext(typeof(DietAppDBContext))]
    partial class DietAppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DietApp.Entities.GunlukRapor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<double>("Kalori")
                        .HasColumnType("float");

                    b.Property<double>("KarbonhidratMiktari")
                        .HasColumnType("float");

                    b.Property<int?>("KullaniciKisiselID")
                        .HasColumnType("int");

                    b.Property<double>("ProteinMiktari")
                        .HasColumnType("float");

                    b.Property<DateTime>("SecilenRaporTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("SuMiktari")
                        .HasColumnType("int");

                    b.Property<double>("YagMiktari")
                        .HasColumnType("float");

                    b.Property<string>("YemekAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciKisiselID");

                    b.ToTable("GunlukRapor");
                });

            modelBuilder.Entity("DietApp.Entities.Kategori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Kategori");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            KategoriAdi = "Meyve"
                        });
                });

            modelBuilder.Entity("DietApp.Entities.KullaniciGiris", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KullaniciKisiselID")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciKisiselID")
                        .IsUnique()
                        .HasFilter("[KullaniciKisiselID] IS NOT NULL");

                    b.ToTable("KullaniciGiris");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            KullaniciAdi = "YalinTuzmen",
                            Sifre = "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3"
                        },
                        new
                        {
                            ID = 2,
                            KullaniciAdi = "SilaYildirim",
                            Sifre = "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3"
                        },
                        new
                        {
                            ID = 3,
                            KullaniciAdi = "DamlaGurel",
                            Sifre = "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3"
                        },
                        new
                        {
                            ID = 4,
                            KullaniciAdi = "admin",
                            Sifre = "8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918"
                        });
                });

            modelBuilder.Entity("DietApp.Entities.KullaniciKisisel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Boy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<double>("GunlukKalori")
                        .HasColumnType("float");

                    b.Property<decimal>("HedefKilo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("HedefSuMiktari")
                        .HasColumnType("float");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Kilo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Soyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Yas")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("KullaniciKisisel");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BaslangicTarihi = new DateTime(2024, 2, 7, 17, 42, 56, 886, DateTimeKind.Local).AddTicks(4299),
                            BitisTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Boy = 170m,
                            Cinsiyet = false,
                            GunlukKalori = 3000.0,
                            HedefKilo = 70m,
                            HedefSuMiktari = 2000.0,
                            Isim = "ahmet",
                            Kilo = 80m,
                            Soyisim = "mehmet",
                            Yas = 18
                        });
                });

            modelBuilder.Entity("DietApp.Entities.Ogun", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("GunlukRaporID")
                        .HasColumnType("int");

                    b.Property<double>("Kalori")
                        .HasColumnType("float");

                    b.Property<double>("KarbonhidratMiktari")
                        .HasColumnType("float");

                    b.Property<int>("OgunAdi")
                        .HasColumnType("int");

                    b.Property<double>("ProteinMiktari")
                        .HasColumnType("float");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<double>("YagMiktari")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("GunlukRaporID");

                    b.ToTable("Ogun");
                });

            modelBuilder.Entity("DietApp.Entities.Su", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("KullaniciKisiselId")
                        .HasColumnType("int");

                    b.Property<double>("SuMiktari")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciKisiselId");

                    b.ToTable("Su");
                });

            modelBuilder.Entity("DietApp.Entities.Yemek", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<double>("Kalori")
                        .HasColumnType("float");

                    b.Property<double>("KarbonhidratMiktari")
                        .HasColumnType("float");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<double>("ProteinMiktari")
                        .HasColumnType("float");

                    b.Property<double>("YagMiktari")
                        .HasColumnType("float");

                    b.Property<string>("YemekAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Yemek");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Kalori = 95.0,
                            KarbonhidratMiktari = 19.0,
                            KategoriID = 1,
                            ProteinMiktari = 0.29999999999999999,
                            YagMiktari = 0.29999999999999999,
                            YemekAdi = "Elma"
                        });
                });

            modelBuilder.Entity("DietApp.Entities.YemekMiktari", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<double>("Kalori")
                        .HasColumnType("float");

                    b.Property<double>("KarbonhidratMiktari")
                        .HasColumnType("float");

                    b.Property<double>("MiktarGr")
                        .HasColumnType("float");

                    b.Property<double>("ProteinMiktari")
                        .HasColumnType("float");

                    b.Property<double>("YagMiktari")
                        .HasColumnType("float");

                    b.Property<int>("YenilenYemekID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("YenilenYemekID");

                    b.ToTable("YemekMiktari");
                });

            modelBuilder.Entity("DietApp.Entities.YemekMiktarOgun", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("OgunID")
                        .HasColumnType("int");

                    b.Property<int>("OgunID1")
                        .HasColumnType("int");

                    b.Property<int>("YemekMiktarID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OgunID");

                    b.HasIndex("OgunID1");

                    b.ToTable("YemekMiktarOgun");
                });

            modelBuilder.Entity("KullaniciKisiselOgun", b =>
                {
                    b.Property<int>("KullanicilarinOgunleriID")
                        .HasColumnType("int");

                    b.Property<int>("OgunlerinKullanicilariID")
                        .HasColumnType("int");

                    b.HasKey("KullanicilarinOgunleriID", "OgunlerinKullanicilariID");

                    b.HasIndex("OgunlerinKullanicilariID");

                    b.ToTable("KullaniciKisiselOgun");
                });

            modelBuilder.Entity("DietApp.Entities.GunlukRapor", b =>
                {
                    b.HasOne("DietApp.Entities.KullaniciKisisel", null)
                        .WithMany("KullanicininRaporlari")
                        .HasForeignKey("KullaniciKisiselID");
                });

            modelBuilder.Entity("DietApp.Entities.KullaniciGiris", b =>
                {
                    b.HasOne("DietApp.Entities.KullaniciKisisel", "KullaniciKisisel")
                        .WithOne("KullaniciGiris")
                        .HasForeignKey("DietApp.Entities.KullaniciGiris", "KullaniciKisiselID");

                    b.Navigation("KullaniciKisisel");
                });

            modelBuilder.Entity("DietApp.Entities.Ogun", b =>
                {
                    b.HasOne("DietApp.Entities.GunlukRapor", null)
                        .WithMany("GunlukRaporunOgunListesi")
                        .HasForeignKey("GunlukRaporID");
                });

            modelBuilder.Entity("DietApp.Entities.Su", b =>
                {
                    b.HasOne("DietApp.Entities.KullaniciKisisel", "KullaniciKisisel")
                        .WithMany("IcilenSu")
                        .HasForeignKey("KullaniciKisiselId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KullaniciKisisel");
                });

            modelBuilder.Entity("DietApp.Entities.Yemek", b =>
                {
                    b.HasOne("DietApp.Entities.Kategori", "Kategori")
                        .WithMany("KategorininYemekListesi")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DietApp.Entities.YemekMiktari", b =>
                {
                    b.HasOne("DietApp.Entities.Yemek", "YenilenYemek")
                        .WithMany()
                        .HasForeignKey("YenilenYemekID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YenilenYemek");
                });

            modelBuilder.Entity("DietApp.Entities.YemekMiktarOgun", b =>
                {
                    b.HasOne("DietApp.Entities.YemekMiktari", "Yemek")
                        .WithMany("YemeginOgunleri")
                        .HasForeignKey("OgunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietApp.Entities.Ogun", "Ogun")
                        .WithMany("OgununYemekleri")
                        .HasForeignKey("OgunID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogun");

                    b.Navigation("Yemek");
                });

            modelBuilder.Entity("KullaniciKisiselOgun", b =>
                {
                    b.HasOne("DietApp.Entities.Ogun", null)
                        .WithMany()
                        .HasForeignKey("KullanicilarinOgunleriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietApp.Entities.KullaniciKisisel", null)
                        .WithMany()
                        .HasForeignKey("OgunlerinKullanicilariID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DietApp.Entities.GunlukRapor", b =>
                {
                    b.Navigation("GunlukRaporunOgunListesi");
                });

            modelBuilder.Entity("DietApp.Entities.Kategori", b =>
                {
                    b.Navigation("KategorininYemekListesi");
                });

            modelBuilder.Entity("DietApp.Entities.KullaniciKisisel", b =>
                {
                    b.Navigation("IcilenSu");

                    b.Navigation("KullaniciGiris")
                        .IsRequired();

                    b.Navigation("KullanicininRaporlari");
                });

            modelBuilder.Entity("DietApp.Entities.Ogun", b =>
                {
                    b.Navigation("OgununYemekleri");
                });

            modelBuilder.Entity("DietApp.Entities.YemekMiktari", b =>
                {
                    b.Navigation("YemeginOgunleri");
                });
#pragma warning restore 612, 618
        }
    }
}
