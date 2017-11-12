using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Entities
{
    public class Cabecera
    {

        public int Id { get; set; }

        public string TipoDocumento { get; set; }


        public string SerieDocumento { get; set; }


        public string NroDocumento { get; set; }


        public DateTime FechaDocumento { get; set; }


        public decimal TipoCambio { get; set; }


        public string Moneda { get; set; }


        public decimal TotalFactura { get; set; }

        public int ClienteId { get; set; }


        public int VendedorId { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Vendedor Vendedor { get; set; }

        public ICollection<Detalle> Detalles { get; set; }
    }
}
