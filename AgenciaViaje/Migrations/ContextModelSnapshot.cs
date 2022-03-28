﻿// <auto-generated />
using AgenciaViaje.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgenciaViaje.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AgenciaViaje.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDestino")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("IdCliente");

                    b.HasIndex("IdDestino");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AgenciaViaje.Models.Contato", b =>
                {
                    b.Property<int>("IdContato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdContato"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("IdContato");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("AgenciaViaje.Models.Destino", b =>
                {
                    b.Property<int>("IdDestino")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDestino"), 1L, 1);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dias")
                        .HasColumnType("int");

                    b.Property<string>("Hotel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDestino");

                    b.ToTable("Destinos");
                });

            modelBuilder.Entity("AgenciaViaje.Models.Cliente", b =>
                {
                    b.HasOne("AgenciaViaje.Models.Destino", "Destino")
                        .WithMany("Cliente")
                        .HasForeignKey("IdDestino")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destino");
                });

            modelBuilder.Entity("AgenciaViaje.Models.Destino", b =>
                {
                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}