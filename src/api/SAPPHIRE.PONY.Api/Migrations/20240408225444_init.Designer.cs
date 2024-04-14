﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SAPPHIRE.PONY.Data;

#nullable disable

namespace SAPPHIRE.PONY.Api.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20240408225444_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Stars")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("SAPPHIRE.PONY.Domain.Catalog.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Brand 1",
                            Description = "Description 1",
                            Name = "Item 1",
                            Price = 100.00m
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Brand 2",
                            Description = "Description 2",
                            Name = "Item 2",
                            Price = 200.00m
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Brand 3",
                            Description = "Description 3",
                            Name = "Item 3",
                            Price = 300.00m
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Brand 4",
                            Description = "Description 4",
                            Name = "Item 4",
                            Price = 400.00m
                        });
                });

            modelBuilder.Entity("Rating", b =>
                {
                    b.HasOne("SAPPHIRE.PONY.Domain.Catalog.Item", null)
                        .WithMany("Ratings")
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("SAPPHIRE.PONY.Domain.Catalog.Item", b =>
                {
                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
