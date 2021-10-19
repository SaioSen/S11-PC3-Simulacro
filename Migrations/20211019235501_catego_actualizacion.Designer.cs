﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using S11_PC3_Simulacro.Data;

namespace S11_PC3_Simulacro.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211019235501_catego_actualizacion")]
    partial class catego_actualizacion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("S11_PC3_Simulacro.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("NomCategoria")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("S11_PC3_Simulacro.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("integer");

                    b.Property<string>("CelularContacto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lugar")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NombreDelComprador")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Precio")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("S11_PC3_Simulacro.Models.Producto", b =>
                {
                    b.HasOne("S11_PC3_Simulacro.Models.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("S11_PC3_Simulacro.Models.Categoria", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}