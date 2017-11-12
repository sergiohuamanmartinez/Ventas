using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Entities
{
    public class Cliente
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Documento { get; set; }

        public char Sexo { get; set; }

        public int UsuarioId { get; set; }

        public int RolId { get; set; }
        
        public virtual Usuario Usuario { get; set; }

        public virtual Rol Rol { get; set; }

        public ICollection<Cabecera> Cabeceras { get; set; }
    }
}
