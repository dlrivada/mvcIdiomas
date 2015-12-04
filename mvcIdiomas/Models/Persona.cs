using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcIdiomas.idiomas;

namespace mvcIdiomas.Models
{
    public class Persona
    {
        [Display(ResourceType = typeof(Personas), Name = "nombre")]
        [Required(ErrorMessageResourceType = typeof(Personas), ErrorMessageResourceName = "nombre_o")]
        public string Nombre { get; set; }
        [Display(ResourceType = typeof(Personas), Name = "saldo")]
        [Required(ErrorMessageResourceType = typeof(Personas), ErrorMessageResourceName = "saldo_o")]
        [DataType(DataType.Currency, ErrorMessageResourceType = typeof(Personas), ErrorMessageResourceName = "saldo_c")]
        public double Saldo { get; set; }
    }
}
