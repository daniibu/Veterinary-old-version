using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public class Procedimiento
    {
        [Key]
        public int ProcedimientoId { get; set; }
        public ICollection<DetalleVisita>? DetalleVisitas { get; set; }
    }
}
