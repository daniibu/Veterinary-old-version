using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public class Procedure
    {
        public int ProcedureId { get; set; }
        public string? procedure { get; set; }

        //Audit Data
        public DateTime DateUpload { get; set; }
        public DateTime DateUpdate { get; set; }
        public int User { get; set; }

    }
}
