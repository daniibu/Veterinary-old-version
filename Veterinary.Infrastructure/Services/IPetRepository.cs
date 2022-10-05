
using Veterinary.Core.DTOs;

namespace Veterinary.Infrastructure.Services
{
    public interface IPetRepository : IGenericRepository<PetFullDto>
    {
        //Ver muchas mascotas
        public Task<IEnumerable<PetFullDto>> GetAllPet();
        //Ver una sola mascota:
        public Task<PetFullDto> GetPet(int id);
        //Para guardar una mascota o actualizarlo:
        public Task SavePetById(PetFullDto pet);
        //Para dar de baja a una mascota:
        public Task DeletePetById(int id);
    }
}
