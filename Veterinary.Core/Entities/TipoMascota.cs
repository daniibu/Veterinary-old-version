﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public class TipoMascota
    {
        [Key]
        public int TipoId { get; set; }
        public string? Tipo { get; set; }
        public ICollection<Mascota>? Mascotas { get; set; }
    }
}
