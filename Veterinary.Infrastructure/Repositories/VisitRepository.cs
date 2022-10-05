using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Data;
using Veterinary.Infrastructure.Services;

namespace Veterinary.Infrastructure.Repositories
{
    public class VisitRepository : IVisitRepository
    {
        private readonly VeterinaryContext context;
        public VisitRepository(VeterinaryContext context)
        { 
            this.context = context;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<VisitFullDto>> GetAll()
        {
            List<VisitFullDto> visitDto = new();
            if (context.Visits == null)
            {
                return visitDto;
            }
            else
            {
                var visits = await context.Visits.ToListAsync();
                if (visits != null)
                {
                    foreach (var visit in visits)
                    {
                        visitDto.Add(new VisitFullDto
                        {
                            visitId = visit.visitId,
                            petId = visit.petId,
                            vetId = visit.vetId,
                            visitDate = visit.visitDate,
                            dateUpload = visit.dateUpload,
                            dateUpdate = visit.dateUpdate,
                            user = visit.user

                        });
                    }
                    return visitDto;

                }
                else
                {
                    return visitDto;
                }
            }
        }

        public Task Insert(VisitFullDto entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(VisitFullDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
