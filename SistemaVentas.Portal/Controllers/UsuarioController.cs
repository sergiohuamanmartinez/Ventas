using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVentas.Data;
using SistemaVentas.Business;
using SistemaVentas.Portal.Models;

namespace SistemaVentas.Portal.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarionNegocio _negocio;
        public UsuarioController(VentasDbContext context)
        {
            _negocio = new UsuarionNegocio(context);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UsuarioViewModel usuario)
        {
            var isUser = _negocio.ValidarUsuario(usuario.Correo, usuario.Clave);
            if (isUser) return RedirectToAction("Index", "Home");
            else return View(usuario);
        }

        [HttpGet]
        public IActionResult Registrar() {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(UsuarioViewModel usuario)
        {
            
            return View();
        }
    }
}