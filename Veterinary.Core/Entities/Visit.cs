using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public  class Visit
    {
        public int visitId { get; set; }
        public int petId { get; set; }
        public int vetId { get; set; }
        public DateTime visitDate { get; set; }
        //Audit Data.
        public DateTime dateUpload { get; set; }
        public DateTime dateUpdate { get; set; }
        public int user { get; set; }
    }
}
