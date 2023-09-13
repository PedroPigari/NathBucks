﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NathBucks.Models;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace NathBucks.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230913140014_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NathBucks.Models.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Autorizacao")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Estrelas")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Avaliacao");
                });

            modelBuilder.Entity("NathBucks.Models.Cafeteria", b =>
                {
                    b.Property<int>("IdCafeteria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCafeteria"));

                    b.Property<int>("EstoqueCafe")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("EstoqueCopos")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Funcionarios")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("IdCafeteria");

                    b.ToTable("Cafeteria");
                });

            modelBuilder.Entity("NathBucks.Models.Cardapio", b =>
                {
                    b.Property<int>("IdCardapio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCardapio"));

                    b.Property<string>("DescricaoDrink")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<float>("PrecoDrink")
                        .HasColumnType("BINARY_FLOAT");

                    b.Property<string>("TamanhoDrink")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("TipoDrink")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("IdCardapio");

                    b.ToTable("Cardapio");
                });
#pragma warning restore 612, 618
        }
    }
}
