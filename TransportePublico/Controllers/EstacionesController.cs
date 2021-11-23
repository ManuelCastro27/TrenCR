using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportePublico.Data;
using TransportePublico.Models;

namespace TransportePublico.Controllers
{
    public class EstacionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstacionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        //http get index
        public IActionResult Index()
        {
            IEnumerable<Estacion> listaEstaciones = _context.Estacion;
            return View(listaEstaciones);
        }
    }
}
