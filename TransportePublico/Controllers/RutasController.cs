using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportePublico.Data;
using TransportePublico.Models;

namespace TransportePublico.Controllers
{
    public class RutasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RutasController(ApplicationDbContext context)
        {
            _context = context;
        }

        //http get index
        public IActionResult Index()
        {
            IEnumerable<Ruta> listaRutas = _context.Ruta;
            return View(listaRutas);
        }

        //http get create
        public IActionResult Create()
        {
            return View();
        }

        //http post create
        [HttpPost]
        public IActionResult Create(Ruta ruta)
        {
            if(ModelState.IsValid)
            {
                _context.Ruta.Add(ruta);
                _context.SaveChanges();

                TempData["mensaje"] = "La ruta se agrego correctamente...";
                return RedirectToAction("Index");
            }

            return View();
        }

        //http get Edit
        public IActionResult Edit(int? id)
        {
            if(id==null||id==0)
            {
                return NotFound();
            }

            //Obtener el libro
            var ruta = _context.Ruta.Find(id);

            if(ruta == null)
            {
                return NotFound();
            }
            return View(ruta);
        }
    }
}
