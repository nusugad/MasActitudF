using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MasActitud.Models
{
    public class Contrato
    {
        public string nombreEntidad { get; set; }

        [Key]
        public int numeroContrato { get; set; }

        [ForeignKey("Trabajador")]
        [Column(Order = 1)]

        [Required(ErrorMessage = "El numero de identificación es requerido.")]
        public int numeroIdentificacion { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es requerida.")]
        [DataType(DataType.Date)]
        public DateTime fechaInicio { get; set; }

        [Required(ErrorMessage = "El primer apellido es requerido.")]
        [DataType(DataType.Date)]
        public DateTime fechaFinalizacion { get; set; }
        public virtual Trabajador Trabajador { get; set; }
    }
}
