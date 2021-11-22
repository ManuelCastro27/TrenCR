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

        [Required(ErrorMessage = "Debe ingresar el {0}")]
        [StringLength(40, ErrorMessage = "El {0} no debe superar los {1} caracteres")]
        [Display(Name = "Nombre de Ruta")] 
        public string NombreRuta { get; set; }
    }
}
