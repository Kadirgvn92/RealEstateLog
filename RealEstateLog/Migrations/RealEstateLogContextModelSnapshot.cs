﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealEstateLog.Context;

#nullable disable

namespace RealEstateLog.Migrations
{
    [DbContext(typeof(RealEstateLogContext))]
    partial class RealEstateLogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RealEstateLog.Entity.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("CustomerPrice")
                        .HasColumnType("float");

                    b.Property<string>("CustomerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FSBODate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ListingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ListingNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListingRoomCount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NextCallDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
