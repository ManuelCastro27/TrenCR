using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportePublico.Models
{
    public class Estacion
    {
        [Key]
        public int IDEstacion { get; set; }

        public string NombreEstacion { get; set; }
    }
}
