using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public class Veterinario
    {
        [Key]
        public int VeterinarioId { get; set; }
        public string? VeterinarioNombre { get; set; }
        public string? VeterinarioApellido { get; set; }
        public string? DomicilioVeterinario { get; set; }
        public string? TelVeterinario { get; set; }
        public string? DNI_Veterinario { get; set; }
        public Especialidad? Especialidad { get; set; }
        public ICollection<Visita>? Visitas { get; set; }

    }
}
