using Veterinary.Infrastructure.Data;
using Veterinary.Infrastructure.Services;
using Veterinary.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Veterinary.Infrastructure.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly VeterinaryContext context;
        public PetRepository(VeterinaryContext context)
        {
            //El this habla de la clase. Entonces el de la izquierda es el de fuera y el otro es el de dentro de esta clase.
            this.context = context;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeletePetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PetFullDto>> GetAll()
        {
            List<PetFullDto> petDto = new();
            if (context.Pets == null)
            {
                //Si no existe retorna un error
                return petDto;
            }
            else
            {
                var pets = await context.Pets.ToListAsync();
                if (pets != null)
                {
                    foreach (var pet in pets)
                    {

                        petDto.Add(new PetFullDto
                        //Por cada elemento de la lista lo agregará de la entidad al DTO.
                        {
                            petId = pet.petId,
                            petName = pet.petName,
                            clientId = pet.clientId,
                            typeId = pet.typeId,
                            dateUpdate = pet.dateUpdate,
                            dateUpload = pet.dateUpload,
                            user = pet.user
                        });
                    }
                    return petDto;
                }
                else
                {
                    return petDto;
                }

            }
        }

        public Task<IEnumerable<PetFullDto>> GetAllPet()
        {
            throw new NotImplementedException();
        }

        public Task<PetFullDto> GetPet(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(PetFullDto entity)
        {
            throw new NotImplementedException();
        }

        public Task SavePetById(PetFullDto pet)
        {
            throw new NotImplementedException();
        }

        public Task Update(PetFullDto entity)
        {
            throw new NotImplementedException();
        }


        ////Indico cual es la base de datos:
        //private readonly VeterinaryContext context;
        //public Task DeletePetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IEnumerable<PetFullDto>> GetAllPet()
        //{
        //    if (context.Pets != null)
        //    {
        //        var pets = await context.Pets.ToListAsync();
        //        List<PetFullDto> _pets = new();
        //        if (pets != null)
        //        {
        //            foreach (var pet in pets)
        //            {
        //                _pets.Add(new PetFullDto
        //                {
        //                    petId = pet.petId,
        //                    petName = pet.petName,
        //                    clientId = pet.clientId,
        //                    typeId = pet.typeId,
        //                    //
        //                    dateUpload = pet.dateUpload,
        //                    dateUpdate = pet.dateUpdate,
        //                    user = pet.user
        //                });
        //            }
        //        }
        //        return _pets;
        //    }
        //    else
        //    {
        //        List<PetFullDto> pet = new();
        //        return pet;
        //    }
        //}

        //public Task<PetFullDto> GetPet(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task SavePetById(PetFullDto client)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
