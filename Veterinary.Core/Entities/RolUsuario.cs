using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public class RolUsuario
    {
        public int RolUsuarioId { get; set; }
        public string? NombreRolUsuario { get; set; }
        public string? ApellidoRolUsuario { get; set; }
    }
}
