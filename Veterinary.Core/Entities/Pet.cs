﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public class Pet
    {
        public int PetId { get; set; }
        public string? PetName { get; set; }
        public int ClientId { get; set; }
        public int typeId { get; set; }
        //Datos de auditoría.
        public DateTime DateUpload { get; set; }
        public DateTime DateUpdate { get; set; }
        public int User { get; set; }

    }
}
