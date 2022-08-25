using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public  class Visita
    {
        [Key]
        public int VisitaId { get; set; }
        
        public Mascota? Mascota { get; set; }
        public Veterinario? Veterinario { get; set; }
        
        public string? Fecha { get; set; }
        public ICollection<DetalleVisita>? DetalleVisitas { get; set; }
    }
}
