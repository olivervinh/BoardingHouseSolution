﻿// <auto-generated />
using System;
using BoardingHouse.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoardingHouse.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoardingHouse.Domain.HouseDomain.Models.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Acreage")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ElectricityPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HousePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HouseStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsParkingVehicleInRoom")
                        .HasColumnType("bit");

                    b.Property<int>("NumberMezzanine")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UnitAcreage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitElectricityPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitHousePrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitWaterPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("WaterPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Houses");
                });
#pragma warning restore 612, 618
        }
    }
}
