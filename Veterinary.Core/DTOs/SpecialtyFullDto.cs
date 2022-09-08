using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Core.DTOs
{
    public class SpecialtyFullDto
    {
        public int specialtyId { get; set; }
        public string? specialty { get; set; }

        //Audit Data
        public DateTime dateUpload { get; set; }
        public DateTime dateUpdate { get; set; }
        public int user { get; set; }
    }
}
