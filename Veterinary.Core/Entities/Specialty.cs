using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public class Specialty
    {
        public int SpecialtyId { get; set; }
        public string? specialty { get; set; }

        //Audit Data
        public DateTime DateUpload { get; set; }
        public DateTime DateUpdate { get; set; }
        public int user { get; set; }
    }
}
