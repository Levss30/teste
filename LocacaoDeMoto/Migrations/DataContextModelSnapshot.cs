﻿// <auto-generated />
using System;
using LocacaoDeMoto.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LocacaoDeMoto.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("LocacaoDeMoto.Models.Entregador", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("Id"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FotoCnh")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NumeroCnh")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TipoCnh")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Entregador");
                });

            modelBuilder.Entity("LocacaoDeMoto.Models.Locacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataPrevisaoTermino")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataTermino")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EntregadorId")
                        .HasColumnType("integer");

                    b.Property<int>("MotoId")
                        .HasColumnType("integer");

                    b.Property<int>("Plano")
                        .HasColumnType("integer");

                    b.Property<int>("ValorDiaria")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("LocacaoDeMoto.Models.Moto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("Id"));

                    b.Property<string>("Ano")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Motos");
                });
#pragma warning restore 612, 618
        }
    }
}
