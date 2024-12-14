﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MottuDesafio.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MottuDesafio.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241212190740_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("MottuDesafio.Models.Entregador", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id"));

                    b.Property<string>("cnpj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("data_nasc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte[]>("img_cnh")
                        .HasColumnType("bytea");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("numero_cnh")
                        .HasColumnType("integer");

                    b.Property<int>("tipo_cnh")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Entregador");
                });

            modelBuilder.Entity("MottuDesafio.Models.Locacao", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id"));

                    b.Property<long>("Entregadorid")
                        .HasColumnType("bigint");

                    b.Property<long>("Motoid")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("data_devolucao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("data_inicio")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("data_previsao_termino")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("data_termino")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("entregador_id")
                        .HasColumnType("integer");

                    b.Property<int>("moto_id")
                        .HasColumnType("integer");

                    b.Property<int>("plano")
                        .HasColumnType("integer");

                    b.Property<int>("valor_diaria")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("Entregadorid");

                    b.HasIndex("Motoid");

                    b.ToTable("Locacaos");
                });

            modelBuilder.Entity("MottuDesafio.Models.Moto", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id"));

                    b.Property<int>("ano")
                        .HasColumnType("integer");

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("placa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Motos");
                });

            modelBuilder.Entity("MottuDesafio.Models.Locacao", b =>
                {
                    b.HasOne("MottuDesafio.Models.Entregador", "Entregador")
                        .WithMany()
                        .HasForeignKey("Entregadorid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MottuDesafio.Models.Moto", "Moto")
                        .WithMany()
                        .HasForeignKey("Motoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entregador");

                    b.Navigation("Moto");
                });
#pragma warning restore 612, 618
        }
    }
}
