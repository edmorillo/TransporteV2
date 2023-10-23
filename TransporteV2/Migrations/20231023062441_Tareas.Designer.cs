﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransporteV2.Entidades;

#nullable disable

namespace TransporteV2.Migrations
{
    [DbContext(typeof(TAIProContext))]
    [Migration("20231023062441_Tareas")]
    partial class Tareas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TransporteV2.Entidades.Chofere", b =>
                {
                    b.Property<int>("IdChofer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdChofer"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Celular")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Cuil")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("FechaAlta")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FechaBaja")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<int?>("IdProvincia")
                        .HasColumnType("int");

                    b.Property<int?>("IdTdocuC")
                        .HasColumnType("int")
                        .HasColumnName("IdTDocuC");

                    b.Property<string>("Ndocumento")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("NDocumento");

                    b.Property<string>("Nombre")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("NuTramite")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("IdChofer")
                        .HasName("PK__Choferes__2DF292AD84EC903F");

                    b.HasIndex("IdProvincia");

                    b.HasIndex("IdTdocuC");

                    b.ToTable("Choferes");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("CodigoPostal")
                        .HasColumnType("int");

                    b.Property<string>("Cuit")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(70)
                        .IsUnicode(false)
                        .HasColumnType("varchar(70)");

                    b.Property<int?>("IdCondicionIva")
                        .HasColumnType("int")
                        .HasColumnName("IdCondicionIVA");

                    b.Property<int?>("IdProvincia")
                        .HasColumnType("int");

                    b.Property<string>("IngresosBrutos")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("RazonSocial")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("IdCliente")
                        .HasName("PK__Clientes__D5946642A0271A99");

                    b.HasIndex("IdCondicionIva");

                    b.HasIndex("IdProvincia");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Compra", b =>
                {
                    b.Property<int>("IdCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCompra"), 1L, 1);

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Detalle")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("FechaCompra")
                        .HasColumnType("date");

                    b.Property<int?>("IdFormaPago")
                        .HasColumnType("int");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("money");

                    b.HasKey("IdCompra")
                        .HasName("PK__Compras__0A5CDB5CD89F0A96");

                    b.HasIndex("IdFormaPago");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("TransporteV2.Entidades.CondicionIva", b =>
                {
                    b.Property<int>("IdCondicionIva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCondicionIVA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCondicionIva"), 1L, 1);

                    b.Property<string>("CondicionIva1")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("CondicionIVA");

                    b.HasKey("IdCondicionIva")
                        .HasName("PK__Condicio__1B2D154EF6E39205");

                    b.ToTable("CondicionIVAS", (string)null);
                });

