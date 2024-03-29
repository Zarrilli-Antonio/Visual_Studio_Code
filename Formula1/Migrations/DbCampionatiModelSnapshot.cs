﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Formula1.Migrations
{
    [DbContext(typeof(DbCampionati))]
    partial class DbCampionatiModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Pilota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnnoCampionato")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCampionato")
                        .HasColumnType("TEXT");

                    b.Property<int>("PosizionePodio")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Scuderia")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Campionati");
                });
#pragma warning restore 612, 618
        }
    }
}
