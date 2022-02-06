using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MasActitud.Models;

namespace MasActitud.Models
{
    public class Trabajador
    {
        public Trabajador()
        {
            this.Contratos = new HashSet<Contrato>();
        }

        [Required(ErrorMessage = "El tipo de identificación es requerido.")]
        public string tipoIdentificacion { get; set; }

        [Key]
        [Column(Order = 1)]
        public string numeroIdentificacion { get; set; }

        [Required(ErrorMessage = "El primer nombre es requerido.")]
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es requerido.")]
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es requerida.")]
        [DataType(DataType.Date)]
        public DateTime fechaNacimiento { get; set; }

        [Required]
        public int Edad { get; set; }
        public virtual ICollection<Contrato> Contratos { get; set; }
    }
}
