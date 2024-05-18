﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetAutoIoT.Persistence;

#nullable disable

namespace VetAutoIoT.Persistence.Migrations
{
    [DbContext(typeof(PersistenceDbContext))]
    [Migration("20240517183716_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("VetAutoIoT.Core.Configurations.ApiConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccessToken")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AnimalFeederEndpoint")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BaseUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FeederByCoordinatesEndpoint")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FeederEndpoint")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ApiConfigurations");
                });

            modelBuilder.Entity("VetAutoIoT.Core.Configurations.FeederConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AmountOfFood")
                        .HasColumnType("REAL");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("FeederConfigurations");
                });
#pragma warning restore 612, 618
        }
    }
}
