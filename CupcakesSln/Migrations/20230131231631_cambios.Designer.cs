﻿// <auto-generated />
using System;
using CupcakesSln.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CupcakesSln.Migrations
{
    [DbContext(typeof(CupcakeContext))]
    [Migration("20230131231631_cambios")]
    partial class cambios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CupcakesSln.Models.Bakery", b =>
                {
                    b.Property<int>("BakeryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("BakeryName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("BakeryId");

                    b.ToTable("Bakeries");

                    b.HasData(
                        new
                        {
                            BakeryId = 1,
                            Address = "635 Brighton Circle Road",
                            BakeryName = "Gluteus Free",
                            Quantity = 8
                        },
                        new
                        {
                            BakeryId = 2,
                            Address = "4323 Jerome Avenue",
                            BakeryName = "Cupcakes Break",
                            Quantity = 22
                        },
                        new
                        {
                            BakeryId = 3,
                            Address = "2553 Pin Oak Drive",
                            BakeryName = "Cupcakes Ahead",
                            Quantity = 18
                        },
                        new
                        {
                            BakeryId = 4,
                            Address = "1608 Charles Street",
                            BakeryName = "Sugar",
                            Quantity = 30
                        });
                });

            modelBuilder.Entity("CupcakesSln.Models.Cupcake", b =>
                {
                    b.Property<int>("CupcakeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BakeryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("CaloricValue")
                        .HasColumnType("int");

                    b.Property<int>("CupcakeType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GlutenFree")
                        .HasColumnType("bit");

                    b.Property<string>("ImageMimeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PhotoFile")
                        .HasColumnType("varbinary(max)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("CupcakeId");

                    b.HasIndex("BakeryId");

                    b.ToTable("Cupcakes");

                    b.HasData(
                        new
                        {
                            CupcakeId = 1,
                            BakeryId = 1,
                            CaloricValue = 355,
                            CupcakeType = 0,
                            Description = "Vanilla cupcake with coconut cream",
                            GlutenFree = true,
                            ImageMimeType = "image/jpeg",
                            ImageName = "birthday-cupcake.jpg",
                            Price = 2.5
                        },
                        new
                        {
                            CupcakeId = 2,
                            BakeryId = 2,
                            CaloricValue = 195,
                            CupcakeType = 2,
                            Description = "Chocolate cupcake with caramel filling and chocolate butter cream",
                            GlutenFree = false,
                            ImageMimeType = "image/jpeg",
                            ImageName = "chocolate-cupcake.jpg",
                            Price = 3.2000000000000002
                        },
                        new
                        {
                            CupcakeId = 3,
                            BakeryId = 3,
                            CaloricValue = 295,
                            CupcakeType = 3,
                            Description = "Chocolate cupcake with straberry cream filling",
                            GlutenFree = false,
                            ImageMimeType = "image/jpeg",
                            ImageName = "pink-cupcake.jpg",
                            Price = 4.0
                        },
                        new
                        {
                            CupcakeId = 4,
                            BakeryId = 4,
                            CaloricValue = 360,
                            CupcakeType = 1,
                            Description = "Vanilla cupcake with butter cream",
                            GlutenFree = true,
                            ImageMimeType = "image/jpeg",
                            ImageName = "turquoise-cupcake.jpg",
                            Price = 1.5
                        });
                });

            modelBuilder.Entity("CupcakesSln.Models.Cupcake", b =>
                {
                    b.HasOne("CupcakesSln.Models.Bakery", "Bakery")
                        .WithMany("Cupcakes")
                        .HasForeignKey("BakeryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
