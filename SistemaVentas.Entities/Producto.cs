using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Entities
{
    public class Producto
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public string UnidadMedidad { get; set; }

        public ICollection<Detalle> Detalles { get; set; }
    }
}
