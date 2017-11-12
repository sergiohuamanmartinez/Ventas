using SistemaVentas.Data;
using SistemaVentas.Data.Access;
using SistemaVentas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentas.Business
{
    public class UsuarionNegocio
    {
        //private readonly VentasDbContext _context;
        private readonly UsuarioDataAccess _dataAccess;

        public UsuarionNegocio(VentasDbContext context)
        {
            //_context = context;
            _dataAccess = new UsuarioDataAccess(context);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return _dataAccess.ObtenerUsuarios();
            //return _context.Usuario.ToList();
        }

        public Usuario ObtenerUsuario(int id)
        {
            //var usuario = _context.Usuario.FirstOrDefault(c => c.Id == id);
            var usuario = _dataAccess.ObtenerUsuario(id);
            return usuario;
        }

        public bool ValidarUsuario(string usuario, string clave) {
            //var usuarios = _context.Usuario.ToList();
            var usuarios = _dataAccess.ObtenerUsuarios();
            var isUser = false;
            foreach (var item in usuarios)
            {
                if(item.Correo.Equals(usuario) && item.Clave.Equals(clave))
                {
                    isUser = true;
                    break;
                }
            }
            return isUser;
        }

        public int RegistrarUsuario(Usuario usuario) {
            //_context.Usuario.Add(usuario);
            //_context.SaveChanges();
            //return usuario.Id;
            return _dataAccess.RegistrarUsuario(usuario);
        }

    }
}
