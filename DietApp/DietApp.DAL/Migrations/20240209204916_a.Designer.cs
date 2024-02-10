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
<<<<<<<< HEAD:DietApp/DietApp.DAL/Migrations/20240209204916_a.Designer.cs
    [Migration("20240209204916_a")]
    partial class a
========
    [Migration("20240209211420_initial")]
    partial class initial
>>>>>>>> sila:DietApp/DietApp.DAL/Migrations/20240209211420_initial.Designer.cs
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

                    b.HasData(
                        new
                        {
                            ID = 1,
                            KategoriAdi = "Meyve"
                        },
                        new
                        {
                            ID = 2,
                            KategoriAdi = "Bakliyat"
                        },
                        new
                        {
                            ID = 3,
                            KategoriAdi = "HazirYemek"
                        },
                        new
                        {
                            ID = 4,
                            KategoriAdi = "Kahvaltilik"
                        },
                        new
                        {
                            ID = 5,
                            KategoriAdi = "Sebze"
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

                    b.Property<int>("KullaniciKisiselID")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("KullaniciGiris");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            KullaniciAdi = "YalinTuzmen",
                            KullaniciKisiselID = 1,
                            Sifre = "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3"
                        },
                        new
                        {
                            ID = 2,
                            KullaniciAdi = "SilaYildirim",
                            KullaniciKisiselID = 2,
                            Sifre = "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3"
                        },
                        new
                        {
                            ID = 3,
                            KullaniciAdi = "DamlaGurel",
                            KullaniciKisiselID = 3,
                            Sifre = "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3"
                        },
                        new
                        {
                            ID = 4,
                            KullaniciAdi = "admin",
                            KullaniciKisiselID = 4,
                            Sifre = "8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918"
                        },
                        new
                        {
                            ID = 5,
                            KullaniciAdi = "a",
                            KullaniciKisiselID = 5,
                            Sifre = "CA978112CA1BBDCAFAC231B39A23DC4DA786EFF8147C4E72B9807785AFEE48BB"
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

                    b.Property<double>("Boy")
                        .HasColumnType("float");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<double>("GunlukKalori")
                        .HasColumnType("float");

                    b.Property<double>("HedefKilo")
                        .HasColumnType("float");

                    b.Property<double>("HedefSuMiktari")
                        .HasColumnType("float");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Kilo")
                        .HasColumnType("float");

                    b.Property<int>("KullaniciGirisID")
                        .HasColumnType("int");

                    b.Property<string>("Soyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Yas")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciGirisID")
                        .IsUnique();

                    b.ToTable("KullaniciKisisel");

                    b.HasData(
                        new
                        {
                            ID = 1,
<<<<<<<< HEAD:DietApp/DietApp.DAL/Migrations/20240209204916_a.Designer.cs
                            BaslangicTarihi = new DateTime(2024, 2, 9, 23, 49, 16, 304, DateTimeKind.Local).AddTicks(7040),
========
                            BaslangicTarihi = new DateTime(2024, 2, 10, 0, 14, 19, 327, DateTimeKind.Local).AddTicks(9108),
>>>>>>>> sila:DietApp/DietApp.DAL/Migrations/20240209211420_initial.Designer.cs
                            BitisTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Boy = 170.0,
                            Cinsiyet = false,
                            GunlukKalori = 3000.0,
                            HedefKilo = 70.0,
                            HedefSuMiktari = 2000.0,
                            Isim = "ahmet",
                            Kilo = 80.0,
                            KullaniciGirisID = 1,
                            Soyisim = "mehmet",
                            Yas = 18
                        },
                        new
                        {
                            ID = 2,
<<<<<<<< HEAD:DietApp/DietApp.DAL/Migrations/20240209204916_a.Designer.cs
                            BaslangicTarihi = new DateTime(2024, 2, 9, 23, 49, 16, 304, DateTimeKind.Local).AddTicks(7048),
========
                            BaslangicTarihi = new DateTime(2024, 2, 10, 0, 14, 19, 327, DateTimeKind.Local).AddTicks(9126),
>>>>>>>> sila:DietApp/DietApp.DAL/Migrations/20240209211420_initial.Designer.cs
                            BitisTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Boy = 170.0,
                            Cinsiyet = false,
                            GunlukKalori = 3000.0,
                            HedefKilo = 70.0,
                            HedefSuMiktari = 2000.0,
                            Isim = "ahmet",
                            Kilo = 80.0,
                            KullaniciGirisID = 2,
                            Soyisim = "mehmet",
                            Yas = 18
                        },
                        new
                        {
                            ID = 3,
<<<<<<<< HEAD:DietApp/DietApp.DAL/Migrations/20240209204916_a.Designer.cs
                            BaslangicTarihi = new DateTime(2024, 2, 9, 23, 49, 16, 304, DateTimeKind.Local).AddTicks(7050),
========
                            BaslangicTarihi = new DateTime(2024, 2, 10, 0, 14, 19, 327, DateTimeKind.Local).AddTicks(9128),
>>>>>>>> sila:DietApp/DietApp.DAL/Migrations/20240209211420_initial.Designer.cs
                            BitisTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Boy = 170.0,
                            Cinsiyet = false,
                            GunlukKalori = 3000.0,
                            HedefKilo = 70.0,
                            HedefSuMiktari = 2000.0,
                            Isim = "ahmet",
                            Kilo = 80.0,
                            KullaniciGirisID = 3,
                            Soyisim = "mehmet",
                            Yas = 18
                        },
                        new
                        {
                            ID = 4,
<<<<<<<< HEAD:DietApp/DietApp.DAL/Migrations/20240209204916_a.Designer.cs
                            BaslangicTarihi = new DateTime(2024, 2, 9, 23, 49, 16, 304, DateTimeKind.Local).AddTicks(7051),
========
                            BaslangicTarihi = new DateTime(2024, 2, 10, 0, 14, 19, 327, DateTimeKind.Local).AddTicks(9130),
>>>>>>>> sila:DietApp/DietApp.DAL/Migrations/20240209211420_initial.Designer.cs
                            BitisTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Boy = 170.0,
                            Cinsiyet = false,
                            GunlukKalori = 3000.0,
                            HedefKilo = 70.0,
                            HedefSuMiktari = 2000.0,
                            Isim = "ahmet",
                            Kilo = 80.0,
                            KullaniciGirisID = 4,
                            Soyisim = "mehmet",
                            Yas = 18
                        },
                        new
                        {
                            ID = 5,
<<<<<<<< HEAD:DietApp/DietApp.DAL/Migrations/20240209204916_a.Designer.cs
                            BaslangicTarihi = new DateTime(2024, 2, 9, 23, 49, 16, 304, DateTimeKind.Local).AddTicks(7052),
========
                            BaslangicTarihi = new DateTime(2024, 2, 10, 0, 14, 19, 327, DateTimeKind.Local).AddTicks(9131),
>>>>>>>> sila:DietApp/DietApp.DAL/Migrations/20240209211420_initial.Designer.cs
                            BitisTarihi = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Boy = 170.0,
                            Cinsiyet = false,
                            GunlukKalori = 3000.0,
                            HedefKilo = 70.0,
                            HedefSuMiktari = 2000.0,
                            Isim = "admin",
                            Kilo = 80.0,
                            KullaniciGirisID = 5,
                            Soyisim = "adminoğlu",
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

                    b.Property<int>("KullaniciKisiselID")
                        .HasColumnType("int");

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

                    b.HasIndex("KullaniciKisiselID");

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

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

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

                    b.Property<string>("FotografYolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            FotografYolu = "Fotograflar\\Elma.jpg",
                            Kalori = 95.0,
                            KarbonhidratMiktari = 19.0,
                            KategoriID = 1,
                            ProteinMiktari = 0.29999999999999999,
                            YagMiktari = 0.29999999999999999,
                            YemekAdi = "Elma"
                        },
                        new
                        {
                            ID = 2,
                            FotografYolu = "Fotograflar\\BeyazPeynir.jpg",
                            Kalori = 291.0,
                            KarbonhidratMiktari = 22.0,
                            KategoriID = 4,
                            ProteinMiktari = 3.5,
                            YagMiktari = 21.0,
                            YemekAdi = "BeyazPeynir"
                        },
                        new
                        {
                            ID = 3,
                            FotografYolu = "Fotograflar\\BezelyeProteini.jpg",
                            Kalori = 205.0,
                            KarbonhidratMiktari = 18.5,
                            KategoriID = 2,
                            ProteinMiktari = 33.200000000000003,
                            YagMiktari = 3.7999999999999998,
                            YemekAdi = "BezelyeProteini"
                        },
                        new
                        {
                            ID = 4,
                            FotografYolu = "Fotograflar\\SiyezBurguMakarna.jpg",
                            Kalori = 107.12,
                            KarbonhidratMiktari = 21.940000000000001,
                            KategoriID = 2,
                            ProteinMiktari = 3.04,
                            YagMiktari = 0.57999999999999996,
                            YemekAdi = "SiyezBurguMakarna "
                        },
                        new
                        {
                            ID = 5,
                            FotografYolu = "Fotograflar\\Tofu.jpg",
                            Kalori = 43.399999999999999,
                            KarbonhidratMiktari = 0.29999999999999999,
                            KategoriID = 4,
                            ProteinMiktari = 3.5499999999999998,
                            YagMiktari = 3.1200000000000001,
                            YemekAdi = "Tofu"
                        },
                        new
                        {
                            ID = 6,
                            FotografYolu = "Fotograflar\\PortakalliSekersizBitterCikolata.jpg",
                            Kalori = 563.39999999999998,
                            KarbonhidratMiktari = 52.899999999999999,
                            KategoriID = 3,
                            ProteinMiktari = 6.8200000000000003,
                            YagMiktari = 36.07,
                            YemekAdi = "PortakalliSekersizBitterCikolata"
                        },
                        new
                        {
                            ID = 7,
                            FotografYolu = "Fotograflar\\Portakal.jpg",
                            Kalori = 47.0,
                            KarbonhidratMiktari = 11.800000000000001,
                            KategoriID = 1,
                            ProteinMiktari = 0.90000000000000002,
                            YagMiktari = 0.10000000000000001,
                            YemekAdi = "Portakal"
                        },
                        new
                        {
                            ID = 8,
                            FotografYolu = "Fotograflar\\Brokoli.jpg",
                            Kalori = 39.0,
                            KarbonhidratMiktari = 2.5099999999999998,
                            KategoriID = 5,
                            ProteinMiktari = 3.2999999999999998,
                            YagMiktari = 0.20000000000000001,
                            YemekAdi = "Brokoli"
                        },
                        new
                        {
                            ID = 9,
                            FotografYolu = "Fotograflar\\BademSutu.jpg",
                            Kalori = 24.0,
                            KarbonhidratMiktari = 3.0,
                            KategoriID = 4,
                            ProteinMiktari = 0.5,
                            YagMiktari = 1.1000000000000001,
                            YemekAdi = "BademSutu"
                        },
                        new
                        {
                            ID = 10,
                            FotografYolu = "Fotograflar\\Patlican.jpg",
                            Kalori = 17.0,
                            KarbonhidratMiktari = 2.4900000000000002,
                            KategoriID = 5,
                            ProteinMiktari = 1.24,
                            YagMiktari = 0.17999999999999999,
                            YemekAdi = "Patlican "
                        },
                        new
                        {
                            ID = 11,
                            FotografYolu = "Fotograflar\\Hamburger.jpg",
                            Kalori = 106.38,
                            KarbonhidratMiktari = 16.120000000000001,
                            KategoriID = 3,
                            ProteinMiktari = 4.7300000000000004,
                            YagMiktari = 2.4900000000000002,
                            YemekAdi = "Hamburger"
                        },
                        new
                        {
                            ID = 12,
                            FotografYolu = "Fotograflar\\SiyahZeytin.jpg",
                            Kalori = 208.69999999999999,
                            KarbonhidratMiktari = 1.1000000000000001,
                            KategoriID = 4,
                            ProteinMiktari = 1.8,
                            YagMiktari = 2.1000000000000001,
                            YemekAdi = "SiyahZeytin"
                        },
                        new
                        {
                            ID = 13,
                            FotografYolu = "Fotograflar\\Sucuk.jpg",
                            Kalori = 189.00999999999999,
                            KarbonhidratMiktari = 35.960000000000001,
                            KategoriID = 4,
                            ProteinMiktari = 8.6300000000000008,
                            YagMiktari = 1.3799999999999999,
                            YemekAdi = "Sucuk"
                        },
                        new
                        {
                            ID = 14,
                            FotografYolu = "Fotograflar\\Avokado.jpg",
                            Kalori = 200.0,
                            KarbonhidratMiktari = 8.5299999999999994,
                            KategoriID = 5,
                            ProteinMiktari = 2.0,
                            YagMiktari = 14.66,
                            YemekAdi = "Avokado"
                        },
                        new
                        {
                            ID = 15,
                            FotografYolu = "Fotograflar\\Cilek.jpg",
                            Kalori = 32.0,
                            KarbonhidratMiktari = 7.6799999999999997,
                            KategoriID = 1,
                            ProteinMiktari = 0.67000000000000004,
                            YagMiktari = 0.29999999999999999,
                            YemekAdi = "Cilek"
                        },
                        new
                        {
                            ID = 16,
                            FotografYolu = "Fotograflar\\MeyveliYasPasta.jpg",
                            Kalori = 143.0,
                            KarbonhidratMiktari = 21.530000000000001,
                            KategoriID = 3,
                            ProteinMiktari = 3.5600000000000001,
                            YagMiktari = 4.5599999999999996,
                            YemekAdi = "MeyveliYasPasta"
                        },
                        new
                        {
                            ID = 17,
                            FotografYolu = "Fotograflar\\Mantar.jpg",
                            Kalori = 3.0,
                            KarbonhidratMiktari = 3.2599999999999998,
                            KategoriID = 5,
                            ProteinMiktari = 3.0899999999999999,
                            YagMiktari = 0.34000000000000002,
                            YemekAdi = "Mantar"
                        },
                        new
                        {
                            ID = 18,
                            FotografYolu = "Fotograflar\\Havuc.jpg",
                            Kalori = 41.0,
                            KarbonhidratMiktari = 9.5800000000000001,
                            KategoriID = 5,
                            ProteinMiktari = 0.93000000000000005,
                            YagMiktari = 0.23999999999999999,
                            YemekAdi = "Havuc"
                        },
                        new
                        {
                            ID = 19,
                            FotografYolu = "Fotograflar\\Nohut.jpg",
                            Kalori = 164.0,
                            KarbonhidratMiktari = 27.420000000000002,
                            KategoriID = 2,
                            ProteinMiktari = 8.8599999999999994,
                            YagMiktari = 2.5899999999999999,
                            YemekAdi = "Nohut"
                        },
                        new
                        {
                            ID = 20,
                            FotografYolu = "Fotograflar\\IspanakliPizza.jpg",
                            Kalori = 129.72,
                            KarbonhidratMiktari = 20.57,
                            KategoriID = 3,
                            ProteinMiktari = 3.48,
                            YagMiktari = 3.6000000000000001,
                            YemekAdi = "IspanakliPizza"
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

                    b.Property<int>("YemekID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("YemekID");

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

                    b.Property<int>("YemekMiktarID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OgunID");

                    b.HasIndex("YemekMiktarID");

                    b.ToTable("YemekMiktarOgun");
                });

            modelBuilder.Entity("DietApp.Entities.GunlukRapor", b =>
                {
                    b.HasOne("DietApp.Entities.KullaniciKisisel", null)
                        .WithMany("KullanicininRaporlari")
                        .HasForeignKey("KullaniciKisiselID");
                });

            modelBuilder.Entity("DietApp.Entities.KullaniciKisisel", b =>
                {
                    b.HasOne("DietApp.Entities.KullaniciGiris", "KullaniciGiris")
                        .WithOne("KullaniciKisisel")
                        .HasForeignKey("DietApp.Entities.KullaniciKisisel", "KullaniciGirisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KullaniciGiris");
                });

            modelBuilder.Entity("DietApp.Entities.Ogun", b =>
                {
                    b.HasOne("DietApp.Entities.GunlukRapor", null)
                        .WithMany("GunlukRaporunOgunListesi")
                        .HasForeignKey("GunlukRaporID");

                    b.HasOne("DietApp.Entities.KullaniciKisisel", "KullaniciKisisel")
                        .WithMany("KullanicininOgunleri")
                        .HasForeignKey("KullaniciKisiselID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KullaniciKisisel");
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
                        .WithMany("YemekMiktarlari")
                        .HasForeignKey("YemekID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YenilenYemek");
                });

            modelBuilder.Entity("DietApp.Entities.YemekMiktarOgun", b =>
                {
                    b.HasOne("DietApp.Entities.Ogun", "Ogun")
                        .WithMany("OgununYemekleri")
                        .HasForeignKey("OgunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietApp.Entities.YemekMiktari", "Yemek")
                        .WithMany("YemeginOgunleri")
                        .HasForeignKey("YemekMiktarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogun");

                    b.Navigation("Yemek");
                });

            modelBuilder.Entity("DietApp.Entities.GunlukRapor", b =>
                {
                    b.Navigation("GunlukRaporunOgunListesi");
                });

            modelBuilder.Entity("DietApp.Entities.Kategori", b =>
                {
                    b.Navigation("KategorininYemekListesi");
                });

            modelBuilder.Entity("DietApp.Entities.KullaniciGiris", b =>
                {
                    b.Navigation("KullaniciKisisel")
                        .IsRequired();
                });

            modelBuilder.Entity("DietApp.Entities.KullaniciKisisel", b =>
                {
                    b.Navigation("IcilenSu");

                    b.Navigation("KullanicininOgunleri");

                    b.Navigation("KullanicininRaporlari");
                });

            modelBuilder.Entity("DietApp.Entities.Ogun", b =>
                {
                    b.Navigation("OgununYemekleri");
                });

            modelBuilder.Entity("DietApp.Entities.Yemek", b =>
                {
                    b.Navigation("YemekMiktarlari");
                });

            modelBuilder.Entity("DietApp.Entities.YemekMiktari", b =>
                {
                    b.Navigation("YemeginOgunleri");
                });
#pragma warning restore 612, 618
        }
    }
}