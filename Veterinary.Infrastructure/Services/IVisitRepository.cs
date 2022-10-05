using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary.Core.DTOs;

namespace Veterinary.Infrastructure.Services
{
    public interface IVisitRepository : IGenericRepository<VisitFullDto>
    {
    }
}
