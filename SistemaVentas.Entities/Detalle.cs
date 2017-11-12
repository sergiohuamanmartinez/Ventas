using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Entities
{
    public class Detalle
    {
        public int Id { get; set; }

        public string TipoDocumento { get; set; }

        public string SerieDocumento { get; set; }

        public string NroDocumento { get; set; }

        public int CabeceraId { get; set; } 

        public int ProductoId { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal SubTotal { get; set; }

        public decimal IGV { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual Cabecera Cabecera { get; set; }
    }
}
