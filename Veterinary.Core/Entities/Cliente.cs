using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string? NombreCliente { get; set; }
        public string? ApellidoCliente { get; set; }
        public string? DNI_Cliente { get; set; }
        public string? DomicilioCliente { get; set; }
        public string? TelCliente { get; set; }

        //Auditoria:fecha de alta,baja y modificación
        [DataType(DataType.Date)]
        public DateTime FechaAlta { get; set; }

        [DataType(DataType.Date)]
        public DateOnly FechaBaja { get; set; }

        [DataType(DataType.Date)]
        public DateTime Modificación { get; set; }
    }
}
