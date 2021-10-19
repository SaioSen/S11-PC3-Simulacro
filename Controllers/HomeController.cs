using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using S11_PC3_Simulacro.Data;
using S11_PC3_Simulacro.Models;

namespace S11_PC3_Simulacro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var p = _context.DataProductos.ToList();
            return View(p); 
        }

        public IActionResult FormularioProducto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormularioProducto(Producto p)
        {
            if(ModelState.IsValid){
                //guardar el objeto sa en la BD
                
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
