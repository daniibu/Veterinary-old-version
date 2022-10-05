using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Core.DTOs
{
    public class VetFullDto
    {
        public int vetId { get; set; }
        public string? vetName { get; set; }
        public string? vetSurName { get; set; }
        public string? vetAdress { get; set; }
        public string? vetPhoneNum { get; set; }
        public string? vetIdn { get; set; }
        public int specialtyId { get; set; }
        //Audit Data.
        public DateTime dateUpload { get; set; }
        public DateTime dateUpdate { get; set; }
        public int user { get; set; }
    }
}
