using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentas.Portal.Models
{
    public class UsuarioViewModel
    {
        public int UsuarioId { get; set; }

        public int RolId { get; set; }

        public string Correo { get; set; }

        public string Clave { get; set; }

        public string Descripcion { get; set; }
    }
}
