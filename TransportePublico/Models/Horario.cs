using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportePublico.Models
{
    public class Horario
    {
        [Key]
        public int IDHorario { get; set; }
        public int IDEstacion { get; set; }
        public int IDRuta { get; set; }

        [Required(ErrorMessage ="Debe ingresar la {0}")]
        [DataType(DataType.Time)]
        public string Hora { get; set; }

        public Estacion Estacion { get; set; }
        public Ruta Ruta { get; set; }
    }
}