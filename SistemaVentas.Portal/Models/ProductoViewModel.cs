using SistemaVentas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentas.Portal.Models
{
    public class ProductoViewModel
    {
        public List<Producto> Productos { get; set; }

        public bool ExistenProductos => Productos.Count > 0;
    }
}
