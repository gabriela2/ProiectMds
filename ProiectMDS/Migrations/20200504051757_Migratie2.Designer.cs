﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectMDS.Contexts;

namespace ProiectMDS.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200504051757_Migratie2")]
    partial class Migratie2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProiectMDS.Models.Categorie", b =>
                {
                    b.Property<int>("CategorieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descriere");

                    b.Property<string>("NumeCategorie");

                    b.Property<string>("Specificatii");

                    b.HasKey("CategorieId");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("ProiectMDS.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<DateTime>("DataNasterii");

                    b.Property<string>("Email");

                    b.Property<int>("IdTip");

                    b.Property<string>("Nume");

                    b.Property<string>("Parola");

                    b.Property<int?>("TipClientId");

                    b.HasKey("ClientId");

                    b.HasIndex("TipClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("ProiectMDS.Models.ComandaEchipament", b =>
                {
                    b.Property<int>("ComandaEchipamentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantitate");

                    b.Property<int?>("ComenziId");

                    b.Property<int?>("EchipamentId");

                    b.Property<int>("IdComenzi");

                    b.Property<int>("IdEchipament");

                    b.HasKey("ComandaEchipamentId");

                    b.HasIndex("ComenziId");

                    b.HasIndex("EchipamentId");

                    b.ToTable("ComandaEchipament");
                });

            modelBuilder.Entity("ProiectMDS.Models.Comenzi", b =>
                {
                    b.Property<int>("ComenziId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientId");

                    b.Property<int>("IdClient");

                    b.Property<int>("IdMagazin");

                    b.Property<int?>("MagazinId");

                    b.Property<float>("SumaTotala");

                    b.HasKey("ComenziId");

                    b.HasIndex("ClientId");

                    b.HasIndex("MagazinId");

                    b.ToTable("Comenzi");
                });

            modelBuilder.Entity("ProiectMDS.Models.Echipament", b =>
                {
                    b.Property<int>("EchipamentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnAparitie");

                    b.Property<string>("Descriere");

                    b.Property<int>("IdProducator");

                    b.Property<string>("NumeEchipament");

                    b.Property<float>("Pret");

                    b.Property<int?>("ProducatorId");

                    b.Property<string>("Specificatii");

                    b.Property<string>("img");

                    b.HasKey("EchipamentId");

                    b.HasIndex("ProducatorId");

                    b.ToTable("Echipament");
                });

            modelBuilder.Entity("ProiectMDS.Models.EchipamentCategorie", b =>
                {
                    b.Property<int>("EchipamentCategorieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategorieId");

                    b.Property<int?>("EchipamentId");

                    b.Property<int>("IdCategorie");

                    b.Property<int>("IdEchipament");

                    b.HasKey("EchipamentCategorieId");

                    b.HasIndex("CategorieId");

                    b.HasIndex("EchipamentId");

                    b.ToTable("EchipamentCategorie");
                });

            modelBuilder.Entity("ProiectMDS.Models.Magazin", b =>
                {
                    b.Property<int>("MagazinId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<string>("Nume");

                    b.HasKey("MagazinId");

                    b.ToTable("Magazin");
                });

            modelBuilder.Entity("ProiectMDS.Models.MagazinEchipament", b =>
                {
                    b.Property<int>("MagazinEchipamentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EchipamentId");

                    b.Property<int>("IdEchipament");

                    b.Property<int>("IdMagazin");

                    b.Property<int?>("MagazinId");

                    b.Property<float>("Stoc");

                    b.HasKey("MagazinEchipamentId");

                    b.HasIndex("EchipamentId");

                    b.HasIndex("MagazinId");

                    b.ToTable("MagazinEchipament");
                });

            modelBuilder.Entity("ProiectMDS.Models.Producator", b =>
                {
                    b.Property<int>("ProducatorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumeProducator");

                    b.Property<string>("TaraOrigine");

                    b.HasKey("ProducatorId");

                    b.ToTable("Producator");
                });

            modelBuilder.Entity("ProiectMDS.Models.TipClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descriere");

                    b.Property<int>("Discount");

                    b.HasKey("Id");

                    b.ToTable("TipClient");
                });

            modelBuilder.Entity("ProiectMDS.Models.Client", b =>
                {
                    b.HasOne("ProiectMDS.Models.TipClient", "TipClient")
                        .WithMany("Client")
                        .HasForeignKey("TipClientId");
                });

            modelBuilder.Entity("ProiectMDS.Models.ComandaEchipament", b =>
                {
                    b.HasOne("ProiectMDS.Models.Comenzi", "Comenzi")
                        .WithMany("ComandaEchipament")
                        .HasForeignKey("ComenziId");

                    b.HasOne("ProiectMDS.Models.Echipament", "Echipament")
                        .WithMany("ComandaEchipament")
                        .HasForeignKey("EchipamentId");
                });

            modelBuilder.Entity("ProiectMDS.Models.Comenzi", b =>
                {
                    b.HasOne("ProiectMDS.Models.Client", "Client")
                        .WithMany("Comenzi")
                        .HasForeignKey("ClientId");

                    b.HasOne("ProiectMDS.Models.Magazin", "Magazin")
                        .WithMany("Comenzi")
                        .HasForeignKey("MagazinId");
                });

            modelBuilder.Entity("ProiectMDS.Models.Echipament", b =>
                {
                    b.HasOne("ProiectMDS.Models.Producator", "Producator")
                        .WithMany("Echipament")
                        .HasForeignKey("ProducatorId");
                });

            modelBuilder.Entity("ProiectMDS.Models.EchipamentCategorie", b =>
                {
                    b.HasOne("ProiectMDS.Models.Categorie", "Categorie")
                        .WithMany("EchipamentCategorie")
                        .HasForeignKey("CategorieId");

                    b.HasOne("ProiectMDS.Models.Echipament", "Echipament")
                        .WithMany("EchipamentCategorie")
                        .HasForeignKey("EchipamentId");
                });

            modelBuilder.Entity("ProiectMDS.Models.MagazinEchipament", b =>
                {
                    b.HasOne("ProiectMDS.Models.Echipament", "Echipament")
                        .WithMany()
                        .HasForeignKey("EchipamentId");

                    b.HasOne("ProiectMDS.Models.Magazin", "Magazin")
                        .WithMany("MagazinEchipament")
                        .HasForeignKey("MagazinId");
                });
#pragma warning restore 612, 618
        }
    }
}