            modelBuilder.Entity("TransporteV2.Entidades.FormasPago", b =>
                {
                    b.Property<int>("IdFormaPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFormaPago"), 1L, 1);

                    b.Property<string>("FormaPago")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdFormaPago")
                        .HasName("PK__FormasPa__C777CA6894966A5A");

                    b.ToTable("FormasPagos");
                });

            modelBuilder.Entity("TransporteV2.Entidades.LicenciaChofer", b =>
                {
                    b.Property<int>("IdLicenciaChofer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLicenciaChofer"), 1L, 1);

                    b.Property<DateTime?>("FechaVencimiento")
                        .HasColumnType("date");

                    b.Property<int?>("IdChofer")
                        .HasColumnType("int");

                    b.Property<int?>("IdTiposDocumentos")
                        .HasColumnType("int");

                    b.HasKey("IdLicenciaChofer")
                        .HasName("PK__Licencia__95068A926B2D4C75");

                    b.HasIndex("IdChofer");

                    b.HasIndex("IdTiposDocumentos");

                    b.ToTable("LicenciaChofer", (string)null);
                });

            modelBuilder.Entity("TransporteV2.Entidades.LicenciasUnidad", b =>
                {
                    b.Property<int>("IdLicenciaUnidades")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLicenciaUnidades"), 1L, 1);

                    b.Property<DateTime?>("FechaVencimiento")
                        .HasColumnType("date")
                        .HasColumnName("fechaVencimiento");

                    b.Property<int?>("IdTiposDocumentos")
                        .HasColumnType("int");

                    b.Property<int?>("IdUnidad")
                        .HasColumnType("int");

                    b.HasKey("IdLicenciaUnidades")
                        .HasName("PK__Licencia__3D090F1BEAD20CD8");

                    b.HasIndex("IdTiposDocumentos");

                    b.HasIndex("IdUnidad");

                    b.ToTable("LicenciasUnidad", (string)null);
                });

            modelBuilder.Entity("TransporteV2.Entidades.Localidade", b =>
                {
                    b.Property<int>("IdLocalidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLocalidad"), 1L, 1);

                    b.Property<int?>("IdProvincia")
                        .HasColumnType("int");

                    b.Property<string>("Localidad")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdLocalidad")
                        .HasName("PK__Localida__274326128935C346");

                    b.HasIndex("IdProvincia");

                    b.ToTable("Localidades");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Neumatico", b =>
                {
                    b.Property<int>("IdNeumatico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNeumatico"), 1L, 1);

                    b.Property<int?>("IdTipoMarcaNeumaticos")
                        .HasColumnType("int");

                    b.Property<int?>("Kilometraje")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("Modelo")
                        .HasColumnType("int");

                    b.Property<int?>("Rodado")
                        .HasColumnType("int");

                    b.HasKey("IdNeumatico")
                        .HasName("PK__Neumatic__AA974EFDCAC6EE99");

                    b.HasIndex("IdTipoMarcaNeumaticos");

                    b.ToTable("Neumatico", (string)null);
                });

            modelBuilder.Entity("TransporteV2.Entidades.Provincium", b =>
                {
                    b.Property<int>("IdProvincia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProvincia"), 1L, 1);

                    b.Property<string>("Provincia")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdProvincia")
                        .HasName("PK__Provinci__EED7445533884C2E");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UsuarioCreacionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("TransporteV2.Entidades.TdocumentoC", b =>
                {
                    b.Property<int>("IdTdocuC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTDocuC");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTdocuC"), 1L, 1);

                    b.Property<string>("Detalle")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdTdocuC")
                        .HasName("PK__TDocumen__9E7A4BFF29D273A4");

                    b.ToTable("TDocumentoC", (string)null);
                });

            modelBuilder.Entity("TransporteV2.Entidades.TipoMarcasNeumatico", b =>
                {
                    b.Property<int>("IdTipoMarcaNeumaticos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoMarcaNeumaticos"), 1L, 1);

                    b.Property<string>("TipoMarcaNeumatico")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdTipoMarcaNeumaticos")
                        .HasName("PK__TipoMarc__2DD5A366A459AE87");

                    b.ToTable("TipoMarcasNeumaticos");
                });

            modelBuilder.Entity("TransporteV2.Entidades.TipoMarcasUnidade", b =>
                {
                    b.Property<int>("IdTipoMarcaUnidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoMarcaUnidad"), 1L, 1);

                    b.Property<string>("TipoMarcaUnidad")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdTipoMarcaUnidad")
                        .HasName("PK__TipoMarc__ED7D29C76BE35C58");

                    b.ToTable("TipoMarcasUnidades");
                });

            modelBuilder.Entity("TransporteV2.Entidades.TiposDocumento", b =>
                {
                    b.Property<int>("IdTiposDocumentos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTiposDocumentos"), 1L, 1);

                    b.Property<string>("TipoDocumento")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdTiposDocumentos")
                        .HasName("PK__TiposDoc__A9B5CFE905D00CFD");

                    b.ToTable("TiposDocumentos");
                });

            modelBuilder.Entity("TransporteV2.Entidades.TipoUnidade", b =>
                {
                    b.Property<int>("IdTipoUnidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoUnidad"), 1L, 1);

                    b.Property<string>("Detalle")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("IdTipoMarcaUnidades")
                        .HasColumnType("int");

                    b.HasKey("IdTipoUnidad")
                        .HasName("PK__TipoUnid__23FD7E6AA5A3449F");

                    b.HasIndex("IdTipoMarcaUnidades");

                    b.ToTable("TipoUnidades");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Unidade", b =>
                {
                    b.Property<int>("IdUnidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUnidad"), 1L, 1);

                    b.Property<DateTime?>("Año")
                        .HasColumnType("date");

                    b.Property<string>("CapacidadCarga")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Chasis")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("FechaCompra")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FechaMantenimiento")
                        .HasColumnType("date");

                    b.Property<int?>("IdNeumatico")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoUnidad")
                        .HasColumnType("int");

                    b.Property<int?>("Kilometros")
                        .HasColumnType("int");

                    b.Property<string>("Matricula")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Modelo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("VencimientoUnidad")
                        .HasColumnType("date");

                    b.HasKey("IdUnidad")
                        .HasName("PK__unidades__437725E670C9989E");

                    b.HasIndex("IdNeumatico");

                    b.HasIndex("IdTipoUnidad");

                    b.ToTable("unidades", (string)null);
                });

            modelBuilder.Entity("TransporteV2.Entidades.Viaje", b =>
                {
                    b.Property<int>("IdViajes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdViajes"), 1L, 1);

                    b.Property<string>("Destino")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Detalle")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Entidad")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EsFacturado")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Escobrado")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("FormaDeCobro")
                        .HasColumnType("date");

                    b.Property<int?>("IdChofer")
                        .HasColumnType("int");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdLocalidad")
                        .HasColumnType("int");

                    b.Property<int?>("IdProvincia")
                        .HasColumnType("int");

                    b.Property<int?>("Ncontenedor")
                        .HasColumnType("int")
                        .HasColumnName("NContenedor");

                    b.Property<string>("Nfactura")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("NFactura");

                    b.Property<string>("Origen")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Remito")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<decimal?>("Tarifa")
                        .HasColumnType("money");

                    b.Property<string>("Viajes")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdViajes")
                        .HasName("PK__Viajes__3505F398668910A1");

                    b.HasIndex("IdChofer");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdLocalidad");

                    b.HasIndex("IdProvincia");

                    b.ToTable("Viajes");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Chofere", b =>
                {
                    b.HasOne("TransporteV2.Entidades.Provincium", "IdProvinciaNavigation")
                        .WithMany("Choferes")
                        .HasForeignKey("IdProvincia")
                        .HasConstraintName("fkChoferePro");

                    b.HasOne("TransporteV2.Entidades.TdocumentoC", "IdTdocuCNavigation")
                        .WithMany("Choferes")
                        .HasForeignKey("IdTdocuC")
                        .HasConstraintName("fk");

                    b.Navigation("IdProvinciaNavigation");

                    b.Navigation("IdTdocuCNavigation");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Cliente", b =>
                {
                    b.HasOne("TransporteV2.Entidades.CondicionIva", "IdCondicionIvaNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("IdCondicionIva")
                        .HasConstraintName("fkClienIVA");

                    b.HasOne("TransporteV2.Entidades.Provincium", "IdProvinciaNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("IdProvincia")
                        .HasConstraintName("fkCliPro");

                    b.Navigation("IdCondicionIvaNavigation");

                    b.Navigation("IdProvinciaNavigation");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Compra", b =>
                {
                    b.HasOne("TransporteV2.Entidades.FormasPago", "IdFormaPagoNavigation")
                        .WithMany("Compras")
                        .HasForeignKey("IdFormaPago")
                        .HasConstraintName("fk_Forma_Pagos");

                    b.Navigation("IdFormaPagoNavigation");
                });

            modelBuilder.Entity("TransporteV2.Entidades.LicenciaChofer", b =>
                {
                    b.HasOne("TransporteV2.Entidades.Chofere", "IdChoferNavigation")
                        .WithMany("LicenciaChofers")
                        .HasForeignKey("IdChofer")
                        .HasConstraintName("fkLiceChofer");

                    b.HasOne("TransporteV2.Entidades.TiposDocumento", "IdTiposDocumentosNavigation")
                        .WithMany("LicenciaChofers")
                        .HasForeignKey("IdTiposDocumentos")
                        .HasConstraintName("fkLiceDocu");

                    b.Navigation("IdChoferNavigation");

                    b.Navigation("IdTiposDocumentosNavigation");
                });

            modelBuilder.Entity("TransporteV2.Entidades.LicenciasUnidad", b =>
                {
                    b.HasOne("TransporteV2.Entidades.TiposDocumento", "IdTiposDocumentosNavigation")
                        .WithMany("LicenciasUnidads")
                        .HasForeignKey("IdTiposDocumentos")
                        .HasConstraintName("fkLicenciaDocumentos");

                    b.HasOne("TransporteV2.Entidades.Unidade", "IdUnidadNavigation")
                        .WithMany("LicenciasUnidads")
                        .HasForeignKey("IdUnidad")
                        .HasConstraintName("fkLicenciasUnidades");

                    b.Navigation("IdTiposDocumentosNavigation");

                    b.Navigation("IdUnidadNavigation");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Localidade", b =>
                {
                    b.HasOne("TransporteV2.Entidades.Provincium", "IdProvinciaNavigation")
                        .WithMany("Localidades")
                        .HasForeignKey("IdProvincia")
                        .HasConstraintName("fkLocalidadPro");

                    b.Navigation("IdProvinciaNavigation");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Neumatico", b =>
                {
                    b.HasOne("TransporteV2.Entidades.TipoMarcasNeumatico", "IdTipoMarcaNeumaticosNavigation")
                        .WithMany("Neumaticos")
                        .HasForeignKey("IdTipoMarcaNeumaticos")
                        .HasConstraintName("fkMarcaNeumatico");

                    b.Navigation("IdTipoMarcaNeumaticosNavigation");
                });

            modelBuilder.Entity("TransporteV2.Entidades.TipoUnidade", b =>
                {
                    b.HasOne("TransporteV2.Entidades.TipoMarcasUnidade", "IdTipoMarcaUnidadesNavigation")
                        .WithMany("TipoUnidades")
                        .HasForeignKey("IdTipoMarcaUnidades")
                        .HasConstraintName("fkTiposUnidades");

                    b.Navigation("IdTipoMarcaUnidadesNavigation");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Unidade", b =>
                {
                    b.HasOne("TransporteV2.Entidades.Neumatico", "IdNeumaticoNavigation")
                        .WithMany("Unidades")
                        .HasForeignKey("IdNeumatico")
                        .HasConstraintName("fkTipoNeumatico");

                    b.HasOne("TransporteV2.Entidades.TipoUnidade", "IdTipoUnidadNavigation")
                        .WithMany("Unidades")
                        .HasForeignKey("IdTipoUnidad")
                        .HasConstraintName("fkTipoUnidades");

                    b.Navigation("IdNeumaticoNavigation");

                    b.Navigation("IdTipoUnidadNavigation");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Viaje", b =>
                {
                    b.HasOne("TransporteV2.Entidades.Chofere", "IdChoferNavigation")
                        .WithMany("Viajes")
                        .HasForeignKey("IdChofer")
                        .HasConstraintName("fkChoferViaje");

                    b.HasOne("TransporteV2.Entidades.Cliente", "IdClienteNavigation")
                        .WithMany("Viajes")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("fkClienteViaje");

                    b.HasOne("TransporteV2.Entidades.Localidade", "IdLocalidadNavigation")
                        .WithMany("Viajes")
                        .HasForeignKey("IdLocalidad")
                        .HasConstraintName("fkViaLoca");

                    b.HasOne("TransporteV2.Entidades.Provincium", "IdProvinciaNavigation")
                        .WithMany("Viajes")
                        .HasForeignKey("IdProvincia")
                        .HasConstraintName("fkViajePro");

                    b.Navigation("IdChoferNavigation");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdLocalidadNavigation");

                    b.Navigation("IdProvinciaNavigation");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Chofere", b =>
                {
                    b.Navigation("LicenciaChofers");

                    b.Navigation("Viajes");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Cliente", b =>
                {
                    b.Navigation("Viajes");
                });

            modelBuilder.Entity("TransporteV2.Entidades.CondicionIva", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("TransporteV2.Entidades.FormasPago", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Localidade", b =>
                {
                    b.Navigation("Viajes");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Neumatico", b =>
                {
                    b.Navigation("Unidades");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Provincium", b =>
                {
                    b.Navigation("Choferes");

                    b.Navigation("Clientes");

                    b.Navigation("Localidades");

                    b.Navigation("Viajes");
                });

            modelBuilder.Entity("TransporteV2.Entidades.TdocumentoC", b =>
                {
                    b.Navigation("Choferes");
                });

            modelBuilder.Entity("TransporteV2.Entidades.TipoMarcasNeumatico", b =>
                {
                    b.Navigation("Neumaticos");
                });

            modelBuilder.Entity("TransporteV2.Entidades.TipoMarcasUnidade", b =>
                {
                    b.Navigation("TipoUnidades");
                });

            modelBuilder.Entity("TransporteV2.Entidades.TiposDocumento", b =>
                {
                    b.Navigation("LicenciaChofers");

                    b.Navigation("LicenciasUnidads");
                });

            modelBuilder.Entity("TransporteV2.Entidades.TipoUnidade", b =>
                {
                    b.Navigation("Unidades");
                });

            modelBuilder.Entity("TransporteV2.Entidades.Unidade", b =>
                {
                    b.Navigation("LicenciasUnidads");
                });
#pragma warning restore 612, 618
        }
    }
}
