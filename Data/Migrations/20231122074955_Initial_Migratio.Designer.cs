﻿// <auto-generated />
using System;
using CarCenter.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarCenter.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231122074955_Initial_Migratio")]
    partial class Initial_Migratio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("CarCenter.Data.Entities.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("CarCenter.Data.Entities.BrandModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BrandId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("BrandModel");
                });

            modelBuilder.Entity("CarCenter.Data.Entities.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("TEXT");

                    b.Property<int>("DoorsNumber")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ModelId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ModelId");

                    b.ToTable("Cars", (string)null);
                });

            modelBuilder.Entity("CarCenter.Data.Entities.BrandModel", b =>
                {
                    b.HasOne("CarCenter.Data.Entities.Brand", null)
                        .WithMany("Models")
                        .HasForeignKey("BrandId");
                });

            modelBuilder.Entity("CarCenter.Data.Entities.Car", b =>
                {
                    b.HasOne("CarCenter.Data.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarCenter.Data.Entities.BrandModel", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("CarCenter.Data.Entities.Brand", b =>
                {
                    b.Navigation("Models");
                });
#pragma warning restore 612, 618
        }
    }
}
