﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TransporteV2.Entidades
{
    public partial class TAIProContext : IdentityDbContext
    {
        public TAIProContext()
        {
        }

        public TAIProContext(DbContextOptions<TAIProContext> options)
            : base(options)
        {
        }

        

        public virtual DbSet<Chofere> Choferes { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Compra> Compras { get; set; } = null!;
        public virtual DbSet<CondicionIva> CondicionIvas { get; set; } = null!;
        public virtual DbSet<FormasPago> FormasPagos { get; set; } = null!;
        public virtual DbSet<LicenciaChofer> LicenciaChofers { get; set; } = null!;
        public virtual DbSet<LicenciasUnidad> LicenciasUnidads { get; set; } = null!;
        public virtual DbSet<Localidade> Localidades { get; set; } = null!;
        public virtual DbSet<Neumatico> Neumaticos { get; set; } = null!;
        public virtual DbSet<Provincium> Provincia { get; set; } = null!;
        public virtual DbSet<TdocumentoC> TdocumentoCs { get; set; } = null!;
        public virtual DbSet<TipoMarcasNeumatico> TipoMarcasNeumaticos { get; set; } = null!;
        public virtual DbSet<TipoMarcasUnidade> TipoMarcasUnidades { get; set; } = null!;
        public virtual DbSet<TipoUnidade> TipoUnidades { get; set; } = null!;
        public virtual DbSet<TiposDocumento> TiposDocumentos { get; set; } = null!;
        public virtual DbSet<Unidade> Unidades { get; set; } = null!;
        public virtual DbSet<Viaje> Viajes { get; set; } = null!;
        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=NT-F0FQVP2\\SQLEXPRESS; DataBase=TAIPro; Integrated Security=true; TrustServerCertificate=True");
            }
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chofere>(entity =>
            {
                entity.HasKey(e => e.IdChofer)
                    .HasName("PK__Choferes__2DF292AD84EC903F");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cuil)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("date");

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.IdTdocuC).HasColumnName("IdTDocuC");

                entity.Property(e => e.Ndocumento)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NDocumento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NuTramite)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Choferes)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("fkChoferePro");

                entity.HasOne(d => d.IdTdocuCNavigation)
                    .WithMany(p => p.Choferes)
                    .HasForeignKey(d => d.IdTdocuC)
                    .HasConstraintName("fk");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Clientes__D5946642A0271A99");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.IdCondicionIva).HasColumnName("IdCondicionIVA");

                entity.Property(e => e.IngresosBrutos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCondicionIvaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdCondicionIva)
                    .HasConstraintName("fkClienIVA");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("fkCliPro");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCompra)
                    .HasName("PK__Compras__0A5CDB5CD89F0A96");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCompra).HasColumnType("date");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.HasOne(d => d.IdFormaPagoNavigation)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.IdFormaPago)
                    .HasConstraintName("fk_Forma_Pagos");
            });

            modelBuilder.Entity<CondicionIva>(entity =>
            {
                entity.HasKey(e => e.IdCondicionIva)
                    .HasName("PK__Condicio__1B2D154EF6E39205");

                entity.ToTable("CondicionIVAS");

                entity.Property(e => e.IdCondicionIva).HasColumnName("IdCondicionIVA");

                entity.Property(e => e.CondicionIva1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CondicionIVA");
            });

            modelBuilder.Entity<FormasPago>(entity =>
            {
                entity.HasKey(e => e.IdFormaPago)
                    .HasName("PK__FormasPa__C777CA6894966A5A");

                entity.Property(e => e.FormaPago)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LicenciaChofer>(entity =>
            {
                entity.HasKey(e => e.IdLicenciaChofer)
                    .HasName("PK__Licencia__95068A926B2D4C75");

                entity.ToTable("LicenciaChofer");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.HasOne(d => d.IdChoferNavigation)
                    .WithMany(p => p.LicenciaChofers)
                    .HasForeignKey(d => d.IdChofer)
                    .HasConstraintName("fkLiceChofer");

                entity.HasOne(d => d.IdTiposDocumentosNavigation)
                    .WithMany(p => p.LicenciaChofers)
                    .HasForeignKey(d => d.IdTiposDocumentos)
                    .HasConstraintName("fkLiceDocu");
            });

            modelBuilder.Entity<LicenciasUnidad>(entity =>
            {
                entity.HasKey(e => e.IdLicenciaUnidades)
                    .HasName("PK__Licencia__3D090F1BEAD20CD8");

                entity.ToTable("LicenciasUnidad");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaVencimiento");

                entity.HasOne(d => d.IdTiposDocumentosNavigation)
                    .WithMany(p => p.LicenciasUnidads)
                    .HasForeignKey(d => d.IdTiposDocumentos)
                    .HasConstraintName("fkLicenciaDocumentos");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.LicenciasUnidads)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("fkLicenciasUnidades");
            });

            modelBuilder.Entity<Localidade>(entity =>
            {
                entity.HasKey(e => e.IdLocalidad)
                    .HasName("PK__Localida__274326128935C346");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Localidades)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("fkLocalidadPro");
            });

            modelBuilder.Entity<Neumatico>(entity =>
            {
                entity.HasKey(e => e.IdNeumatico)
                    .HasName("PK__Neumatic__AA974EFDCAC6EE99");

                entity.ToTable("Neumatico");

                entity.Property(e => e.Marca)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoMarcaNeumaticosNavigation)
                    .WithMany(p => p.Neumaticos)
                    .HasForeignKey(d => d.IdTipoMarcaNeumaticos)
                    .HasConstraintName("fkMarcaNeumatico");
            });

            modelBuilder.Entity<Provincium>(entity =>
            {
                entity.HasKey(e => e.IdProvincia)
                    .HasName("PK__Provinci__EED7445533884C2E");

                entity.Property(e => e.Provincia)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TdocumentoC>(entity =>
            {
                entity.HasKey(e => e.IdTdocuC)
                    .HasName("PK__TDocumen__9E7A4BFF29D273A4");

                entity.ToTable("TDocumentoC");

                entity.Property(e => e.IdTdocuC).HasColumnName("IdTDocuC");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoMarcasNeumatico>(entity =>
            {
                entity.HasKey(e => e.IdTipoMarcaNeumaticos)
                    .HasName("PK__TipoMarc__2DD5A366A459AE87");

                entity.Property(e => e.TipoMarcaNeumatico)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoMarcasUnidade>(entity =>
            {
                entity.HasKey(e => e.IdTipoMarcaUnidad)
                    .HasName("PK__TipoMarc__ED7D29C76BE35C58");

                entity.Property(e => e.TipoMarcaUnidad)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoUnidade>(entity =>
            {
                entity.HasKey(e => e.IdTipoUnidad)
                    .HasName("PK__TipoUnid__23FD7E6AA5A3449F");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoMarcaUnidadesNavigation)
                    .WithMany(p => p.TipoUnidades)
                    .HasForeignKey(d => d.IdTipoMarcaUnidades)
                    .HasConstraintName("fkTiposUnidades");
            });

            modelBuilder.Entity<TiposDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTiposDocumentos)
                    .HasName("PK__TiposDoc__A9B5CFE905D00CFD");

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Unidade>(entity =>
            {
                entity.HasKey(e => e.IdUnidad)
                    .HasName("PK__unidades__437725E670C9989E");

                entity.ToTable("unidades");

                entity.Property(e => e.Año).HasColumnType("date");

                entity.Property(e => e.CapacidadCarga)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Chasis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCompra).HasColumnType("date");

                entity.Property(e => e.FechaMantenimiento).HasColumnType("date");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VencimientoUnidad).HasColumnType("date");

                entity.HasOne(d => d.IdNeumaticoNavigation)
                    .WithMany(p => p.Unidades)
                    .HasForeignKey(d => d.IdNeumatico)
                    .HasConstraintName("fkTipoNeumatico");

                entity.HasOne(d => d.IdTipoUnidadNavigation)
                    .WithMany(p => p.Unidades)
                    .HasForeignKey(d => d.IdTipoUnidad)
                    .HasConstraintName("fkTipoUnidades");
            });

            modelBuilder.Entity<Viaje>(entity =>
            {
                entity.HasKey(e => e.IdViajes)
                    .HasName("PK__Viajes__3505F398668910A1");

                entity.Property(e => e.Destino)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Detalle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Entidad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EsFacturado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Escobrado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FormaDeCobro).HasColumnType("date");

                entity.Property(e => e.Ncontenedor).HasColumnName("NContenedor");

                entity.Property(e => e.Nfactura)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NFactura");

                entity.Property(e => e.Origen)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remito)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Tarifa).HasColumnType("money");

                entity.Property(e => e.Viajes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdChoferNavigation)
                    .WithMany(p => p.Viajes)
                    .HasForeignKey(d => d.IdChofer)
                    .HasConstraintName("fkChoferViaje");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Viajes)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("fkClienteViaje");

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.Viajes)
                    .HasForeignKey(d => d.IdLocalidad)
                    .HasConstraintName("fkViaLoca");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Viajes)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("fkViajePro");
            });

            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
