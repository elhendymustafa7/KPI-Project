﻿// <auto-generated />
using KPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KPI.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240118021512_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KPI.Data.Models.Kpi", b =>
                {
                    b.Property<int>("KPIDNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KPIDNum"));

                    b.Property<int>("DepNo")
                        .HasColumnType("int");

                    b.Property<string>("KPIDNescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MeasurementUnit")
                        .HasColumnType("bit");

                    b.Property<int>("TargetedValue")
                        .HasColumnType("int");

                    b.HasKey("KPIDNum");

                    b.ToTable("KPIs");
                });
#pragma warning restore 612, 618
        }
    }
}
