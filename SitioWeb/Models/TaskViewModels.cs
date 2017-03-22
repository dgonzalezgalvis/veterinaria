using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SitioWeb.Models
{
    public class TaskViewModel
    {
        [Required]
        [Display(Name = "Mascota")]
        public string Mascota { get; set; }

        [Required]
        [Display(Name = "TipoDeTarea")]
        public TaskType Type { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "FechaHora")]
        public string FechaHora { get; set; }

    }

    public class TaskType
    {
        public TaskType(int id, string tipo, string nombre, string costo)
        {
            this.Nombre = nombre;
            this.Costo = costo;
            this.Tipo = tipo;
        }

        public int TaskId { get; set; }

        public string Tipo { get; set; }

        public string Nombre { get; set; }

        public string Costo { get; set; }
    }
}
