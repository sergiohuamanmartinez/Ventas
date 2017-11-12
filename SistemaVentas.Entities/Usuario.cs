using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Correo { get; set; }

        public string Clave { get; set; }

        public ICollection<Vendedor> Vendedores { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
    }
}
