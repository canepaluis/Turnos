using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turnos.Models
{
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }

        [Display(Name = "Nombre(s)")]
        [Required (ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar un apellido")]
        public string Apellido { get; set; }

        [Display(Name = "Dirección")]
        [Required (ErrorMessage = "Debe ingresar una dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Teléfono")]
        [Required (ErrorMessage = "Debe ingresar un número de teléfono")]
        public string Telefono { get; set; }

        [EmailAddress (ErrorMessage = "No es una dirección de correo electrónico válido")]
        [Required (ErrorMessage = "Debe ingresar un correo electrónico")]
        public string Email { get; set; }

        [Display(Name = "Horario desde")]
        [DataType (DataType.Time)]
        [DisplayFormat (DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Debe ingresar un horario")]
        public DateTime HorarioAtencionDesde { get; set; }

        [Display(Name = "Horario hasta")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Debe ingresar un horario")]
        public DateTime HorarioAtencionHasta { get; set; }

        public List<MedicoEspecialidad> MedicoEspecialidad { get; set; }

        public List<Turno> Turno { get; set; }
    }
}
