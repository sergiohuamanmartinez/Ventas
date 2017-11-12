using Microsoft.EntityFrameworkCore;
using SistemaVentas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentas.Data
{
    public class VentasDbContext: DbContext
    {
        public VentasDbContext(DbContextOptions<VentasDbContext> options) : base(options) {
        }

        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Vendedor> Vendedor { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Cabecera> Cabecera { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Detalle> Detalle { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
