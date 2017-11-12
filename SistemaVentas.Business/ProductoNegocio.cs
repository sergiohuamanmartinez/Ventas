using SistemaVentas.Data;
using SistemaVentas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentas.Business
{
    public class ProductoNegocio
    {
        private readonly VentasDbContext _context;


        public ProductoNegocio(VentasDbContext context)
        {
            _context = context;
        }

        public List<Producto> ObtenerProductos()
        {
            return _context.Producto.ToList();
        }

        public Producto ObtenerProducto(int id) {
            var producto = _context.Producto.FirstOrDefault(c => c.Id == id);
            return producto;
        }

    }
}
