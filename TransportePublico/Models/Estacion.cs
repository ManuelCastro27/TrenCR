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
        [Display(Name = "Identificador de Estación")]
        public int IDEstacion { get; set; }

        [Required(ErrorMessage ="Debe ingresar el {0}")]
        [StringLength(40, ErrorMessage ="El {0} no debe superar los {1} caracteres")]
        [Display(Name ="Nombre de Estación")]
        public string NombreEstacion { get; set; }

        public List<Horario> Horarios { get; set; }
    }
}
