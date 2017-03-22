using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SitioWeb.Models
{
    public class PetViewModel
    {
        [Required]
        [Display(Name = "Correo electrónico")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Correo electrónico")]
        public string Apodo { get; set; }

        [Required]
        [Display(Name = "Costo Total")]
        public string Costo { get; set; }

        [Required]
        [Display(Name = "Fecha Próxima Tarea")]
        public string FechaProximaTarea { get; set; }

        [Required]
        [Display(Name = "Tareas Pendientes del Día")]
        public string TareasPendientesDia { get; set; }

        [Required]
        [Display(Name = "Porcentaje Tareas Realizadas")]
        public string TareasRealizadas { get; set; }

        [Required]
        [Display(Name = "Raza")]
        public string Raza { get; set; }
    }
}
