using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turnos.Models
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }

        [Display(Name = "Nombre(s)")]
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar un apellido")]
        public string Apellido { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Debe ingresar una dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "Debe ingresar un teléfono")]
        public string Telefono { get; set; }

        [EmailAddress(ErrorMessage = "No es una dirección de correo electrónico válido")]
        [Required(ErrorMessage = "Debe ingresar un correo eletrónico")]
        public string Email { get; set; }

        public List<Turno> Turno {get; set;}

    }
}
