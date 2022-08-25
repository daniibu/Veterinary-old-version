using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public class Especialidad
    {
        [Key]
        public int EspecialidadId { get; set; }
        public ICollection<Veterinario>? Veterinarios { get; set; }
    }
}
