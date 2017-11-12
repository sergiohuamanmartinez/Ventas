using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SistemaVentas.Data;

namespace SistemaVentas.Data.Migrations
{
    [DbContext(typeof(VentasDbContext))]
    partial class VentasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaVentas.Entities.Cabecera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("FechaDocumento");

                    b.Property<string>("Moneda");

                    b.Property<string>("NroDocumento");

                    b.Property<string>("SerieDocumento");

                    b.Property<decimal>("TipoCambio");

                    b.Property<string>("TipoDocumento");

                    b.Property<decimal>("TotalFactura");

                    b.Property<int>("VendedorId");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Cabecera");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Documento");

                    b.Property<string>("Nombre");

                    b.Property<int>("RolId");

                    b.Property<char>("Sexo");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Detalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CabeceraId");

                    b.Property<int>("Cantidad");

                    b.Property<decimal>("IGV");

                    b.Property<string>("NroDocumento");

                    b.Property<decimal>("Precio");

                    b.Property<int>("ProductoId");

                    b.Property<string>("SerieDocumento");

                    b.Property<decimal>("SubTotal");

                    b.Property<string>("TipoDocumento");

                    b.HasKey("Id");

                    b.HasIndex("CabeceraId");

                    b.HasIndex("ProductoId");

                    b.ToTable("Detalle");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("UnidadMedidad");

                    b.HasKey("Id");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.HasKey("Id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Clave");

                    b.Property<string>("Correo");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Documento");

                    b.Property<string>("Nombre");

                    b.Property<int>("RolId");

                    b.Property<char>("Sexo");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("SistemaVentas.Entities.Cabecera", b =>
                {
                    b.HasOne("SistemaVentas.Entities.Cliente", "Cliente")
                        .WithMany("Cabeceras")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaVentas.Entities.Vendedor", "Vendedor")
                        .WithMany("Cabeceras")
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SistemaVentas.Entities.Cliente", b =>
                {
                    b.HasOne("SistemaVentas.Entities.Rol", "Rol")
                        .WithMany("Clientes")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaVentas.Entities.Usuario", "Usuario")
                        .WithMany("Clientes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SistemaVentas.Entities.Detalle", b =>
                {
                    b.HasOne("SistemaVentas.Entities.Cabecera", "Cabecera")
                        .WithMany("Detalles")
                        .HasForeignKey("CabeceraId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaVentas.Entities.Producto", "Producto")
                        .WithMany("Detalles")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SistemaVentas.Entities.Vendedor", b =>
                {
                    b.HasOne("SistemaVentas.Entities.Rol", "Rol")
                        .WithMany("Vendedores")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaVentas.Entities.Usuario", "Usuario")
                        .WithMany("Vendedores")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
