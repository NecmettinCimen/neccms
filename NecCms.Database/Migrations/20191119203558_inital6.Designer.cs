﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NecCms.Database;

namespace NecCms.Database.Migrations
{
    [DbContext(typeof(CrmContext))]
    [Migration("20191119203558_inital6")]
    partial class inital6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NecCms.Database.Dosyalar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<long>("Boyutu");

                    b.Property<string>("Data");

                    b.Property<int>("KullaniciId");

                    b.Property<bool>("Sil");

                    b.Property<DateTime>("Tarih");

                    b.Property<string>("Tipi")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Yolu")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Dosyalar");
                });

            modelBuilder.Entity("NecCms.Database.Etkinlikler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IcerikId");

                    b.Property<int>("KullaniciId");

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.Property<bool>("Sil");

                    b.Property<DateTime>("Tarih");

                    b.HasKey("Id");

                    b.HasIndex("IcerikId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Etkinlikler");
                });

            modelBuilder.Entity("NecCms.Database.Icerik+FotografGalerisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FotografGalerisiDosyaId");

                    b.Property<int>("IcerikId");

                    b.Property<int>("KullaniciId");

                    b.Property<bool>("Sil");

                    b.Property<DateTime>("Tarih");

                    b.HasKey("Id");

                    b.HasIndex("FotografGalerisiDosyaId");

                    b.HasIndex("IcerikId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("FotografGalerisi");
                });

            modelBuilder.Entity("NecCms.Database.Icerik+FotografGalerisiDosyalar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DosyaId");

                    b.Property<int>("KullaniciId");

                    b.Property<bool>("Sil");

                    b.Property<DateTime>("Tarih");

                    b.HasKey("Id");

                    b.HasIndex("DosyaId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("FotografGalerisiDosyalar");
                });

            modelBuilder.Entity("NecCms.Database.Icerik+IcerikKategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("KullaniciId");

                    b.Property<bool>("Sil");

                    b.Property<DateTime>("Tarih");

                    b.Property<int?>("UstKategoriId");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.HasIndex("UstKategoriId");

                    b.ToTable("IcerikKategorileri");
                });

            modelBuilder.Entity("NecCms.Database.Icerik+Icerikler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Durum");

                    b.Property<string>("Giris")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Icerik");

                    b.Property<int>("IcerikKategoriId");

                    b.Property<int>("KullaniciId");

                    b.Property<int?>("ResimId");

                    b.Property<bool>("Sil");

                    b.Property<DateTime>("Tarih");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime>("YayinlanmaTarihi");

                    b.Property<int>("YazarId");

                    b.HasKey("Id");

                    b.HasIndex("IcerikKategoriId");

                    b.HasIndex("KullaniciId");

                    b.HasIndex("ResimId");

                    b.HasIndex("YazarId");

                    b.ToTable("Icerikler");
                });

            modelBuilder.Entity("NecCms.Database.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("KullaniciId");

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Rol");

                    b.Property<bool>("Sil");

                    b.Property<DateTime>("Tarih");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Kullanicilar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdSoyad = "Admin",
                            Eposta = "admin@crm.com",
                            KullaniciId = 1,
                            Parola = "admin@crm.com",
                            Rol = 1,
                            Sil = false,
                            Tarih = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Telefon = "05456286324"
                        });
                });

            modelBuilder.Entity("NecCms.Database.Tema+Parametre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama");

                    b.Property<string>("Isim");

                    b.Property<string>("Kodu")
                        .IsRequired();

                    b.Property<int>("KullaniciId");

                    b.Property<bool>("Sil");

                    b.Property<int>("Sira");

                    b.Property<DateTime>("Tarih");

                    b.Property<int>("Tip");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Parametre");
                });

            modelBuilder.Entity("NecCms.Database.Tema+ParametreDegeri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Deger");

                    b.Property<int>("DegerInt");

                    b.Property<int>("KullaniciId");

                    b.Property<int>("ParametreId");

                    b.Property<bool>("Sil");

                    b.Property<DateTime>("Tarih");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.HasIndex("ParametreId");

                    b.ToTable("ParametreDegeri");
                });

            modelBuilder.Entity("NecCms.Database.Uyeler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Bolum")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("Cinsiyet");

                    b.Property<DateTime>("DogumTarihi");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Hakkinda")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("KullaniciId");

                    b.Property<bool>("Sil");

                    b.Property<DateTime>("Tarih");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Uyeler");
                });

            modelBuilder.Entity("NecCms.Database.Dosyalar", b =>
                {
                    b.HasOne("NecCms.Database.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NecCms.Database.Etkinlikler", b =>
                {
                    b.HasOne("NecCms.Database.Icerik+Icerikler", "Icerik")
                        .WithMany()
                        .HasForeignKey("IcerikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NecCms.Database.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NecCms.Database.Icerik+FotografGalerisi", b =>
                {
                    b.HasOne("NecCms.Database.Icerik+FotografGalerisiDosyalar", "FotografGalerisiDosya")
                        .WithMany()
                        .HasForeignKey("FotografGalerisiDosyaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NecCms.Database.Icerik+Icerikler", "Icerik")
                        .WithMany()
                        .HasForeignKey("IcerikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NecCms.Database.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NecCms.Database.Icerik+FotografGalerisiDosyalar", b =>
                {
                    b.HasOne("NecCms.Database.Dosyalar", "Dosya")
                        .WithMany()
                        .HasForeignKey("DosyaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NecCms.Database.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NecCms.Database.Icerik+IcerikKategori", b =>
                {
                    b.HasOne("NecCms.Database.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NecCms.Database.Icerik+IcerikKategori", "UstKategori")
                        .WithMany()
                        .HasForeignKey("UstKategoriId");
                });

            modelBuilder.Entity("NecCms.Database.Icerik+Icerikler", b =>
                {
                    b.HasOne("NecCms.Database.Icerik+IcerikKategori", "IcerikKategori")
                        .WithMany()
                        .HasForeignKey("IcerikKategoriId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NecCms.Database.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NecCms.Database.Dosyalar", "Resim")
                        .WithMany()
                        .HasForeignKey("ResimId");

                    b.HasOne("NecCms.Database.Kullanici", "Yazar")
                        .WithMany()
                        .HasForeignKey("YazarId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NecCms.Database.Kullanici", b =>
                {
                    b.HasOne("NecCms.Database.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NecCms.Database.Tema+Parametre", b =>
                {
                    b.HasOne("NecCms.Database.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NecCms.Database.Tema+ParametreDegeri", b =>
                {
                    b.HasOne("NecCms.Database.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NecCms.Database.Tema+Parametre", "Parametre")
                        .WithMany()
                        .HasForeignKey("ParametreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NecCms.Database.Uyeler", b =>
                {
                    b.HasOne("NecCms.Database.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
