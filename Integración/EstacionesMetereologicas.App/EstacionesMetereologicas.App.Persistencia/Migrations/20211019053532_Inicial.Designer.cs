﻿// <auto-generated />
using System;
using EstacionesMetereologicas.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EstacionesMetereologicas.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211019053532_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.Actividad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Id_ActuacionId")
                        .HasColumnType("int");

                    b.Property<int?>("Id_EstacionId")
                        .HasColumnType("int");

                    b.Property<int?>("Id_personaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_ActuacionId");

                    b.HasIndex("Id_EstacionId");

                    b.HasIndex("Id_personaId");

                    b.ToTable("Actividades");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.Actuacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actuaciones");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.DataMeteorologica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Codigo_Estacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Humedad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Estacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pluviosidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Presion_Atmosferica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Radiacion_Solar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Velocidad_Viento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DataMeteorologica");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.DatosMeteorologicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaDato")
                        .HasColumnType("datetime2");

                    b.Property<int>("TipoDato")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.Property<int>("id_Estacion")
                        .HasColumnType("int");

                    b.Property<int>("id_TipoDato")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DatosMeteorologicosRegistrados");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.Estacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Codigo_Estacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Montaje")
                        .HasColumnType("datetime2");

                    b.Property<int>("Latitud")
                        .HasColumnType("int");

                    b.Property<int>("Longitud")
                        .HasColumnType("int");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Estacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estacion");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.Novedades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Actuacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo_Estacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Novedad")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Novedades");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id_Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.Reporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id_ActividadId")
                        .HasColumnType("int");

                    b.Property<int>("Id_Tipo_Reporte")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_TipoReporte")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_ActividadId");

                    b.ToTable("Reportes");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.TipoDeDatos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoDeDatos");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.TipoReporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_TipoReporte")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoDeReportes");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.Validacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Val")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Validaciones");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.Administrador", b =>
                {
                    b.HasBaseType("EstacionesMetereologicas.App.Dominio.Persona");

                    b.Property<int>("Password")
                        .HasColumnType("int");

                    b.Property<string>("Rol")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.Actividad", b =>
                {
                    b.HasOne("EstacionesMetereologicas.App.Dominio.Actuacion", "Id_Actuacion")
                        .WithMany()
                        .HasForeignKey("Id_ActuacionId");

                    b.HasOne("EstacionesMetereologicas.App.Dominio.Estacion", "Id_Estacion")
                        .WithMany()
                        .HasForeignKey("Id_EstacionId");

                    b.HasOne("EstacionesMetereologicas.App.Dominio.Persona", "Id_persona")
                        .WithMany()
                        .HasForeignKey("Id_personaId");

                    b.Navigation("Id_Actuacion");

                    b.Navigation("Id_Estacion");

                    b.Navigation("Id_persona");
                });

            modelBuilder.Entity("EstacionesMetereologicas.App.Dominio.Reporte", b =>
                {
                    b.HasOne("EstacionesMetereologicas.App.Dominio.Actividad", "Id_Actividad")
                        .WithMany()
                        .HasForeignKey("Id_ActividadId");

                    b.Navigation("Id_Actividad");
                });
#pragma warning restore 612, 618
        }
    }
}
