﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Turnos.Models;

namespace Turnos.Migrations
{
    [DbContext(typeof(TurnosContext))]
    [Migration("20210923221103_MigracionMedicoEspecialidad")]
    partial class MigracionMedicoEspecialidad
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Turnos.Models.Especialidad", b =>
                {
                    b.Property<int>("IdEspecialidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("IdEspecialidad");

                    b.ToTable("Especialidad");
                });

            modelBuilder.Entity("Turnos.Models.Medico", b =>
                {
                    b.Property<int>("IdMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("HorarioAtencionDesde")
                        .IsUnicode(false)
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioAtencionHasta")
                        .IsUnicode(false)
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdMedico");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("Turnos.Models.MedicoEspecialidad", b =>
                {
                    b.Property<int>("IdMedico")
                        .HasColumnType("int");

                    b.Property<int>("IdEspecialidad")
                        .HasColumnType("int");

                    b.HasKey("IdMedico", "IdEspecialidad");

                    b.HasIndex("IdEspecialidad");

                    b.ToTable("MedicoEspecialidad");
                });

            modelBuilder.Entity("Turnos.Models.Paciente", b =>
                {
                    b.Property<int>("IdPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdPaciente");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("Turnos.Models.MedicoEspecialidad", b =>
                {
                    b.HasOne("Turnos.Models.Especialidad", "Especialidad")
                        .WithMany("MedicoEspecialidad")
                        .HasForeignKey("IdEspecialidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Turnos.Models.Medico", "Medico")
                        .WithMany("MedicoEspecialidad")
                        .HasForeignKey("IdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidad");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("Turnos.Models.Especialidad", b =>
                {
                    b.Navigation("MedicoEspecialidad");
                });

            modelBuilder.Entity("Turnos.Models.Medico", b =>
                {
                    b.Navigation("MedicoEspecialidad");
                });
#pragma warning restore 612, 618
        }
    }
}
