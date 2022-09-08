using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Veterinary.Core.Entities
{
    public class Client
    {
        public int clientId { get; set; }
        public string? clientName { get; set; }
        public string? clientSurname { get; set; }
        public string? clientAdress { get; set; }
        public string? clientPhoneNum { get; set; }
        public string? clientIdn { get; set; } //DNI

        //Audit data
        public DateTime dateUpload { get; set; }
        public DateTime dateUpdate { get; set; }
        public int user { get; set; }
    }
}
