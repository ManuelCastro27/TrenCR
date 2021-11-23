using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportePublico.Models;

namespace TransportePublico.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Estacion> Estacion { get; set; }
        public DbSet<Ruta> Ruta { get; set; }
        public DbSet<Horario> Horario { get; set; }
    }
}
