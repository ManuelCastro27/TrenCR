using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportePublico.Models
{
    public class Ruta
    {
        [Key]
        public int IDRuta { get; set; }

        public string Nombre { get; set; }
    }
}
