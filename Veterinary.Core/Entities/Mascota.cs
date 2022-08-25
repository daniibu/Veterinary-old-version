using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public class Mascota
    {
        [Key]
        public int MascotaId { get; set; }
        public string? NombreMascota { get; set; }

        public int ClienteId { get; set; }

        //Auditoria:fecha de alta,baja y modificación
        [DataType(DataType.Date)]
        public DateTime FechaAlta { get; set; }

        [DataType(DataType.Date)]
        public DateOnly FechaBaja { get; set; }

        [DataType(DataType.Date)]
        public DateTime Modificación { get; set; }

        public ICollection<Visita>? Visitas { get; set; }
        public TipoMascota? TipoMascota { get; set; }

    }
}
