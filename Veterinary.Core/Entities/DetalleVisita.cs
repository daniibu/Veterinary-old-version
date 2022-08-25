using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Core.Entities
{
    public class DetalleVisita
    {
        public int DetalleVisitaId { get; set; }
        
        public Visita? Visita { get; set; }
        public Procedimiento? Procedimiento { get; set; }
        public string? Precio { get; set; }
    }
}
