﻿// <auto-generated />
using System;
using DietApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DietApp.DAL.Migrations
{
    [DbContext(typeof(DietAppDBContext))]
    [Migration("20240206152659_a")]
    partial class a
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("KullaniciKisiselID")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciKisiselID")
                        .IsUnique();

                    b.ToTable("KullaniciGiris");
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

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Kilo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Soyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SuMiktari")
                        .HasColumnType("float");

                    b.Property<int>("Yas")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("KullaniciKisisel");
                });

            modelBuilder.Entity("DietApp.Entities.Ogun", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

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

                    b.ToTable("Ogun");
                });

            modelBuilder.Entity("DietApp.Entities.Su", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("KullaniciKisiselID")
                        .HasColumnType("int");

                    b.Property<double>("SuMiktari")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciKisiselID");

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

                    b.Property<double>("Karbonhidrat")
                        .HasColumnType("float");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.Property<double>("Yag")
                        .HasColumnType("float");

                    b.Property<string>("YemekAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Yemek");
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

            modelBuilder.Entity("DietApp.Entities.YemekOgunmiktar", b =>
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

                    b.ToTable("YemekOgunmiktar");
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
                        .HasForeignKey("DietApp.Entities.KullaniciGiris", "KullaniciKisiselID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KullaniciKisisel");
                });

            modelBuilder.Entity("DietApp.Entities.Su", b =>
                {
                    b.HasOne("DietApp.Entities.KullaniciKisisel", null)
                        .WithMany("IcilenSu")
                        .HasForeignKey("KullaniciKisiselID");
                });

            modelBuilder.Entity("DietApp.Entities.Yemek", b =>
                {
                    b.HasOne("DietApp.Entities.Kategori", "Kategori")
                        .WithMany()
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

            modelBuilder.Entity("DietApp.Entities.YemekOgunmiktar", b =>
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