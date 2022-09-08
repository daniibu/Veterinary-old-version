using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public class Vet
    {
        public int vetId { get; set; }
        public string? vetName { get; set; }
        public string? vetSurname { get; set; }
        public string? verAdress { get; set; }
        public string? verPhoneNum { get; set; }
        public string? vetIdn { get; set; }
        public int specialtyId { get; set; }
        //Audit Data.
        public DateTime dateUpload { get; set; }
        public DateTime dateUpdate { get; set; }
        public int user { get; set; }
    }
}
