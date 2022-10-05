using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary.Core.DTOs;

namespace Veterinary.Infrastructure.Services
{
    public interface IPetTypeRepository : IGenericRepository<PetTypeFullDto>
    {
        //Ver muchos tipos de mascotas
        public Task<IEnumerable<PetTypeFullDto>> GetAllPetType();
        //Ver una sola mascota:
        public Task<PetTypeFullDto> GetPetType(int id);
        //Para guardar una mascota o actualizarlo:
        public Task SavePetTypeById(PetTypeFullDto pet);
        //Para dar de baja a una mascota:
        public Task DeletePetTypeById(int id);
    }
}
