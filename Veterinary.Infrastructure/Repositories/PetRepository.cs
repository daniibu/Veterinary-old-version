using Veterinary.Infrastructure.Data;
using Veterinary.Infrastructure.Services;
using Veterinary.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Veterinary.Infrastructure.Repositories
{
public class PetRepository : IPetRepository
    {
        //Indico cual es la base de datos:
        private readonly VeterinaryContex? veterinaryContex;
        public Task DeletePetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PetFullDto>> GetAllPet()
        {
            if (veterinaryContex.Pets != null)
            {
                var pets = await veterinaryContex.Pets.ToListAsync();
                List<PetFullDto> _pets = new();
                if (pets != null)
                {
                    foreach (var pet in pets)
                    {
                        _pets.Add(new PetFullDto
                        {
                            petId = pet.petId,
                            petName = pet.petName,
                            clientId = pet.clientId,
                            typeId = pet.typeId,
                            //
                            dateUpload = pet.dateUpload,
                            dateUpdate = pet.dateUpdate,
                            user = pet.user
                        });
                    }
                }
                return _pets;
            }
            else
            {
                List<PetFullDto> pet = new();
                return pet;
            }
        }

        public Task<PetFullDto> GetPet(int id)
        {
            throw new NotImplementedException();
        }

        public Task SavePetById(PetFullDto client)
        {
            throw new NotImplementedException();
        }
    }
}
