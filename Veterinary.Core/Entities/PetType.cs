using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public class PetType
    {
        public int TypeId { get; set; }
        public string? Type { get; set; }

        //Audit data
        public DateTime DateUpload { get; set; }
        public DateTime DateUpdate { get; set; }
        public int User { get; set; }
    }
}
