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
    public class UserYemekEklemeConfiguration : IEntityTypeConfiguration<Yemek>
    {
        public void Configure(EntityTypeBuilder<Yemek> builder)
        {
            builder.HasOne(x => x.Kategori).WithMany(x => x.KategorininYemekListesi).HasForeignKey(x => x.KategoriID);

            builder.HasData(
                new Yemek()
                {
                    ID = 1,
                    KategoriID = 1,
                    YemekAdi = "Elma",
                    KarbonhidratMiktari = 19,
                    ProteinMiktari = 0.3,
                    YagMiktari = 0.3,
                    Kalori = 95,
                    FotografYolu = "Fotograflar\\Elma.jpg"
                },
                new Yemek()
                {
                    ID = 2,
                    KategoriID = 4,
                    YemekAdi = "BeyazPeynir",
                    Kalori = 291,
                    KarbonhidratMiktari = 22,
                    ProteinMiktari = 3.5,
                    YagMiktari = 21,
                    FotografYolu = "Fotograflar\\BeyazPeynir.jpg"
                },
                new Yemek()
                {
                    ID = 3,
                    KategoriID = 2,
                    YemekAdi = "BezelyeProteini",
                    KarbonhidratMiktari = 18.5,
                    ProteinMiktari = 33.2,
                    YagMiktari = 3.8,
                    Kalori = 205,
                    FotografYolu = "Fotograflar\\BezelyeProteini.jpg"
                },
                new Yemek()
                {
                    ID = 4,
                    KategoriID = 2,
                    YemekAdi = "SiyezBurguMakarna ",
                    KarbonhidratMiktari = 21.94,
                    ProteinMiktari = 3.04,
                    YagMiktari = 0.58,
                    Kalori = 107.12,
                    FotografYolu = "Fotograflar\\SiyezBurguMakarna.jpg"
                },
                new Yemek()
                {
                    ID = 5,
                    KategoriID = 4,
                    YemekAdi = "Tofu",
                    KarbonhidratMiktari = 0.3,
                    ProteinMiktari = 3.55,
                    YagMiktari = 3.12,
                    Kalori = 43.4,
                    FotografYolu = "Fotograflar\\Tofu.jpg"
                },
                new Yemek()
                {
                    ID = 6,
                    KategoriID = 3,
                    YemekAdi = "PortakalliSekersizBitterCikolata",
                    KarbonhidratMiktari = 52.9,
                    ProteinMiktari = 6.82,
                    YagMiktari = 36.07,
                    Kalori = 563.4,
                    FotografYolu = "Fotograflar\\PortakalliSekersizBitterCikolata.jpg"
                },
                new Yemek()
                {
                    ID = 7,
                    KategoriID = 1,
                    YemekAdi = "Portakal",
                    KarbonhidratMiktari = 11.8,
                    ProteinMiktari = 0.9,
                    YagMiktari = 0.1,
                    Kalori = 47,
                    FotografYolu = "Fotograflar\\Portakal.jpg"
                },
                new Yemek()
                {
                    ID = 8,
                    KategoriID = 5,
                    YemekAdi = "Brokoli",
                    KarbonhidratMiktari = 2.51,
                    ProteinMiktari = 3.3,
                    YagMiktari = 0.2,
                    Kalori = 39,
                    FotografYolu = "Fotograflar\\Brokoli.jpg"
                },
                new Yemek()
                {
                    ID = 9,
                    KategoriID = 4,
                    YemekAdi = "BademSutu",
                    KarbonhidratMiktari = 3,
                    ProteinMiktari = 0.5,
                    YagMiktari = 1.1,
                    Kalori = 24,
                    FotografYolu = "Fotograflar\\BademSutu.jpg"
                },
                new Yemek()
                {
                    ID = 10,
                    KategoriID = 5,
                    YemekAdi = "Patlican ",
                    KarbonhidratMiktari = 2.49,
                    ProteinMiktari = 1.24,
                    YagMiktari = 0.18,
                    Kalori = 17,
                    FotografYolu = "Fotograflar\\Patlican.jpg"
                },
                new Yemek()
                {
                    ID = 11,
                    KategoriID = 3,
                    YemekAdi = "Hamburger",
                    Kalori = 106.38,
                    KarbonhidratMiktari = 16.12,
                    ProteinMiktari = 4.73,
                    YagMiktari = 2.49,
                    FotografYolu = "Fotograflar\\Hamburger.jpg"
                },
                new Yemek()
                {
                    ID = 12,
                    KategoriID = 4,
                    YemekAdi = "SiyahZeytin",
                    Kalori = 208.70,
                    KarbonhidratMiktari = 1.1,
                    ProteinMiktari = 1.8,
                    YagMiktari = 2.1,
                    FotografYolu = "Fotograflar\\SiyahZeytin.jpg"
                },
                new Yemek()
                {
                    ID = 13,
                    KategoriID = 4,
                    YemekAdi = "Sucuk",
                    Kalori = 189.01,
                    KarbonhidratMiktari = 35.96,
                    ProteinMiktari = 8.63,
                    YagMiktari = 1.38,
                    FotografYolu = "Fotograflar\\Sucuk.jpg"
                },
                new Yemek()
                {
                    ID = 14,
                    KategoriID = 5,
                    YemekAdi = "Avokado",
                    Kalori = 200,
                    KarbonhidratMiktari = 8.53,
                    ProteinMiktari = 2,
                    YagMiktari = 14.66,
                    FotografYolu = "Fotograflar\\Avokado.jpg"
                },
                new Yemek()
                {
                    ID = 15,
                    KategoriID = 1,
                    YemekAdi = "Cilek",
                    Kalori = 32,
                    KarbonhidratMiktari = 7.68,
                    ProteinMiktari = 0.67,
                    YagMiktari = 0.3,
                    FotografYolu = "Fotograflar\\Cilek.jpg"
                },
                new Yemek()
                {
                    ID = 16,
                    KategoriID = 3,
                    YemekAdi = "MeyveliYasPasta",
                    KarbonhidratMiktari = 21.53,
                    ProteinMiktari = 3.56,
                    YagMiktari = 4.56,
                    Kalori = 143,
                    FotografYolu = "Fotograflar\\MeyveliYasPasta.jpg"
                },
                new Yemek()
                {
                    ID = 17,
                    KategoriID = 5,
                    YemekAdi = "Mantar",
                    Kalori = 3,
                    KarbonhidratMiktari = 3.26,
                    ProteinMiktari = 3.09,
                    YagMiktari = 0.34,
                    FotografYolu = "Fotograflar\\Mantar.jpg"
                },
                new Yemek()
                {
                    ID = 18,
                    KategoriID = 5,
                    YemekAdi = "Havuc",
                    Kalori = 41,
                    KarbonhidratMiktari = 9.58,
                    ProteinMiktari = 0.93,
                    YagMiktari = 0.24,
                    FotografYolu = "Fotograflar\\Havuc.jpg"
                },
                new Yemek()
                {
                    ID = 19,
                    KategoriID = 2,
                    YemekAdi = "Nohut",
                    Kalori = 164,
                    KarbonhidratMiktari = 27.42,
                    ProteinMiktari = 8.86,
                    YagMiktari = 2.59,
                    FotografYolu = "Fotograflar\\Nohut.jpg"
                },
                new Yemek()
                {
                    ID = 20,
                    KategoriID = 3,
                    YemekAdi = "IspanakliPizza",
                    Kalori = 129.72,
                    KarbonhidratMiktari = 20.57,
                    ProteinMiktari = 3.48,
                    YagMiktari = 3.6,
                    FotografYolu = "Fotograflar\\IspanakliPizza.jpg"
                });
                
        }
    }
}
