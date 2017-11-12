using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVentas.Data;
using SistemaVentas.Business;
using SistemaVentas.Portal.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SistemaVentas.Portal.Controllers
{
    //[PruebaFilterAttribute]
    public class ProductoController : Controller
    {
        private readonly ProductoNegocio _negocio;
        public ProductoController(VentasDbContext context) {
            _negocio = new ProductoNegocio(context);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var productos = _negocio.ObtenerProductos();
            var viewModel = new ProductoViewModel
            {
                Productos = productos
            };
            return View(viewModel);
        }


        public IActionResult Detalle(int id)
        {
            var producto = _negocio.ObtenerProducto(id);
            return View(producto);
        }

        [Route("producto/Editar")]
        [Route("producto/Edicion")]
        public IActionResult Editar(int id)
        {
            return View("Editar");
        }

        public IActionResult Crear() {
            return View();
        }
    }
}
