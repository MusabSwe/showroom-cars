﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShowRoom.Data;

namespace ShowRoom.Data.Migrations
{
    [DbContext(typeof(ShowRoomContext))]
    partial class ShowRoomContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShowRoom.Core.Engine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EngineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Engine");
                });

            modelBuilder.Entity("ShowRoom.Core.FuelEconomy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EconomyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VehicleModel")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("VehicleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FuelEconomy");
                });

            modelBuilder.Entity("ShowRoom.Core.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ManufacturerNumber")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Model")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("VehicleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("ShowRoom.Core.Wheel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("TireDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("TireName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("TireSize")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("TireType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Wheel");
                });

            modelBuilder.Entity("ShowRoom.Core.Bike", b =>
                {
                    b.HasBaseType("ShowRoom.Core.Vehicle");

                    b.Property<string>("BikeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EngineId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("FuelEconomyId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfWheels")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("PassengerNum")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("WheelId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasIndex("EngineId")
                        .IsUnique()
                        .HasFilter("[EngineId] IS NOT NULL");

                    b.HasIndex("FuelEconomyId")
                        .IsUnique()
                        .HasFilter("[FuelEconomyId] IS NOT NULL");

                    b.HasIndex("WheelId")
                        .IsUnique()
                        .HasFilter("[WheelId] IS NOT NULL");

                    b.ToTable("Bike");
                });

            modelBuilder.Entity("ShowRoom.Core.Car", b =>
                {
                    b.HasBaseType("ShowRoom.Core.Vehicle");

                    b.Property<int?>("EngineId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("FuelEconomyId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfCylinders")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfDoors")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("PassengerNum")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("WheelId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasIndex("EngineId")
                        .IsUnique()
                        .HasFilter("[EngineId] IS NOT NULL");

                    b.HasIndex("FuelEconomyId")
                        .IsUnique()
                        .HasFilter("[FuelEconomyId] IS NOT NULL");

                    b.HasIndex("WheelId")
                        .IsUnique()
                        .HasFilter("[WheelId] IS NOT NULL");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("ShowRoom.Core.Bike", b =>
                {
                    b.HasOne("ShowRoom.Core.Engine", "engine")
                        .WithOne("Bike")
                        .HasForeignKey("ShowRoom.Core.Bike", "EngineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowRoom.Core.FuelEconomy", "fuelEconomy")
                        .WithOne("Bike")
                        .HasForeignKey("ShowRoom.Core.Bike", "FuelEconomyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowRoom.Core.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("ShowRoom.Core.Bike", "VehicleId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("ShowRoom.Core.Wheel", "wheel")
                        .WithOne("Bike")
                        .HasForeignKey("ShowRoom.Core.Bike", "WheelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("engine");

                    b.Navigation("fuelEconomy");

                    b.Navigation("wheel");
                });

            modelBuilder.Entity("ShowRoom.Core.Car", b =>
                {
                    b.HasOne("ShowRoom.Core.Engine", "engine")
                        .WithOne("Car")
                        .HasForeignKey("ShowRoom.Core.Car", "EngineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowRoom.Core.FuelEconomy", "fuelEconomy")
                        .WithOne("Car")
                        .HasForeignKey("ShowRoom.Core.Car", "FuelEconomyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowRoom.Core.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("ShowRoom.Core.Car", "VehicleId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("ShowRoom.Core.Wheel", "wheel")
                        .WithOne("Car")
                        .HasForeignKey("ShowRoom.Core.Car", "WheelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("engine");

                    b.Navigation("fuelEconomy");

                    b.Navigation("wheel");
                });

            modelBuilder.Entity("ShowRoom.Core.Engine", b =>
                {
                    b.Navigation("Bike");

                    b.Navigation("Car");
                });

            modelBuilder.Entity("ShowRoom.Core.FuelEconomy", b =>
                {
                    b.Navigation("Bike");

                    b.Navigation("Car");
                });

            modelBuilder.Entity("ShowRoom.Core.Wheel", b =>
                {
                    b.Navigation("Bike");

                    b.Navigation("Car");
                });
#pragma warning restore 612, 618
        }
    }
}
