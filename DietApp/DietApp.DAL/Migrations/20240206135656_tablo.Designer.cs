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
    [Migration("20240206135656_tablo")]
    partial class tablo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DietApp.Entities.BesinDegeri", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Kalori")
                        .HasColumnType("float");

                    b.Property<double>("KarbonhidratMiktari")
                        .HasColumnType("float");

                    b.Property<double>("ProteinMiktari")
                        .HasColumnType("float");

                    b.Property<double>("YagMiktari")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("BesinDegeri");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BesinDegeri");
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

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

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

            modelBuilder.Entity("DietApp.Entities.OgunKullanici", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int>("OgunID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciID");

                    b.HasIndex("OgunID");

                    b.ToTable("OgunKullanici");
                });

            modelBuilder.Entity("DietApp.Entities.Su", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<double>("SuMiktari")
                        .HasColumnType("float");

                    b.HasKey("ID");

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

            modelBuilder.Entity("DietApp.Entities.YemekOgun", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("OgunID")
                        .HasColumnType("int");

                    b.Property<int>("YemekID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OgunID");

                    b.HasIndex("YemekID");

                    b.ToTable("YemekOgun");
                });

            modelBuilder.Entity("DietApp.Entities.GunlukRapor", b =>
                {
                    b.HasBaseType("DietApp.Entities.BesinDegeri");

                    b.Property<DateTime>("SecilenRaporTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("SuMiktari")
                        .HasColumnType("int");

                    b.Property<string>("YemekAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("GunlukRapor");
                });

            modelBuilder.Entity("DietApp.Entities.Ogun", b =>
                {
                    b.HasBaseType("DietApp.Entities.BesinDegeri");

                    b.Property<int>("OgunAdi")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Ogun");
                });

            modelBuilder.Entity("DietApp.Entities.YemekMiktari", b =>
                {
                    b.HasBaseType("DietApp.Entities.BesinDegeri");

                    b.Property<double>("MiktarGr")
                        .HasColumnType("float");

                    b.Property<int>("YenilenYemekID")
                        .HasColumnType("int");

                    b.HasIndex("YenilenYemekID");

                    b.HasDiscriminator().HasValue("YemekMiktari");
                });

            modelBuilder.Entity("DietApp.Entities.OgunKullanici", b =>
                {
                    b.HasOne("DietApp.Entities.KullaniciKisisel", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietApp.Entities.Ogun", "Ogun")
                        .WithMany()
                        .HasForeignKey("OgunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Ogun");
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

            modelBuilder.Entity("DietApp.Entities.YemekOgun", b =>
                {
                    b.HasOne("DietApp.Entities.Ogun", "Ogun")
                        .WithMany()
                        .HasForeignKey("OgunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietApp.Entities.Yemek", "Yemek")
                        .WithMany()
                        .HasForeignKey("YemekID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogun");

                    b.Navigation("Yemek");
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
#pragma warning restore 612, 618
        }
    }
}
