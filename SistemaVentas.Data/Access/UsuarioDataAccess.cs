using SistemaVentas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentas.Data.Access
{
    public class UsuarioDataAccess
    {

        private readonly VentasDbContext _context;


        public UsuarioDataAccess(VentasDbContext context)
        {
            _context = context;
        }


        public List<Usuario> ObtenerUsuarios()
        {
            return _context.Usuario.ToList();
        }

        public Usuario ObtenerUsuario(int id)
        {
            var usuario = _context.Usuario.FirstOrDefault(c => c.Id == id);
            return usuario;
        }

        public bool ValidarUsuario(string usuario, string clave)
        {
            var usuarios = _context.Usuario.ToList();
            var isUser = false;
            foreach (var item in usuarios)
            {
                if (item.Correo.Equals(usuario) && item.Clave.Equals(clave))
                {
                    isUser = true;
                    break;
                }
            }
            return isUser;
        }

        public int RegistrarUsuario(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
            return usuario.Id;
        }
    }
}
